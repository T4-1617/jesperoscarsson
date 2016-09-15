using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndEmpolyeeTracker
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string fullNameBackwards
        {
            get { return string.Format("{0}, {1}", lastName, firstName); }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", lastName, firstName);
        }
    }
}
