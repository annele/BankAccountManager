namespace BankAccountManager
{
    class Account : IBankAccount
    {
        private double amount;
        private double balance;
        private double withdrawFee;
        private double withdrawLimit;
        private double interest;
    

  
        

        public double Amount 
        {
            get => amount;
            set => amount=value;
        }

        public double Balance => balance;

      

        public double WithdrawFee
        {
            get => withdrawFee;

            set => withdrawFee = (amount * 100) / 5;
        }


        public enum Accounts
        {
            ChecingAccount,
            SavingAccount
        }


        

        public bool Deposit(double amount)
        {
            //throw new System.NotImplementedException();

            bool isDepositSuccessful=true;

            return isDepositSuccessful;
        }

        public bool Withdraw(double amount)
        {
            throw new System.NotImplementedException();
        }
    }
}
