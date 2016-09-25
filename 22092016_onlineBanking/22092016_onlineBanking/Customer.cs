using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22092016_onlineBanking
{
    public class Customer
    {
        //TODO Find usage for ID   

        private System.Collections.ArrayList accounts;

        public Customer()
        {
            accounts = new System.Collections.ArrayList();
        }

        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        private int _uniqueId { get; set; }

        public void CreateAccount(decimal initialDeposit, string accountName)
        {
            if (initialDeposit >= 1000)
            {
                Account temp = new Account() { AccountName = accountName };
                temp.Deposit(initialDeposit);
                accounts.Add(temp);
            }
        }

        public System.Collections.ArrayList GetAccounts()
        {
            return accounts;
        }

        public Account GetAccount(int accountIndex)
        {
            return (Account)accounts[accountIndex];
        }
    }

    public class Account
    {
        public Account()
        {
        }

        public string AccountName { get; set; }
        private decimal _balance { get; set; }

        public string GetAccountInfo()
        {
            return string.Format("{0} has a balance of {1}", AccountName, _balance);
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
    }
}
