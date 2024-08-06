using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Easy_Auto_Click
{
    internal class Time
    {
        public static int TimeInputCalculation(int h, int m, int s, int ms)
        {
            int t = (h * 60 * 60 * 1000) + (m * 60 * 1000) + (s * 1000) + (ms);
            return t;
        }
    }
}