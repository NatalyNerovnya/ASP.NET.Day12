using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class Boom : CheckParametrs
    {
        #region Constructor
        /// <summary>
        /// Create boom instance
        /// </summary>
        /// <param name="timer">Event</param>
        public Boom(CustomTimer timer)
        {
            CheckRef(timer);
            Reggister(timer);
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Unreggister from event
        /// </summary>
        /// <param name="timer">event</param>
        public void Unreggister(CustomTimer timer)
        {
            CheckRef(timer);
            timer.StopTimer -= Shoot;
        }

        /// <summary>
        /// Register to event
        /// </summary>
        /// <param name="timer">event</param>
        public void Reggister(CustomTimer timer)
        {
            CheckRef(timer);
            timer.StopTimer += Shoot;
        }
        #endregion

        #region Private methods

        private void Shoot(Object sender, TimerEventArgs eventArgs)
        {
            try
            {
                Process.Start("A-bomb.jpg");
            }
            catch (Win32Exception ex)
            {
                Console.Beep();
            }
        }

        #endregion
    }
}
