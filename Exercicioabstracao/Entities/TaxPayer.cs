
namespace Course.Entities
{
    abstract class TaxPayer
    {
        public string Name {get; set;}
        public double AnualIncome {get; set;}

        public TaxPayer(string name, double anualIncome){

            Name = name;
            AnualIncome = anualIncome;

        }
        
        //operação abstrata
        public abstract double Tax();
    }
}