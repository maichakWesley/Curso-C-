using System;
using System.Globalization;



namespace Aula13 // 
{
    internal class Program
    {
        static double Pi = 3.14; //declaramos como static para poder usar no main ou na função
        static void Main(string[] args)
        {
           
          

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circuferencia:" + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine("Valor de PI:" + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }  

        //como estamos criando a função no mesmo escopo, usa o static para podermos usar no main
        static double Circuferencia(double raio){

            return 2.0 * Pi * raio;

        } 

        static double Volume(double raio){

            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);

        } 
    }
}
