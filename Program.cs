using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.WriteLine("CREATE NEW ACCOUNT");
            Console.WriteLine("----------------");
            Console.Write("New account number (must be 10 digits): ");
            string accountNumber = Console.ReadLine();
            Console.Write("Fullname: ");
            string accountName = Console.ReadLine();
            Console.Write("Opening balance (optional): ");
            string accountBalanceInput = Console.ReadLine();
            decimal accountBalance = accountBalanceInput.Length > 0 ? Convert.ToDecimal(accountBalanceInput) : 0;
            Console.Write("New password (must be 6 or more characters): ");
            string password = Console.ReadLine();
            Console.Write("Confirm password (must match with new password): ");
            string confirmPassword = Console.ReadLine();

            if (accountNumber != string.Empty && accountNumber.Length == 10)
            {
                
                if (!accountName.Equals(string.Empty))
                {
                    if (!password.Equals(string.Empty))
                    {
                        if(!confirmPassword.Equals(string.Empty))
                        {
                            if (password.Length >= 6 && confirmPassword.Length >= 6)
                            {
                                if (password.Equals(confirmPassword))
                                {
                                    Console.WriteLine("\nAccount creation successful.\n");
                                    bank.CreateAccount(accountNumber, accountName, accountBalance);
                                }
                                else
                                {
                                    Console.WriteLine("\nPasswords do not match.\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nPasswords must be atleast 6 characters.\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter a confirmation password.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a password.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease enter your name.\n");
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a 10-digit account number.\n");
            }

            Console.WriteLine("MAKE DEPOSIT");
            Console.WriteLine("----------------");
            Console.Write("Recipient account number: ");
            accountNumber = Console.ReadLine();
            Console.Write("Enter amount: ");
            string amountInput = Console.ReadLine();
            decimal amount = amountInput.Length > 0 ? Convert.ToDecimal(amountInput) : 0;
            

            if (!accountNumber.Equals(string.Empty) && accountNumber.Length == 10)
            {
                Console.WriteLine("VERIFY RECIPIENT DETAILS\n");
                Console.WriteLine($"Name: {accountName}\nNumber: {accountNumber}");
                Console.Write($"Account number and name correct Y/N?: ");
                string confirm = Console.ReadLine();

                if (confirm == "Y")
                {
                    Console.Write($"Amount correct Y/N? {amount}: ");
                    confirm = Console.ReadLine();
                    if (confirm == "Y")
                    {
                        bank.MakeDeposit(accountNumber, amount);
                    }
                    else
                    {
                        Console.WriteLine("Session time-out.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Session time-out.\n");
                }
            }
            else
            {
                Console.WriteLine("Please enter an account number.\n");
            }

            Console.WriteLine("MAKE WITHDRAWAL");
            Console.WriteLine("----------------");
            Console.Write("From account number: ");
            accountNumber = Console.ReadLine();
            Console.Write("Enter amount: ");
            amountInput = Console.ReadLine();
            amount = amountInput.Length > 0 ? Convert.ToDecimal(amountInput) : 0;

            if (!accountNumber.Equals(string.Empty) && accountNumber.Length == 10)
            {
                Console.WriteLine("VERIFY DEBIT ACCOUNT\n");
                Console.WriteLine($"Name: {accountName}\nNumber: {accountNumber}");
                Console.Write($"Account number correct Y/N?: ");
                string confirm = Console.ReadLine();

                if (confirm == "Y")
                {
                    Console.Write($"Amount correct Y/N? {amount}: ");
                    confirm = Console.ReadLine();
                    if (confirm == "Y")
                    {
                        bank.WithdrawMoney(accountNumber, amount);
                    }
                    else
                    {
                        Console.WriteLine("Session time-out.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Session time-out.\n");
                }
            }
            else
            {
                Console.WriteLine("Please enter an account number.\n");
            }

            
        }
    }
}
