using System;
using System.Globalization;

namespace Aula02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write() não pula linha
            //Console.WriteLine() pula linha

            double saldo = 10.35784;

            //dessa forma vai imprimir com a quantidade de casas decimal que escolhi
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));

            //dessa forma o separador do decimal vira o ponto e remove a virgula, a virgula vai ser add por conta da região
            //para isso precisamo add a biblioteca using System.Globalization;
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            //PlaceHolders

            string nome = "Maria";
            int idade = 32;
            double saldoo = 20.2345;

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade,saldoo);

            //interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //concatenação de strings
             Console.WriteLine(nome + "tem " + idade + "anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");



        }
    }
}
