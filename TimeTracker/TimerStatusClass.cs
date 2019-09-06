using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TimeTracker
{
    public class TimerStatusClass
    {
        private bool _timerStatus;
        private DateTime _timeOfEvent;

        public bool TimerStatus {
            get {
                return _timerStatus;
            }
            private set {
                _timerStatus = value;
            }
        }
        
        public DateTime TimeOfEvent {
            get {
                return _timeOfEvent;
            }
            private set {
                _timeOfEvent = value;
            }
        }

        public TimerStatusClass(bool newTimerStatus)
        {
            TimerStatus = newTimerStatus;
            if (newTimerStatus) TimeOfEvent = DateTime.Now;
        }

        public Color GetColor()
        {
            if (TimerStatus)
            {
                return Color.PaleGreen;
            }
            else
            {
                return Color.IndianRed;
            }
        }

        public bool GetStatus()
        {
            return TimerStatus;
        }

        public DateTime GetTimeOfEvent()
        {
            return _timeOfEvent;
        }
    }
}
