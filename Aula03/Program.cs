using System;
using System.Globalization;

namespace Aula03 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversão implicia é quando quero passar uma varivael como paramentro para outra 
            //ex: float x  = 4.5f; double y = x;

            //agora se tentar fazer o processo inverso doble a; float b; a = 5.1; b = a; não pode converter dessa forma porque uma varial que tem 8 byte estou tentand colocar em 4 byte;
            // isso se chama cast

            double a;
            double b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b); 

            // exemplo de divisão com int, temos que usar o cast para não comer casas decimais
            
            int c1 = 5;
            int c2 = 2;

            double resultado = (double) c1 / c2;
            Console.WriteLine(resultado); 

        }   
    }
}
