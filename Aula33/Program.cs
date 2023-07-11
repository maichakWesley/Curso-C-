using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;


namespace Aula29 //Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
       
        Account acc = new Account(1001, "Alex", 0.0);
        BusnisAcount bacc = new(1002, "Maria", 0.0, 500.00);

        //UPCASTIN
        Account acc1 = bacc;
        Account acc2 = new BusnisAcount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingAcount(1004, "Anna", 0.0, 0.01);

        //DOWNCASTING
        BusnisAcount acc4 = (BusnisAcount)acc2;
        acc4.Loan(100.0);


       //BusnisAcount acc5 = (BusnisAcount)acc3;
        if(acc3 is BusnisAcount){
           // BusnisAcount acc5 = (BusnisAcount)acc3;
           BusnisAcount acc5 = acc3 as BusnisAcount;
            acc5.Loan(200.00);
            Console.WriteLine("Loan");
        }

        if (acc3 is SavingAcount){
            SavingAcount acc5 = (SavingAcount)acc3;
            acc5.UpdateBalance();
            Console.WriteLine("update!");
        }

        //account.Balance = 200.00; como estamos usando o protecd não podemos atribuir valores
        }    
    }
}
