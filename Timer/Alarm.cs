using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class Alarm : CheckParametrs
    {
        #region Constructor
        /// <summary>
        /// Create alarm instance
        /// </summary>
        /// <param name="timer">Event</param>
        public Alarm(CustomTimer timer)
        {
            CheckRef(timer);
            Register(timer);
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Register to event
        /// </summary>
        /// <param name="timer">event</param>
        public void Unreggister(CustomTimer timer)
        {
            CheckRef(timer);
            timer.StopTimer -= RingAlarm;
        }

        /// <summary>
        /// Unreggister from event
        /// </summary>
        /// <param name="timer">event</param>
        public void Register(CustomTimer timer)
        {
            CheckRef(timer);
            timer.StopTimer += RingAlarm;
        }
        #endregion

        #region Private methods

        private void RingAlarm(Object sender, TimerEventArgs eventArgs)
        {
            try
            {
                Process.Start("Yall feat Gabriella Richardson - Hundred Miles .mp3");
            }
            catch (Win32Exception ex)
            {
                Console.Beep();
            }
        }
        #endregion
    }
}
