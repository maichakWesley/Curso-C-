using System;
using System.Globalization;
using Course;


namespace Aula18 //encapsulamento usando novos recursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Produto p =  new Produto("TV", 500.00, 10);

            //assim podemos protegar nossa variaveis.

            //agora podemos só fazer o get

            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            //setando valor novo agora
            p.Name = "T";

            //agora para acessar o get aqui podemos usar o nome GetNome();
            Console.WriteLine(p.Name);

            

            
           
           
        }    
    }
}
