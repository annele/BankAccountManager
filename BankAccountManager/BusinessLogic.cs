
using System;
using System.Collections.Generic;

namespace BankAccountManager
{
    public static class BusinessLogic 

    {
      
        public static String CurrentUID = "";


        public static bool  UserIsLoggedin
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
            deposit,
            withdraw
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


        public static bool Logout (string userID)
        {
            
            return CurrentUID == null;
        }

        /// <summary>
        /// returns the list of account for the specified user id
        /// </summary>
        /// <param name="CurrentUID"></param>
        /// <returns></returns>
        public static List<Account> CurrentUserAccounts(string CurrentUID)
        {
            List<Account> currentUserAccounts = new List<Account>();

            AccountsData.UserAccounts().TryGetValue(CurrentUID, out currentUserAccounts);
           
            //string userAccounts = string.Join(",", currentUserAccounts);
            return currentUserAccounts;
        }

     

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="transferType"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static TransferResult  MakeTransfer(IBankAccount account, TransferType transferType, double amount)
        {
           
            switch (transferType)
            {
                case TransferType.deposit:

            }

            if (  amount > account.Balance && transferType == TransferType.withdraw )
            {
                return TransferResult.NotEnoughBalance;

            }
            else if (amount > account.MaxTransactionLimit && transferType == TransferType.deposit)
            {
               return TransferResult.MaxTransactionLimitExceeded;

            } else if(transferType ==TransferType.deposit) 
            {
                account.Deposit(amount);
                
            } else if (transferType == TransferType.withdraw) 

             {
                account.Withdraw(amount);
            }

            return  TransferResult.TransferOK;
        }

        

    }
}
