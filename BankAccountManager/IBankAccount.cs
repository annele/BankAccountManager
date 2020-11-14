using System;


namespace BankAccountManager
{
	public interface IBankAccount
	{
        public double Balance{ get;  }

		public double MaxTransactionLimit { get; set; }
 
		public bool Withdraw(double amount);
		public bool Deposit(double amount);

			

       
    }
}






