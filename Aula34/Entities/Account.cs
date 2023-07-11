
namespace Course.Entities

{
    abstract class Account //modificando para classe abstrata C:\Users\mie3ct\Desktop\undemyC#\Aula34\Program.cs(14,28): error CS0144: Nao é possível criar uma instância do tipo abstrato ou da interface 'Account' [C:\Users\mie3ct\Desktop\undemyC#\Aula34\Aula34.csproj]
    {//
        public int Number {get; private set;}
        public string Holder {get; private set;}
        public double Balance {get; protected set;}

        public Account(){

        }

        public Account(int number, string holder, double balance){
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //sobreposição
        public virtual void withdrae(double amount){
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount){
            Balance += amount;
        }
    }    
}