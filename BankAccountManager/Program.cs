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
            SelectAccount();
            ChooseTransferType();
         

            

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
            Account account;
            userAccounts = BusinessLogic.CurrentUserAccounts(BusinessLogic.CurrentUID);
           
            if(BusinessLogic.UserIsLoggedin == true)
            {
                foreach (Account a in userAccounts)
                {
                    account = a; 
                    Console.WriteLine(account);

                }
            } else
            {
                Console.WriteLine("User isn't logged in");
            }

            Console.WriteLine("Please select the account to transfer");
            string accountChoise = Console.ReadLine();
            

            return account;
        }


        public static void Transfer (Account account, BusinessLogic.TransferType transferType, double amount)
        {
            string withdraw = BusinessLogic.TransferType.withdraw.ToString();
            string deposit = BusinessLogic.TransferType.deposit.ToString();

            

            Console.WriteLine("Select type of transfer for the account: enter 1 to deposit, enter 2 to withdraw");
             transferType = Console.ReadLine();

            Console.WriteLine("Enter the amount of money to transfer");

            if (!Double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Enter valid amount");
            }
            else
            {
                amount = Convert.ToDouble(Console.ReadLine());

            }

            switch (transferType)
            {
                case BusinessLogic.TransferType.deposit:
                    


            }
        }

        public static String ChooseTransferType()
        {

            string withdraw = BusinessLogic.TransferType.withdraw.ToString();
            string deposit = BusinessLogic.TransferType.deposit.ToString();

            Console.WriteLine("Please choose the type of transaction: {0}  or  {1}", withdraw, deposit);
            string transferType = Console.ReadLine();
            if (transferType!= withdraw && transferType != deposit)
            {
                Console.WriteLine("This type of transfer is incorrect");
            } else 
            {
                return transferType;
            }

            return "";
        }

        public static Double EnterAmountToTransfer()
        {

            string transferType = ChooseTransferType();

            Console.WriteLine("Enter the amount to " + transferType);
             
             if(! Double.TryParse(Console.ReadLine(), out double amount)) {
                Console.WriteLine("Enter valid amount");
            } else
            {
                return amount;
            }

            return amount;
            
        }

       public static void TransferMoney()
        {
            string account = SelectAccount();
            string transferType = ChooseTransferType();
            double amount = EnterAmountToTransfer();


        }
      
           


            }
                 

        }


    


