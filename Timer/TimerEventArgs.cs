using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class TimerEventArgs : EventArgs
    {
        #region Fields
        private readonly int seconds;
        #endregion

        #region Property
        public int Seconds { get { return seconds; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Create instance of TimerEventArgs
        /// </summary>
        /// <param name="seconds">Number of seconds</param>
        public TimerEventArgs(int seconds)
        {
            if(seconds <= 0)
                throw new ArgumentException();
            this.seconds = seconds;
        }
        #endregion


    }
}
