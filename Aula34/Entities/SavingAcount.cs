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

        //sobreposição
        public sealed override void withdrae(double amount)
        {   //com o base podemos add novos valores temos o desconto 5 mais o 2.
            base.withdrae(amount);
            Balance -= 2.0;
            //Balance -= amount;
        }
    }
}