using System;


namespace Interfaces
{
	public interface IBankAccount
	{
            public double Amount { get; set; }
 
			public bool Withdraw(double amount);
			public bool Deposit(double amount);

		

       
    }
}






