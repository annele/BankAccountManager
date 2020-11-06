using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BankAccountManager
{
   public class Program
    {

     

        static void Main(string[] args)
        {
            LoginWithUserID();
            DisplayUserAccounts();
          //  SelectAccount();
           
         

            

        }


        /// <summary>
        /// Displays Balance to console
        /// </summary>
        /// <param name="account">A bank account</param>
        public static void DisplayBalance(IBankAccount account)
        {
            Console.WriteLine($"Your Balance is {account.Balance } EUR");
        }


       
      

        /// <summary>
        /// Validation of user id- when valid the list of accounts is displayed
        /// </summary>
        /// <returns></returns>

        public static void LoginWithUserID()
        {
          
            Console.WriteLine("Please enter your userID");
            string userID = Console.ReadLine();

            if (BusinessLogic.LoginUser(userID))
            {
                Console.WriteLine("You are logged in. ");
            }  else

            {
                Console.WriteLine("This user id doesn't exist");
            }
       
           
        }
         /*  public List<Account> CurrentUserAccounts(string currentUID)
            {
                 List<Account> currentUserAccounts = BusinessLogic.accountsForID;
                return currentUserAccounts;
             } */

        public static void  DisplayUserAccounts()
            
        {
            if (BusinessLogic.UserIsLoggedin == true)
            {
                Console.WriteLine("Welcome! your accounts are: " + BusinessLogic.CurrentUserAccounts(BusinessLogic.CurrentUID));
            }
              

        }

        /// <summary>
        /// User chooses the acount for further actions
        /// </summary>
        /// <returns>the account for further actions</returns>

        public static Account  SelectAccount (List<Account> userAccounts)
        {
            //string checkingAccount = Account.AccountType.CheckingAccount.ToString();
            // string savingAccount = Account.AccountType.SavingAccount.ToString();
            Account account = new Account();
            userAccounts = BusinessLogic.CurrentUserAccounts(BusinessLogic.CurrentUID);
           
            if(BusinessLogic.UserIsLoggedin == true)
            {

                for (int i = 0; i <= userAccounts.Count; i++)
                {
                    Console.WriteLine($"{i} {account}");
                }
                
            } else
            {
                Console.WriteLine("User isn't logged in");
            }

            Console.WriteLine("Please select the account to transfer: input the number according to the target account");
            int number = Convert.ToInt32(Console.ReadLine());

            account = userAccounts[number];
            return account;
        }


        public static void Transfer (Account account, BusinessLogic.TransferType transferType, double amount)
        {
            //  string withdraw = BusinessLogic.TransferType.withdraw.ToString();
            // string deposit = BusinessLogic.TransferType.deposit.ToString();


            account = SelectAccount(BusinessLogic.CurrentUserAccounts(BusinessLogic.CurrentUID));
            Console.WriteLine("Select type of transfer for the account: enter 1 to deposit, enter 2 to withdraw");
           // string usersChoice = Console.ReadLine();

            Console.WriteLine("Enter the amount of money to transfer");
           // amount = Console.ReadLine();
            if (!Double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Enter valid amount");
            }
            else
            {
                amount = Convert.ToDouble(Console.ReadLine());

            }

          /*  switch (usersChoice)
            {
                case "1":
                    transferType = BusinessLogic.TransferType.deposit;
                    break;

                case "2":
                    transferType = BusinessLogic.TransferType.withdraw;
                    break;                
            }*/

           

           
           
          
        }

  


            }
                 

        }


    


