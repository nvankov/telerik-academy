using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Call
    {
        private DateTime date;
        private string dialedPhone;
        private int duration;

        public Call(DateTime date, string dialedPhone, int duration)
        {
            this.Date = date;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public int Duration
        {
            get { return duration; }
            set 
            {
                if (value >= 0)
                {
                    duration = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The duration of the call cannot be less than zero.");
                }
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (value != null)
                {
                    date = value;
                }
                else
                {
                    throw new ArgumentNullException("The date of the call cannot be null.");
                }
            }
        }

        public string TimeOfCall
        {
            get { return string.Format("{0}/{1}/{2}", date.Hour, date.Minute, date.Second);}
        }

        public string DialedPhone
        {
            get { return dialedPhone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The dialed phone cannot be null or left empty");
                }
                else
                {
                    dialedPhone = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("Call made on {0:D2}/{1:D2}/{2:D4} to {3} with duration of {4} minutes",
                Date.Day, Date.Month, Date.Year, DialedPhone, Duration);
        }
    }
}
