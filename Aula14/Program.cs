using System;
using System.Globalization;
using Course;


namespace Aula14 // Otimizando projeto Aula13
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
        
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //ver os uso do static no calculadora.cs
            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circuferencia:" + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine("Valor de PI:" + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }  


    }
}
