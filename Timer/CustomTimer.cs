using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    //Если запустите мое консольное приложение TimerConsoleUI, то будет твориться магия!
    public class CustomTimer
    {
        #region Fields
        public event EventHandler<TimerEventArgs> StopTimer = delegate { };
        #endregion

        #region Public methods
        /// <summary>
        /// Begin timer
        /// </summary>
        /// <param name="seconds">Number of seconds</param>
        public void Start(int seconds)
        {
            if (seconds <= 0)
                throw new ArgumentException();
            Thread.Sleep(seconds * 1000);
            OnStopTimer(new TimerEventArgs(seconds));
        }
        #endregion

        #region Private methods

        private void OnStopTimer(TimerEventArgs e)
        {
            EventHandler<TimerEventArgs> timer = StopTimer;
            if (ReferenceEquals(timer, null) || ReferenceEquals(e, null))
                throw new ArgumentNullException();
            timer(this, e);
        }

        #endregion
    }
}