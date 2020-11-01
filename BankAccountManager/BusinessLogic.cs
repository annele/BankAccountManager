
using System;
using System.Collections.Generic;

namespace BankAccountManager
{
    public static class BusinessLogic 

    {
        public static AccountsData Data;

        

       public  enum Errors
        {
            UserIDNotFound,
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
        
        public static bool IsIDExists(string userID)
        {
            bool isIDExist;

            if (Data.UserAccounts().ContainsKey(userID))
            {
                isIDExist = true;
            }
            else
                isIDExist = false;
          
            return isIDExist;
        }

        /// <summary>
        /// returns the list of account for the specified user id
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static List<Account> GetAccountsForID(string userID)
        {
            List<Account> accountsForID = new List<Account>();

            Data.UserAccounts().TryGetValue(userID, out accountsForID);
            return accountsForID;
        }


        public static void MakeTransfer(IBankAccount account, TransferType transferType, double amount)
        {



            if (account.Balance > amount && transferType == TransferType.withdraw)
            {
                Console.WriteLine(Errors.NotEnoughBalance);

            }
            else if (amount > new Account().MaxTransactionLimit && transferType == TransferType.deposit)
            {
                Console.WriteLine(Errors.MaxTransactionLimitExceeded);

            }else 
            {
                Console.WriteLine("Transfer is successfull");
            }


        }



    }
}
