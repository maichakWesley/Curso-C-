using System;


namespace Aula05 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lendo dados do teclado parte 2
            int n1 = int.Parse(Console.ReadLine()); //sempre o console retorna como string, para recuperar como inteiro temos que fazer um parse.
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());




            // entradas 32 f 4.32
            Console.WriteLine("você digitou: ");
            Console.WriteLine(n1); // se tentarmos colocar um imput como palavra vai gerar um exeção com erro
            Console.WriteLine(ch);
            Console.WriteLine(n2);

            //pegando tudo em 1 linha só
            string[] vet = Console.ReadLine().Split(' ');
            // aqui temos que informar qual o tipo de variavel vamos receber
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            //entrada maria f 23 1.68

            //print
            Console.WriteLine("você digitou: ");
            Console.WriteLine(nome); // se tentarmos colocar um imput como palavra vai gerar um exeção com erro
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        }   
    }
}