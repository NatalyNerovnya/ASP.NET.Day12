using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class TextMessage : CheckParametrs
    {
        #region Constructor
        /// <summary>
        /// Create textMessage instance
        /// </summary>
        /// <param name="timer">Event</param>
        public TextMessage(CustomTimer timer)
        {
            CheckRef(timer);
            Reggister(timer);
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Register to event
        /// </summary>
        /// <param name="timer">event</param>
        public void Reggister(CustomTimer timer)
        {
            CheckRef(timer);
            timer.StopTimer += Message;
        }

        /// <summary>
        /// Unreggister from event
        /// </summary>
        /// <param name="timer">event</param>
        public void Unreggistr(CustomTimer timer)
        {
            CheckRef(timer);
            timer.StopTimer -= Message;
        }

        #endregion

        #region Private methods

        private void Message(Object sender, TimerEventArgs eventArgs)
        {
            try
            {
                Process.Start("msg.txt");
            }
            catch (Win32Exception ex)
            {
                Console.Beep();
            }
        }
        #endregion
    }
}
