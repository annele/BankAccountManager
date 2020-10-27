using System;
using System.Collections.Generic;

namespace BankAccountManager
{
    class Program
    {


        
        static void Main(string[] args)
        {

            
            //Console.WriteLine("Hello World!");

            




            // foreach (Account a in fredsAccounts)
            // {
            //    Console.WriteLine(checking);
            //  }

        }


        public Dictionary<String, List<Account>> usersAccounts()
        {
            List<Account> AccountList = new List<Account>();

            var dict = new Dictionary<String, List<Account>>();

            var fredID = "1232";
            var checking1232 = new Account(Account.AccountType.CheckingAccount, 5);
            var saving1232 = new Account(Account.AccountType.SavingAccount, 0);
            var fredsAccList = new List<Account>();

            fredsAccList.Add(checking1232);
            fredsAccList.Add(saving1232);

            var theresaID = "1111";
            var checking1111 = new Account(Account.AccountType.CheckingAccount, 5);
            var saving1111 = new Account(Account.AccountType.SavingAccount, 0);
            var theresaAccList = new List<Account>();

            theresaAccList.Add(checking1111);
            theresaAccList.Add(saving1111);

            var markID = "1112";
            var checking1112 = new Account(Account.AccountType.CheckingAccount, 5);
            var saving1112 = new Account(Account.AccountType.SavingAccount, 0);
            var markAccList = new List<Account>();

            markAccList.Add(checking1112);
            markAccList.Add(saving1112);


            dict.Add(fredID, fredsAccList);
            dict.Add(theresaID, theresaAccList);
            dict.Add(markID, markAccList);

            var fredsAccounts = dict["1232"];
            var theesaAccounts = dict["1111"];
            var markAccounts = dict["1112"];

            return dict;
        }

        /// <summary>
        /// Displays Balance to console
        /// </summary>
        /// <param name="account">A bank account</param>
        public static void DisplayBalance(IBankAccount account)
        {
            Console.WriteLine($"Your Blance is {account.Balance } EUR");
        }

        public void MakeTransfer(IBankAccount account)
        {
            
        }

        public void InputUserID()
        {
            
            Console.WriteLine("Please enter your userID");
            string userID = Console.ReadLine();

           if( usersAccounts().ContainsKey(userID))
            {
                Console.WriteLine();
            }
        }

     
    }

}
