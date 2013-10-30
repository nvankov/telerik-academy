using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    class Battery
    {
        private string model;
        private long hoursIdle;
        private long hoursTalk;
        private BatteryType batteryType;

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, long hoursIdle, long hoursTalk)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, long hoursIdle, long hoursTalk, BatteryType batteryType)
            : this(model, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public long HoursIdle
        {
            get { return hoursIdle; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle value cannot be set to less than zero.");
                }
                else
                {
                    hoursIdle = value;
                } 
            }
        }

        public long HoursTalk
        {
            get { return hoursTalk; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours of talk value cannot be less than zero.S");
                }
                else
                {
                    hoursTalk = value;
                } 
            }
        }

        public BatteryType BatteryType
        {
            get { return batteryType; }
            set { batteryType = value; }
        }

        public override string ToString()
        {
            string returnedString;

            if (model == null)
            {
                returnedString = "Not specified";
            }
            else
            {
                returnedString = string.Format("Battery model: {0}, Hours Idle: {1} " +
                    "Hours Talk: {2}, Battery Type: {3}", model, hoursIdle, hoursTalk, batteryType);
            }

            return returnedString;
        }
    }
}
