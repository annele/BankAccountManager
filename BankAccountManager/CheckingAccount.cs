using System;
using System.Transactions;
using Interfaces;

namespace BankAccounts

{
	public class CheckingAccount : IBankAccount
	{

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
		{   get => throw new NotImplementedException(); 
			set => throw new NotImplementedException(); 
		}

        public bool Deposit(double amount)
		{
            bool isCheckingDepositSuccessfull;

			Console.WriteLine("Please enter the deposit amount");
			amount = Convert.ToDouble(Console.ReadLine());

			if(amount <=10000 && amount >0)
            {
				balance += amount;
				isCheckingDepositSuccessfull = true;

            } else if (amount>10000)
            {
				Console.WriteLine("Please address to the bank manager");
				isCheckingDepositSuccessfull = false;
            } else
            {
				Console.WriteLine("Pleease enter velid deposit amount");
				isCheckingDepositSuccessfull = false;
			}

            return isCheckingDepositSuccessfull;
		}

		public bool Withdraw(double amount)
		{
			bool isCheckingWithdrawSuccessfull;

			Console.WriteLine("Please enter the withdraw amount");
			amount = Convert.ToDouble(Console.ReadLine());

			if (amount <= balance)
			{
				balance -= amount;
				isCheckingWithdrawSuccessfull = true;
			}
			else 
            {
				Console.WriteLine("Not enough money to perform the operation, please enter the valid withdraw amount");
				isCheckingWithdrawSuccessfull = false;
            } 

			return isCheckingWithdrawSuccessfull;
		}



	}
}
