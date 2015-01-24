using Microsoft.Test.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick
{
    public class KeyStroke
    {
        public List<Key> MsTestKeys { get; set; }

        public override string ToString()
        {
            return string.Join(" + ", MsTestKeys.Select(k => k.ToString()));
        }

        public static KeyStroke FromString(string text)
        {
            return new KeyStroke
            {
                MsTestKeys = string.IsNullOrEmpty(text) ?
                    new List<Key>() :
                    text
                        .Split('+')
                        .Select(p => (Key)Enum.Parse(typeof(Key), p.Trim()))
                        .ToList()
            };
        }

        public bool IsSameAs(KeyStroke r) 
        {
            if (r == null)
                return false;
            if (MsTestKeys == null)
                return r.MsTestKeys == null;
            if (r.MsTestKeys == null)
                return false;
            if (MsTestKeys.Count != r.MsTestKeys.Count)
                return false;
            return MsTestKeys.All(k => r.MsTestKeys.Contains(k));
        }

        public KeyStroke Clone()
        {
            return new KeyStroke { MsTestKeys = MsTestKeys };
        }

        private static Microsoft.Test.Input.Key MsKeyToTestKey(System.Windows.Forms.Keys keys)
        {
            var name = Enum.GetName(typeof(System.Windows.Forms.Keys), keys);
            Microsoft.Test.Input.Key result;
            if (!Enum.TryParse<Microsoft.Test.Input.Key>(name, out result))
                return Microsoft.Test.Input.Key.None;
            return result;
        }

        public static KeyStroke FromKeys(System.Windows.Forms.Keys keys, bool shift, bool ctrl, bool alt)
        {
            var msKey = KeyStroke.MsKeyToTestKey(keys);
            if (msKey == Microsoft.Test.Input.Key.None)
                return null;

            var keyStroke = new KeyStroke { MsTestKeys = new List<Microsoft.Test.Input.Key>() };
            if (alt)
                keyStroke.MsTestKeys.Add(Microsoft.Test.Input.Key.LeftAlt);
            if (ctrl)
                keyStroke.MsTestKeys.Add(Microsoft.Test.Input.Key.LeftCtrl);
            if (shift)
                keyStroke.MsTestKeys.Add(Microsoft.Test.Input.Key.LeftShift);
            keyStroke.MsTestKeys.Add(msKey);
            return keyStroke;
        }
    }
}
