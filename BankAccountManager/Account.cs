namespace BankAccountManager
{
    //class BitCoinAccount : IBankAccount
    //{
    //    public string BTCAdress;

    //    public double Balance { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    //    public bool Deposit(double balance)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public bool Withdraw(double balance)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

   public class Account : IBankAccount
    {

        public enum AccountType
        {
            CheckingAccount,
            SavingAccount,
            BausparVertrag
        }

        private double _balance;
        private double _withdrawFee;
        private double _withdrawLimit;
        private double _interest;
        private double _maxTransactionLimit;
        private double _accountNumber;
        

        private AccountType _accountT;



        public AccountType AccountT
        {
            get { return _accountT; }          
        }


        public double AccountNumber
        {
            get
            {
                return _accountNumber;
            }

            set
            {
                _accountNumber = value;
            }
        }
        

        public double MaxTransactionLimit
        {
            get
            {
               return  _maxTransactionLimit;
            }

            set
            {
                _maxTransactionLimit = value;
            }
        }


        public double WithdrawLimit
        {
            get => _withdrawLimit;
            set => _withdrawLimit = value;
        }

        public double Interest
        {
            get => _interest;
            set => _interest = value;
        }

        public double Balance => _balance;

      

        public double WithdrawFee
        {
            get => _withdrawFee;

            set => _withdrawFee = value;
        }
        double IBankAccount.Balance 
        {
            get => _balance; 
           
        }


        public Account()
        {

        }

        public Account(AccountType accountType, double fees, double balance =0, double interest = 0, double limit=10000)
        {
            _accountT = accountType;
            _withdrawFee = fees;
            _balance = balance;
            _interest = interest;
            _maxTransactionLimit = limit;

        }

   

        /// <summary>
        /// implements deposit action
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>

        public bool Deposit(double amount)
        {
            
            bool isDepositl=true;
            _balance = _balance + amount;
            
            return isDepositl;
        }

        /// <summary>
        /// implements withdraw action
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Withdraw(double amount)
        {

            if (_accountT == AccountType.SavingAccount)
                _balance = _balance - amount - _withdrawFee;
            else
                _balance = _balance - amount;

            
            bool isWithdraw = true;


            return isWithdraw;

        }

        public override string ToString()
        {
            if (_accountT == AccountType.CheckingAccount)
                return $"Checking: {Balance}";
            if (_accountT == AccountType.BausparVertrag)
                return $"BausparVertrag: {Balance}";
            if (_accountT == AccountType.SavingAccount)
                return $"Saving: {Balance}";

            return "";
        }

    }
}
