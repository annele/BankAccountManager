using System;


namespace BankAccountManager
{
	public interface IBankAccount
	{
        public double Balance{ get;  }
 
		public bool Withdraw(double amount);
		public bool Deposit(double amount);

			

       
    }
}






