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
         
            List<Product> list = new List<Product>();

           Console.WriteLine("Enter the number of products: ");
           int n = int.Parse(Console.ReadLine());

           for(int i = 1; i <= n; i++){
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             
                if(ch == 'i'){
                    Console.Write("Customs fee: ");
                    double addicionalcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, addicionalcharge));
                }if(ch == 'c'){
                    list.Add(new Product(name, price));
                }if(ch == 'u'){
                    Console.Write("Manufacture date(DD/MM/YYYY)Ex:15/03/2017: ");
                    DateTime birthManufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, birthManufacture));
                }



           }

           Console.WriteLine();
           Console.WriteLine("Price Tags: ");
           foreach(Product emp in list){
            Console.WriteLine(emp.priceTag());
           }
        
        }    
    }
}

