
using System;
using Interfaces;
using Microsoft.VisualBasic;

namespace BankAccounts
{

	public class SavingAccount : IBankAccount

	{
		
		private double interest;
		private double withdrawFee;
		private double balance;

		public double Balance
		{
			get
			{
				return balance;
			}
			set
			{
				balance = value;
			}
		}



		double IBankAccount.Amount
		{
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}

	
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
				Console.WriteLine("Pleease enter valid deposit amount");
				isSavingDepositSuccessfull = false;
			}

			return isSavingDepositSuccessfull;

		}

		public bool Withdraw(double amount)
		{
			bool isWithdrawSavingSuccessfull;

			Console.WriteLine("Please enter the withdraw amount");
			amount = Convert.ToDouble(Console.ReadLine());

			if (amount<=balance && amount <= 5000)
            {
				balance -= amount;
				isWithdrawSavingSuccessfull = true;

            } else if (amount > 5000 && amount+withdrawFee <= balance)
            {
				balance -= amount + withdrawFee;
				isWithdrawSavingSuccessfull = true;
			}
            else
            {
				Console.WriteLine("Pleease enter valid deposit amount");
				isWithdrawSavingSuccessfull = false;
			}

			return isWithdrawSavingSuccessfull;
			
		}

	}
}
