using System;
using Course.Entities.Exceptions;
namespace Course.Entities {
    class Account
    {
        public int Nnumber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

    
    public Account()
    {
        
    }

    public Account(int number, string holder, double balance, double withDrawLimit)
    {
        Nnumber = number;
        Holder = holder;
        Balance = balance;
        WithDrawLimit = withDrawLimit;
    }

    public void Deposit(double amount){

        Balance += amount;

    }

    public void WithDraw(double amount){

       

       if(WithDrawLimit < amount){

            throw new DomainException("Withdraw error: The amount exceeds withdraw limit");

       }if(Balance > amount){

        throw new DomainException("Withdraw error: Not enough balance");

       }
       else{

            Balance -= amount;
       }

    }

    public override string ToString(){
        return "New Balance:  " + Balance;
    }
    }

}