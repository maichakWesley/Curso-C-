using System;
using System.Globalization;
using Course;


namespace Aula14 // Otimizando projeto Aula13
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
        
            Console.Write("Qual a contação do dolar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Qual dolares ira comprar? ");
            double comprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //ver os uso do static no calculadora.cs
            double valorpago = ConversordeMoeda.Conversor(dolar, comprar);
           
            Console.WriteLine("Valor pago em reais:" + valorpago.ToString("F2", CultureInfo.InvariantCulture));
           
        }  


    }
}
