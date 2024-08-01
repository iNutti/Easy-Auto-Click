using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
//using System.Threading.Tasks;

namespace Easy_Auto_Click
{
    internal class Time
    {
        public static System.Timers.Timer aTmr = new System.Timers.Timer();

        public static int TimeInputCalculation(int h, int m, int s, int ms)
        {
            int t = (h * 60) + (m * 60) + (s * 60) + (ms);
            return t;
        }

        public static void TimerClass(int countdownTimer)
        {
            aTmr.Interval = countdownTimer;
            aTmr.Elapsed += eventHandlerClass.TimeElapsed;
            aTmr.Enabled = true;
            aTmr.AutoReset = true;
            aTmr.Start();
        }
    }
}
