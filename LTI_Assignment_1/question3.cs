using System;
using System.Collections.Generic;
using System.Text;

namespace LTI_Assignment_1
{
    class Account
    {
        string BankName = "HDFC BANK";
        internal string AccountNumber { get; set; }
        internal string AccountBalance { get; set; }
        internal string AccountPasswords { get; set; }
        internal Account(string aNumber, string aBalance, string aPassword)
        {
            this.AccountBalance = aBalance;
            this.AccountNumber = aNumber;
            this.AccountPasswords = aPassword;
        }
        internal void displayAccount()
        {
            Console.WriteLine("WELCOME TO {0}!!", BankName);
            Console.WriteLine("Account Number: {0} | Account Balance: {1} | Account Password: {2} ", AccountNumber,
                AccountBalance, AccountPasswords);
        }
    
    }
    class question3
    {
        static void Main()
        {
            string aNumber;
            string aBalance;
            string aPassword;
            Console.WriteLine("Enter the Account Number: ");
            aNumber = Console.ReadLine();
            Console.WriteLine("Enter the Account Balance: ");
            aBalance = Console.ReadLine();
            Console.WriteLine("Set the Account Password: ");
            aPassword = Console.ReadLine();
            Account account = new Account(aNumber,aBalance,aPassword);
            account.displayAccount();
        }

    }
}
