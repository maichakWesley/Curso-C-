using System.Globalization;
namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree {get;set;}


        public ImportedProduct(){


        }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price) {
            
            CustomsFree = customsFree;

        }

        public override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + "(Customs fee: $ )" + CustomsFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }


        public double totalPrice(){
            return Price + CustomsFree;
        }
        
    }
}