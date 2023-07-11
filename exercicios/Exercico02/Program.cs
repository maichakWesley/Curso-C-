
using System;
using System.Globalization;
using Course;

namespace exercicios  // classes e atributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           notas N = new notas();

            Console.Write("Nome do aluno: ");
            N.Nome = Console.ReadLine();

            Console.Write("");
            Console.WriteLine("Digite as três notas do aluno: ");
            N.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("");
            Console.WriteLine(N);

            if (N.NotaFinal() >= 60.00){
                Console.WriteLine($"Aluno aprovado nota final: {N.NotaFinal()}");
            }else{
                double final = 60.00 -  N.NotaFinal();
                Console.WriteLine($"Aluno reprovado: {N.NotaFinal()}");
                Console.WriteLine($"faltam: {final}");
            }
        }    
    }
}
