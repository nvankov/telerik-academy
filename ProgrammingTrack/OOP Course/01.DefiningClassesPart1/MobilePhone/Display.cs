using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Display
    {
        private double size;
        private long numberOfColors;

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, long numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get { return size; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("THe size of the display cannot be set to 0 or less.");
                }
                else
                {
                    size = value;
                }
            }
        }

        public long NumberOfColors
        {
            get { return numberOfColors; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of colors cannot be zero or less.");
                }
                else
                {
                    numberOfColors = value;
                }
            }
        }

        public override string ToString()
        {
            string returnedString;

            if (numberOfColors == 0)
            {
                returnedString = String.Format("Display size: {0}", size);
            }
            else
            {
                returnedString = String.Format("Display size: {0}, number of display colors: {1}", size, numberOfColors);
            }

            return returnedString;
        }
    }
}
