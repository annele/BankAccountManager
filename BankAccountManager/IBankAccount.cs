using System;


namespace Interfaces
{
	public interface IBankAccount
	{
          double balance { get; set; }
		// int pin { get; set; }
		 int accountNumber { get; set; }

		  



      
			bool Withdraw(double amount);
			bool Deposit(double amount);

		

       
    }
}






