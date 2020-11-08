using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BankAccountManager
{
    public class Program
    {



        static void Main(string[] args)
        {
            //SelectTransferType();
            //  LoginWithUserID();
            // DisplayUserAccounts();
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
            }
            else

            {
                Console.WriteLine("This user id doesn't exist");
            }


        }


        public static void DisplayUserAccounts()

        {
            if (BusinessLogic.UserIsLoggedin == true)
            {
                Console.WriteLine("Welcome! your accounts are: " + BusinessLogic.CurrentUserAccounts());
            }


        }

        /// <summary>
        ///  User selects the account for the further transfer
        /// </summary>
        /// <param name="userAccounts"></param>
        /// <returns></returns>

        public static Account SelectAccount(List<Account> userAccounts)
        {
            //string checkingAccount = Account.AccountType.CheckingAccount.ToString();
            // string savingAccount = Account.AccountType.SavingAccount.ToString();
            Account account = new Account();
            userAccounts = BusinessLogic.CurrentUserAccounts();

            if (BusinessLogic.UserIsLoggedin == true)
            {
                for (int i = 0; i <= userAccounts.Count; i++)
                {
                    Console.WriteLine($"{i} {account}");
                }

            }
            else
            {
                Console.WriteLine("User isn't logged in");
            }

            Console.WriteLine("Please select the account to transfer: input the number according to the target account");
            int accountNumber = 0;
            if (!Int32.TryParse(Console.ReadLine(), out accountNumber))
            {
                account = userAccounts[accountNumber];
            }
            return account;
        }

     /*   public static void SelectTransferType()
        {
            Console.WriteLine("Select type of transfer for the account:  input the number according to the target transfer");
            //int number = Convert.ToInt32(Console.ReadLine());
            int transferNumber = 0;
            if (int.TryParse(Console.ReadLine(), out transferNumber))
            {
                if (Enum.IsDefined(typeof(BusinessLogic.TransferType), transferNumber))
                {
                    BusinessLogic.TransferType transferType = (BusinessLogic.TransferType)transferNumber;
                    Console.WriteLine(transferType);
                }


            }
        }*/


        public static void Transfer(Account account, BusinessLogic.TransferType transferType, double amount)
        {
            //  string withdraw = BusinessLogic.TransferType.withdraw.ToString();
            // string deposit = BusinessLogic.TransferType.deposit.ToString();


            account = SelectAccount(BusinessLogic.CurrentUserAccounts());

            //choosing the type of transfer
            Console.WriteLine("Select type of transfer for the account: enter 1 to deposit, 2 to withdraw");
              int transferNumber = 0;
            if (int.TryParse(Console.ReadLine(), out transferNumber))
            {
                if (Enum.IsDefined(typeof(BusinessLogic.TransferType), transferNumber))
                {
                    transferType = (BusinessLogic.TransferType)transferNumber;
                    //Console.WriteLine(transferType);
                }
            }

                //entering the amount of money to transfer

                Console.WriteLine("Enter the amount of money to transfer");
                
                if (!Double.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Enter valid amount");
                }
                else
                {
                    amount = Convert.ToDouble(Console.ReadLine());

                }


                switch (transferNumber)
            {
                case 1:
                    if (amount >= 10000)
                    {
                        BusinessLogic.MakeTransfer(account, transferType, amount);
                        Console.WriteLine((BusinessLogic.TransferResult.MaxTransactionLimitExceeded).ToString());
                    }
                    else
                    {
                        BusinessLogic.MakeTransfer(account, transferType, amount);
                        Console.WriteLine((BusinessLogic.TransferResult.TransferOK).ToString());

                    }
                    break;

                case 2:

                    if (amount >account.Balance)
                    {
                        BusinessLogic.MakeTransfer(account, transferType, amount);
                        Console.WriteLine((BusinessLogic.TransferResult.NotEnoughBalance).ToString());

                    }
                    else
                    {
                        BusinessLogic.MakeTransfer(account, transferType, amount);
                        Console.WriteLine((BusinessLogic.TransferResult.TransferOK).ToString());
                    }

                    break;
                default:

                    Console.WriteLine((BusinessLogic.TransferResult.TransferOK).ToString());
                    break;

            }








        }




        }


    }



    


