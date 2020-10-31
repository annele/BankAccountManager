using System;
using System.Collections.Generic;

namespace BankAccountManager
{
   public class Program
    {


        
        static void Main(string[] args)
        {

           
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

        public void InputUserID()
        {
          
            Console.WriteLine("Please enter your userID");
            string userID = Console.ReadLine();
            if (BusinessLogic.IsIDExists(userID))
            {
                Console.WriteLine();
            } 
       
           
        }


        /// <summary>
        /// User chooses the acount for further actions
        /// </summary>
        /// <returns>the account for further actions</returns>

        public String SelectAccount()
        {
            Console.WriteLine("Please select the account");
            string chosenAccount = Console.ReadLine();
            return chosenAccount;
            
        }

        /// <summary>
        /// The user chooses the action to perform on the account and inputs the amount of money for the desired operation. The user input is validated
        /// </summary>

        public void AccountAction()
        {
            Console.WriteLine("Please choose the type of transaction: withdraw or deposit.");
            string userAction = Console.ReadLine();

            Console.WriteLine("Enter the desired amount of money to " + userAction);
            int amount = Convert.ToInt32(Console.ReadLine());

            if(userAction == "deposit" && amount >= 10000)
            {
                Console.WriteLine("Please address to your bank manager to perform this operation");

            } else if(userAction == "deposit" && amount < 10000) {
                Console.WriteLine("You have successfully amde the transaction");

            } else if (userAction == "withdraw")
            {
                Console.WriteLine("");
            } else
            {
                Console.WriteLine("YOu choice is incorrect, please choose valid account operation");
            }

        }

     
    }

}
