using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22092016_onlineBanking
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }

        public int customerID { get; set; }

        public string fullName
        {
            get { return string.Format("{0} {1}", firstName, lastName); }
        }
    }

    public class Account
    {
        public int accountID;

        private float accBalance;

        public float balance
        {
            get { return accBalance; }
            set { accBalance = value; }
        }
    }
}
