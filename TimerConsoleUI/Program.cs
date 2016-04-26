using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace TimerConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomTimer timer = new CustomTimer();
            Alarm alarm = new Alarm(timer);
            timer.Start(2);
            alarm.Unreggister(timer);
            Boom boom = new Boom(timer);
            TextMessage msg = new TextMessage(timer);
            timer.Start(5);
        }
    }
}
