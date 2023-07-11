using System;
using System.Globalization;
using Course;


namespace Aula18 //vetores parte 2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            //criando vetor 

            Produto[] vect = new Produto[n];

          

            for(int i = 0; i < n; i++){
                
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto {Name = name, Price = price};
            }

            double sum = 0.0;
            string conteudo = "";
            Console.Write("Itens = ");
            for(int i = 0; i < n; i++){

                sum += vect[i].Price;
                Console.Write(vect[i].Name + ',');
            }

            double avg = sum / n;

            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
           
        }    
    }
}