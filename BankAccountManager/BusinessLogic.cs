
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BankAccountManager
{
    public static class BusinessLogic

    {

        public static String CurrentUID = "";


        public static bool UserIsLoggedin
        {
            get
            {
                return CurrentUID != "";
            }
        }



        public enum TransferResult
        {
            TransferOK,
            NotEnoughBalance,
            MaxTransactionLimitExceeded,

        }

        public enum TransferType
        {
            deposit = 1,
            withdraw = 2
        }

        /// <summary>
        /// checks if user id exists
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>

        public static bool LoginUser(string userID)
        {
            bool isIDExist;

            if (AccountsData.UserAccounts().ContainsKey(userID))
            {
                isIDExist = true;
                CurrentUID = userID;

            }
            else
                isIDExist = false;

            return isIDExist;
        }


        public static bool Logout()
        {
            bool isLoggedOut;
            if (LoginUser(CurrentUID))
            {
                CurrentUID = null;
                isLoggedOut = true;
            }
            else
                isLoggedOut = false;
            return isLoggedOut;
        }

        /// <summary>
        /// returns the list of account for the specified user id
        /// </summary>
        /// <param name="CurrentUID"></param>
        /// <returns></returns>
        public static List<Account> CurrentUserAccounts()
        {
            List<Account> currentUserAccounts = new List<Account>();
            AccountsData.UserAccounts().TryGetValue(CurrentUID, out currentUserAccounts);
            return currentUserAccounts;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="transferType"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static TransferResult MakeTransfer(IBankAccount account, TransferType transferType, double amount)
        {

            switch (transferType)
            {
                case TransferType.deposit:
                    if (amount > account.MaxTransactionLimit)
                    {
                        return TransferResult.MaxTransactionLimitExceeded;
                    }

                    else
                    {
                        account.Deposit(amount);
                        return TransferResult.TransferOK;

                    }
                // return TransferResult.TransferOK;

                case TransferType.withdraw:
                    if (amount > account.Balance)
                    {
                        return TransferResult.NotEnoughBalance;

                    }
                    else
                    {
                        account.Withdraw(amount);
                        return TransferResult.TransferOK;
                    }

            }
            return TransferResult.TransferOK;


        }
    }
}
