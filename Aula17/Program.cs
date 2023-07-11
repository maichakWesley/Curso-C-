using System;
using System.Globalization;
using Course;


namespace Aula17 //encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Produto p =  new Produto("TV", 500.00, 10);

            //assim podemos protegar nossa variaveis.

            //agora podemos só fazer o get

            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

            //setando valor novo agora
            p.SetName("TV 4K");

            //agora para acessar o get aqui podemos usar o nome GetNome();
            Console.WriteLine(p.GetNome());

            

            
           
           
        }    
    }
}