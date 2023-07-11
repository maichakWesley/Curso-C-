namespace Course.Entities
{
    class BusnisAcount : Account
    {
        public double LoanLimit {get; set;}

        public BusnisAcount(){

        }

        public BusnisAcount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance){
            LoanLimit = loanLimit;
        }

        public void Loan(double amount){

            if(amount <= LoanLimit){
                Balance += amount;
            }
            
        }
    }
    
}