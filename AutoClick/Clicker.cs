using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoClick
{
    public class Clicker
    {
        private Timer timer;

        public int Delay { get; set; }
        public bool DoubleClick { get; set; }

        public Clicker(int delay, bool doubleClick)
        {
            Delay = delay;
            DoubleClick = doubleClick; 
        }

        public void Start()
        {
            timer = new Timer(Timer_Ticked, null, Delay, Delay);
        }

        private void Timer_Ticked(object _)
        {
            if (DoubleClick)
                Microsoft.Test.Input.Mouse.DoubleClick(Microsoft.Test.Input.MouseButton.Left);
            else
                Microsoft.Test.Input.Mouse.Click(Microsoft.Test.Input.MouseButton.Left);
        }

        public void Stop()
        {
            if (timer != null)
                timer.Dispose();
            timer = null;
        }
    }
}
