using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;


namespace Aula29 //Sobreposição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Account> list = new List<Account>();
 
            list.Add(new SavingAcount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusnisAcount(1002, "Mario", 500.0, 400.0));
            list.Add(new SavingAcount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusnisAcount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach(Account acc in list){
                sum += acc.Balance;
            }

            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

         /*Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingAcount(1002, "Anna", 500.0, 0.01);

            acc1.withdrae(10.0);
            //como é uma conta diferente não pode descontar o 5, por isso é usado a sobreposição
            acc2.withdrae(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);*/
            
        
        }    
    }
}

