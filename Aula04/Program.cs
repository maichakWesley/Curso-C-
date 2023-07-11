using System;


namespace Aula04 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lendo dados do teclado 

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            //aqui vamos escrever mais de uma palvra então vamos fazer um recorte para mostrar todas usando o split(' ')
            //vamos usar um vetor 'array' para colocar as palvras e recortar

            string s = Console.ReadLine(); // entrada batata tomate abacaxi
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            //para facilitar pode ser feito dessa forma string[] vet =  Console.ReadLine().Split(' ');

            Console.WriteLine($"Você digitou: {frase}");
            Console.WriteLine($"Você digitou: {x}");
            Console.WriteLine($"Você digitou: {y}");
            Console.WriteLine($"Você digitou: {z}");
            Console.WriteLine($"Meu vetor: {s}");
            Console.WriteLine($"Meu vetor posição 0: {p1}");
            Console.WriteLine($"Meu vetor posição 1: {p2}");
            Console.WriteLine($"Meu vetor posição 2: {p3}");

        }   
    }
}
