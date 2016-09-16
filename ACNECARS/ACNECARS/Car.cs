using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACNECARS
{
    class Car
    {
        public string model { get; set; }
        public string color { get; set; }
        public string make { get; set; }
        public bool available { get; set; }
        //Holds customer info when car is booked
        public string fName { get; set; }
        public string lName { get; set; }
        public string teleNumb { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}  has hired a {2} {3} {4}", fName, lName, color, make, model);
        }
    }
}
