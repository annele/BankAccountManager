using System;

using BankAccounts;

namespace BankAccountManager
{
    class Program
    {
        CheckingAccount checkingAccount = new CheckingAccount();
        SavingAccount savingAccount = new SavingAccount();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }

       

        //calculating the balance of both accounts
        public void GeneralBalance()
        {
            double GeneralBalance = checkingAccount.balance + savingAccount.balance;
            Console.WriteLine("Your balance for both accounts is " + GeneralBalance);
        }



    }

}
