using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Bank
    {
        public List<BankAccount> Accounts { get; set; }
        public Bank()
        {
            Accounts = new List<BankAccount>();
        }

        public void CreateAccount(string accountNumber, string accountName, decimal accountBalance)
        {
            BankAccount newAccount = new BankAccount(accountNumber, accountName, accountBalance);
            Accounts.Add(newAccount);

            Console.WriteLine("ACCOUNT DETAILS\n");
            Console.WriteLine($"Account Name: {accountName}\nAccount Number: {accountNumber}\nAccount Balance: {accountBalance}\n");
        }

        public void MakeDeposit(string accountNumber, decimal amount)
        {
            BankAccount account = Accounts.Find(a => a.AccountNumber == accountNumber);

            
            if (account != null)
            {
                Console.WriteLine("\nDeposit successfully made.\n");
                account.AccountBalance += amount;
                Console.WriteLine($"Recipient name: {account.AccountName}\nRecipient number: {account.AccountNumber}\nAmount deposited: {amount}\nNew balance: {account.AccountBalance}\n");
            }
            else
            {
                Console.WriteLine("Account not found.\n");
            }

        }

        public void WithdrawMoney(string accountNumber, decimal amount)
        {
            BankAccount account = Accounts.Find(a => a.AccountNumber == accountNumber);

            if (account != null)
            {
                if(account.AccountBalance >= amount)
                {
                    Console.WriteLine("\nWithdrawal successfully made.\n");
                    account.AccountBalance -= amount;
                    Console.WriteLine($"Amount withdrawn: {amount}\nNew balance: {account.AccountBalance}\n");
                }
                else
                {
                    Console.WriteLine("Insufficient funds!\n");
                }
            }
            else
            {
                Console.WriteLine("Account not found!\n");
            }
        }

        public void CheckBalance(string accountNumber)
        {
            BankAccount account = Accounts.Find(a => a.AccountNumber == accountNumber);

            if (account != null)
            {
                Console.WriteLine($"Account number: {account.AccountNumber}\nAccount balance: {account.AccountBalance}\n");
            }
            else
            {
                Console.WriteLine("Account not found!\n");
            }

        }

        public void ListAccounts()
        {
            if (Accounts.Count > 0)
            {
                Console.WriteLine("Account List: ");
                foreach ( BankAccount account in Accounts)
                {
                    Console.WriteLine($"Account number: {account.AccountNumber}\nAccount name: {account.AccountName}\nAccount balance: {account.AccountBalance}\n");
                }
            }
            else
            {
                Console.WriteLine("No accounts found!\n");
            }
        }
    }
}
