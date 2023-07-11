using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;


namespace Aula29 //Exercicio resolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> lista = new List<TaxPayer>();
           
           Console.WriteLine("Enter the number of tax payers: ");
           int n = int.Parse(Console.ReadLine());

           for(int i = 1; i <= n; i++){

            Console.WriteLine($"Tax payer #{i} data: ");
            Console.WriteLine($"Individual or company (i/c)?");
            char ch = char.Parse(Console.ReadLine());
           

            if(ch =='i'){

                Console.WriteLine("Name: ");
                string n1 = Console.ReadLine();
                Console.WriteLine("Anual income: ");
                double a1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Health expenditures: ");
                double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Individual(n1, a1, h));

            }else{

                Console.WriteLine("Name: ");
                string n2 = Console.ReadLine();
                Console.WriteLine("Anual income: ");
                double a2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Number of employees: ");
                int n3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                lista.Add(new Company(n2, a2, n3));
            }


           }

           Console.WriteLine();
           Console.WriteLine("TAXES PAID: ");
           foreach (TaxPayer funcionario in lista)
           {
                Console.WriteLine(funcionario.Name + " : " + " $ " + funcionario.Tax().ToString("F2", CultureInfo.InvariantCulture));
           }
           
           
        
        }    
    }
}

