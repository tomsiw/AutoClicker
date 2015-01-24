using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;

namespace AutoClick
{
    public class KeyboardWatcher
    {
        private KeyboardHookListener keyboardListener;
        private KeyStroke onKeyToWatch;
        private KeyStroke offKeyToWatch;

        public event EventHandler<EventArgs> KeyOnFired;
        public event EventHandler<EventArgs> KeyOffFired;

        public KeyboardWatcher(KeyStroke onKeyStroke, KeyStroke offKeyStroke)
        {
            onKeyToWatch = onKeyStroke;
            offKeyToWatch = offKeyStroke;
        }

        public void Start()
        {
            Stop();
            keyboardListener = new KeyboardHookListener(new GlobalHooker());
            keyboardListener.KeyDown += keyboardListener_KeyDown;
            keyboardListener.Start();
        }

        public void Stop()
        {
            if (keyboardListener == null)
                return;
            keyboardListener.Stop();
            keyboardListener.Dispose();
            keyboardListener = null;
        }

        private void keyboardListener_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            var keyStroke = KeyStroke.FromKeys(e.KeyCode, e.Shift, e.Control, e.Alt);
            if (keyStroke == null)
                return;
            if (keyStroke.IsSameAs(onKeyToWatch) && KeyOnFired != null)
                KeyOnFired(this, new EventArgs());
            if (keyStroke.IsSameAs(offKeyToWatch) && KeyOffFired != null)
                KeyOffFired(this, new EventArgs());
        }
    }
}
