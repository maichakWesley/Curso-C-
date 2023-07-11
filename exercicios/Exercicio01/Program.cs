using System;
using System.Globalization;
using Course;

namespace exercicios  // classes e atributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionario F = new funcionario();

            Console.Write("Nome funcionário: ");
            F.Nome = Console.ReadLine();
            Console.Write("");
            Console.Write("Salário: ");
            F.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           

            Console.Write("");
            Console.WriteLine(F);

            Console.Write("Digete a porcentagem para aumentar o sálario: ");
            double cpp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(cpp);

            Console.Write("");
            Console.WriteLine(F);
        }    
    }
}
