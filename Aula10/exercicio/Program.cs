using System;
using System.Globalization;
using Course;


namespace Aula08 // for
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
         Pessoas p, i;

         Pessoas p1 = new Pessoas();
         Pessoas p2 = new Pessoas();

         Console.Write("Digite os dados da primeira pessoa, nome e idade: ");
            p1.P = Console.ReadLine();
            p1.I = int.Parse(Console.ReadLine());

        Console.Write("Digite os dados da segunda pessoa, nome e idade: ");
            p2.P = Console.ReadLine();
            p2.I = int.Parse(Console.ReadLine());
        

        if (p1.I > p2.I){
            Console.Write($"{p1.P} é maior que {p2.P},{p1.P} tem: {p1.I} de idade");
        }else{
            Console.Write($"{p2.P} é maior que {p1.P},{p2.P} tem: {p2.I} de idade");
        }
       

        }    
    }
}

