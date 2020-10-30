


using System.Collections.Generic;

namespace BankAccountManager
{
    class BusinessLogic : AccountsData
    {
        /// <summary>
        /// checks if user id exists
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        
        public bool IsIDExists(string userID)
        {
            bool isIDExist;

            if (UserAccounts().ContainsKey(userID))
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
        public List<Account> GetAccountsForID(string userID)
        {
            List<Account> accountsForID = new List<Account>();

            UserAccounts().TryGetValue(userID, out accountsForID);
            return accountsForID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        public void MakeTransfer(IBankAccount account)
        {


        }


    }
}
