namespace Course.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees {get; set;}

        public Company(string name, double anualIncome,  int numberOfEmployees) : base(name, anualIncome){
            
            NumberOfEmployees = numberOfEmployees;
        
        }

        public override double Tax()
        {
            double percent = 0.0;
            
            if(NumberOfEmployees <= 10){

             return percent = AnualIncome * 0.14;


            }else{

             return percent = AnualIncome * 0.16;

    
            }
           
        }
    }
}