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
         // ChooseAction();
         // CurrentUserAccounts();

        }


        /// <summary>
        /// Displays Balance to console
        /// </summary>
        /// <param name="account">A bank account</param>
        public static void DisplayBalance(IBankAccount account)
        {
            Console.WriteLine($"Your Blance is {account.Balance } EUR");
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
            if (BusinessLogic.UserIsLoggedin ==true)
            {
               
                foreach (Account a in BusinessLogic.CurrentUserAccounts(BusinessLogic.CurrentUID))
                {
                    Console.WriteLine("Welcome! your accounts are: " + a);
                }
            } else
            {
                Console.WriteLine("User isn't logged in");
            }

        }

        /// <summary>
        /// User chooses the acount for further actions
        /// </summary>
        /// <returns>the account for further actions</returns>

        public static String SelectAccount()
        {
            string checkingAccount = Account.AccountType.CheckingAccount.ToString();
            string savingAccount = Account.AccountType.SavingAccount.ToString();

            Console.WriteLine("Please select the account: ");
            string chosenAccount = Console.ReadLine();
            // if (chosenAccount !== accountsForID )
            return chosenAccount;
            
        }





        public static void MakeSomeTransfer()
        {
            
            string withdraw = BusinessLogic.TransferType.withdraw.ToString();
            string deposit = BusinessLogic.TransferType.deposit.ToString();

            Console.WriteLine("Please choose the type of transaction: {0} , {1}", withdraw, deposit );
            string userAction = Console.ReadLine();

            Console.WriteLine("Enter the amount to " + userAction);
             
             if(! Double.TryParse(Console.ReadLine(), out double amount)) {
                Console.WriteLine("Enter valid amount");
            } else
            {
                
            }
           
            

            if (userAction == withdraw) 
            {

            }
            
        }

      /*  public static void PerformAction(string userAction )
        {
            Console.WriteLine("Enter the desired amount of money to " + userAction);
           

            //make transfer method 
            if (userAction == "deposit" && amount >= 10000)
            {
                
                Console.WriteLine("Please address to your bank manager to perform this operation");

            }
            else if (userAction == "deposit" && amount < 10000)
            {
                Console.WriteLine("You have successfully amde the transaction");

            }
            else if (userAction == "withdraw")
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("YOu choice is incorrect, please choose valid account operation");



            }*/
            

         


           
             

        }


    }


