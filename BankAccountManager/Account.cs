namespace BankAccountManager
{
    partial class Account : IBankAccount
    {



        private double amount;
        private double balance;
        private double withdrawFee;
        private double withdrawLimit;
        private double interest;

        public AccountType accountType;


        public double Amount 
        {
            get => amount;
            set => amount=value;
        }

        public double WithdrawLimit
        {
            get => withdrawLimit;
            set => withdrawLimit = value;
        }

        public double Interest
        {
            get => interest;
            set => interest = value;
        }

        public double Balance => balance;

      

        public double WithdrawFee
        {
            get => withdrawFee;

            set => withdrawFee = (amount * 100) / 5;
        }


        public Account(double amount, double balance, double withdrawFee, double withdrawLimit, double interest, AccountType accountType)
        {
            this.amount = amount;
            this.balance = balance;
            this.withdrawFee = withdrawFee;
            this.withdrawLimit = withdrawLimit;
            this.interest = interest;
            this.accountType = AccountType.SavingAccount;
        }

        public Account(double amount, double balance, AccountType accountType)
        {
            this.amount = amount;
            this.balance = balance;
            this.accountType = AccountType.ChecingAccount;
        }


        public bool Deposit(double amount)
        {
            //throw new System.NotImplementedException();

            bool isDepositl=true;

            balance += amount;
            return isDepositl;
        }

        public bool Withdraw(double amount)
        {
            //throw new System.NotImplementedException();
            bool isWithdraw = true;

            balance -= amount;

            return isWithdraw;

        }
    }
}
