using System;
using System.Globalization;
using Course;


namespace Aula08 // for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo x, y;

            x = new triangulo();
            y = new triangulo();


            Console.Write("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.Write("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            //calculando área do triangulo

            double areaX = x.Area();
            
            double areaY = y.Area();

            Console.WriteLine("Área de X: " + areaX.ToString("F4"));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4"));
            
        
        }    
    }
}
