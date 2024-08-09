using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal AccountBalance { get; set; }

        public BankAccount(string accountNumber, string accountName, decimal accountBalance)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            AccountBalance = accountBalance;
        }
    }
}
