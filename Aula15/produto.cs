using System.Globalization;
namespace Course{
    class Produto{
        public string Nome;
        public double Preco;
        public int Quantidade;
        //vamos colocar um construtor para poder inicializar os dados com valores

        public Produto(string nome, double preco, int quantidade){
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade){
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades , Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

