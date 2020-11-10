
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BankAccountManager
{
    public class Program
    {

        static void Main(string[] args)
        {

            Account account;
            BusinessLogic.TransferType transferType;
            Double amount;

            LoginWithUserID();
            account = SelectAccount();
            DisplayBalance(account);
            transferType = SelectTransferType();
            amount = EnterAmount();
            Transfer(account, transferType, amount);
            DisplayBalance(account);

            UserLogout();

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
            }
            else

            {
                Console.WriteLine("This user id doesn't exist");
            }


        }



        /// <summary>
        ///  User selects the account for the further transfer
        /// </summary>
        /// <param name="userAccounts"></param>
        /// <returns></returns>

        public static Account SelectAccount()
        {
            //string checkingAccount = Account.AccountType.CheckingAccount.ToString();
            // string savingAccount = Account.AccountType.SavingAccount.ToString();
            Account account = new Account();
            var userAccounts = BusinessLogic.CurrentUserAccounts();

            if (BusinessLogic.UserIsLoggedin)
            {
                for (int i = 0; i < userAccounts.Count; i++)
                {
                    Console.WriteLine($"{i} {userAccounts[i]}");
                }

            }
            else
            {
                Console.WriteLine("User isn't logged in");
            }

            Console.WriteLine("Please select the account to transfer: input the number according to the target account");
            int accountNumber = 0;

            while (!Int32.TryParse(Console.ReadLine(), out accountNumber) || accountNumber > userAccounts.Count)
            {
                Console.WriteLine("Please enter the valid number");
            }

            account = userAccounts[accountNumber];

            return account;
        }

        /// <summary>
        /// account selection for the transfer
        /// </summary>
        /// <returns></returns>

        public static BusinessLogic.TransferType SelectTransferType()
        {
            Console.WriteLine("Select type of transfer for the account: enter 1 to deposit, enter 2 to withdraw");
            //int number = Convert.ToInt32(Console.ReadLine());
            int transferNumber = 0;
            if (int.TryParse(Console.ReadLine(), out transferNumber))
            {
                if (Enum.IsDefined(typeof(BusinessLogic.TransferType), transferNumber))
                {
                    BusinessLogic.TransferType transferType = (BusinessLogic.TransferType)transferNumber;
                    Console.WriteLine(transferType);
                    return transferType;

                }

            }
            return BusinessLogic.TransferType.deposit;
        }

        /// <summary>
        /// user enters the amount to transfer, the amount is varified
        /// </summary>
        /// <returns></returns>
        public static Double EnterAmount()
        {
            double amount;
            Console.WriteLine("Enter the amount of money to transfer");

            while (!Double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Enter valid amount");

            }

            return amount;
        }

        /// <summary>
        /// making transfer to users's account 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="transferType"></param>
        /// <param name="amount"></param>
        public static void Transfer(Account account, BusinessLogic.TransferType transferType, double amount)
        {
            BusinessLogic.TransferResult result = BusinessLogic.MakeTransfer(account, transferType, amount);

            switch (result)
            {
                case BusinessLogic.TransferResult.MaxTransactionLimitExceeded:
                    Console.WriteLine("The max transaction amount is exceeded, please enter the amount less then 10000");
                    break;
                case BusinessLogic.TransferResult.NotEnoughBalance:
                    Console.WriteLine("There's not enough balance for the desired transfer");
                    break;
                case BusinessLogic.TransferResult.TransferOK:
                    Console.WriteLine("Transfer is successfull");
                    break;
                default:
                    Console.WriteLine("Transfer is successfull");
                    break;
            }


        }


        public static void UserLogout()
        {
            Console.WriteLine("Enter \"Logout\" for logout");
            string logout = Console.ReadLine();

            if(logout == "Logout")
            {
                BusinessLogic.Logout();
                Console.WriteLine("You are logged out");
            } else
            {
                Console.WriteLine("Entered  isn't valid");
            }
        }



    }


}






