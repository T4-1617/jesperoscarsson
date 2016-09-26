using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22092016_onlineBanking
{
    public class Customer
    {
        private System.Collections.ArrayList accounts;

        public Customer()
        {
            accounts = new System.Collections.ArrayList();
        }

        public string Name { get; set; }
        public string TelephoneNumber { get; set; }

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
        private System.Collections.ArrayList transactions;

        public Account()
        {
            transactions = new System.Collections.ArrayList();
        }

        public string AccountName { get; set; }
        private decimal _balance { get; set; }

        public decimal GetBalance()
        {
            return _balance;
        }

        public string GetAccountInfo()
        {
            return string.Format("{0} has a balance of {1}", AccountName, _balance);
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
            transactions.Add(new Transaction() { AccountName = this.AccountName, Difference = amount, IsDepositOrWithdraw = "deposited" });
        }

        public void Withdraw(decimal amount)
        {
            if (_balance - amount >= 500)
            {
                _balance -= amount;
                transactions.Add(new Transaction() { AccountName = this.AccountName, Difference = amount, IsDepositOrWithdraw = "withdrew" });
            }
        }

        public System.Collections.ArrayList GetTransactionHistory()
        {
            return transactions;
        }
    }

    public class Transaction
    {
        public Transaction()
        {
        }

        public string IsDepositOrWithdraw { get; set; }
        public decimal Difference { get; set; }
        public string AccountName { get; set; }

        public string GetTransaction
        {
            get { return string.Format("{0} {1} {2}", AccountName, IsDepositOrWithdraw, Difference.ToString()); }
        }
    }
}
