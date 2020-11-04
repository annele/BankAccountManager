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

        public static void  SelectAccount()
        {
            //string checkingAccount = Account.AccountType.CheckingAccount.ToString();
           // string savingAccount = Account.AccountType.SavingAccount.ToString();

            Console.WriteLine("Please select the account ");

            string chosenAccount = Console.ReadLine();
            if (BusinessLogic.CurrentUserAccounts(BusinessLogic.CurrentUID).Contains(chosenAccount))
            {
                Console.WriteLine("This account doesn't exist");
            }
           
            
        }



        public static String ChooseTransferType()
        {

            string withdraw = BusinessLogic.TransferType.withdraw.ToString();
            string deposit = BusinessLogic.TransferType.deposit.ToString();

            Console.WriteLine("Please choose the type of transaction: {0}  or  {1}", withdraw, deposit);
            string transferType = Console.ReadLine();
            if (transferType!= withdraw || transferType != deposit)
            {
                Console.WriteLine("This type of transfer is incorrect");
            } else 
            {
                return transferType;
            }

            return "";
        }

        public static void EnterAmountToTransfer(string transferType)
        {

            
            Console.WriteLine("Enter the amount to " + transferType);
             
             if(! Double.TryParse(Console.ReadLine(), out double amount)) {
                Console.WriteLine("Enter valid amount");
            } else
            {
                
            }
           
            
            
        }

       public static void TransferMoney()
        {

           

         }

           


            }
            

         


           
             

        }


    


