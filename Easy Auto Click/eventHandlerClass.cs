using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Easy_Auto_Click
{
    internal class eventHandlerClass
    {
        public static void TimeElapsed(Object sender, ElapsedEventArgs e)
        {

            Console.WriteLine("The event was complete at {0:HH:mm:ss.fff}", e.SignalTime);

            // throw new Exception();
        }
    }
}
