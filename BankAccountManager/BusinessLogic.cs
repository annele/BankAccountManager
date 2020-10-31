


using System.Collections.Generic;

namespace BankAccountManager
{
    public static class BusinessLogic 

    {
        public static AccountsData Data;
        

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        public static  void MakeTransfer(IBankAccount account)
        {


        }


    }
}
