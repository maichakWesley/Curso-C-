
using System;
using System.Globalization;

namespace Aula07 // while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        while(x >= 0.0){
            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("Digite um número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        Console.WriteLine("Número negativo");
        }
    }
}