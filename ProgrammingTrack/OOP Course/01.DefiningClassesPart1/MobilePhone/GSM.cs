using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;
        private static Battery iPhoneBattery = new Battery("IPhone4S Battery", 0, 0, BatteryType.LiIon);
        private static Display iPhoneDisplay = new Display(3.5, 65000);
        private static GSM iPhone4s = new GSM("IPhone4S", "Apple", 1000, null, iPhoneBattery, iPhoneDisplay);

        #region Constructors

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }

        #endregion

        #region Properties

        public string Model
        {
            get { return model; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The model cannot be null");
                } 
                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Manufacturer field cannot be null");
                }
                manufacturer = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price of the phone cannot be less than zero.");
                } 
                this.price = value;
            }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public Display Display
        {
            get { return display; }
            set { display = value; }
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
        }

        public static GSM IPhone4s
        {
            get { return GSM.iPhone4s; }
        }

        #endregion

        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }

        public void DeleteCall(int callIndex)
        {
            callHistory.RemoveAt(callIndex);
        }

        public void DeleteAllCalls()
        {
            callHistory.Clear();
        }

        public decimal CalculateTotalPrice(decimal pricePerMinute)
        {
            decimal totalMinutes = 0;

            foreach (var item in callHistory)
            {
                totalMinutes += item.Duration;
            }

            return totalMinutes * pricePerMinute;
        }

        public override string ToString()
        {
            string returnedString;

            if (owner != null)
            {
                returnedString = String.Format("Model: {0}, Manufacturer: {1}, Price: {2}, Owner: {3}, " +
                "Battery: {4}, Display: {5}", model, manufacturer, price, owner, battery.ToString(), display.ToString());
            }
            else
            {
                returnedString = String.Format("Model: {0}, Manufacturer: {1}, Price: {2}, " +
                "Battery: {3}, Display: {4}", model, manufacturer, price, battery.ToString(), display.ToString());
            }

            return returnedString;
        }
    }
}
