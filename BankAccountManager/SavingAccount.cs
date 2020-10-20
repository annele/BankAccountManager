
using System;
using Interfaces;

namespace BankAccounts
{

	public class SavingAccount : IBankAccount

	{
		
		private double interest;
		private double withdrawFee;
      

       

        public double balance
		{
			get => throw new NotImplementedException(); 
			set => throw new NotImplementedException();
		}


		public int accountNumber 
		{ 
			get => throw new NotImplementedException(); 
			set => throw new NotImplementedException(); 
		}
		//public int pin 
		//{ 
		//	get => throw new NotImplementedException(); 
		//	set => throw new NotImplementedException(); 
	//	}

		public double Interest
        {
            get {
				return interest;
			 }
			set {
				interest = value;
			}
        }

		public double WithdrawFee
		{
			get
			{
				return withdrawFee;
			}
			set
			{
				withdrawFee = value;
			}
		}


	


        public bool Deposit(double amount)
		{
			bool isSavingDepositSuccessfull;

			Console.WriteLine("Please enter the deposit amount");
			amount = Convert.ToDouble(Console.ReadLine());

			if (amount <= 10000 && amount > 0)
			{
				balance += amount;
				isSavingDepositSuccessfull = true;

			}
			else if (amount > 10000)
			{
				Console.WriteLine("Please address to the bank manager");
				isSavingDepositSuccessfull = false;
			}
			else
			{
				Console.WriteLine("Pleease enter velid deposit amount");
				isSavingDepositSuccessfull = false;
			}

			return isSavingDepositSuccessfull;

		}

		public bool Withdraw(double amount)
		{

		}

	}
}
