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
         
            List<Employee> list = new List<Employee>();

           Console.WriteLine("Enter the number of employees: ");
           int n = int.Parse(Console.ReadLine());

           for(int i = 1; i <= n; i++){
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("value per hours: ");
                double valuePorHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y'){
                    Console.Write("Addicional charge: ");
                    double addicionalcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valuePorHours, addicionalcharge));
                }else{
                    list.Add(new Employee(name, hours, valuePorHours));
                }



           }

           Console.WriteLine();
           Console.WriteLine("Payments: ");
           foreach(Employee emp in list){
            Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
           }
        
        }    
    }
}
