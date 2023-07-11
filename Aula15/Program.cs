using System;
using System.Globalization;
using Course;


namespace Aula15 // usando recursos da aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //como criamos um contrutor na nossa classe agora temos que inicializar com algum valor
            
            
            Console.Write("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //agora nosso contrutor não inicia vazio, porque estamos passando parametros para ele
            Produto p = new Produto(nome, preco, quantidade);
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser add no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser Removido no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
        }    
    }
}
