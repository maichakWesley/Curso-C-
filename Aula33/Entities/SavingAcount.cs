namespace Course.Entities

{
    class SavingAcount : Account
    {
        public double IntersRate {get; set;}

        public SavingAcount(){

        }

        public SavingAcount(int number, string holder, double balance, double intersRate) : base(number, holder, balance){
            IntersRate = intersRate;
        }

        public void UpdateBalance(){
            Balance += Balance * IntersRate;
        }
    }
}