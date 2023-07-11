using System.Globalization;
namespace Course{
    class Produto{
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade){
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Name {

            get { return _nome;}
            set{
                //como aqui não conseguimos colocar o valor de entrda 
                //nome usamos no lugar o value
                if(value != null && value.Length > 1){
                _nome = value;
           
                }
            }
        }

        public double Preco{
            get { return _preco;}
        }

          public int Quantidade{
           get { return _quantidade;}
        }

        //quando trocamos as variaveis para private a unica maneira de acessar elas no encapsulamento é usando os gets e set
/*
        public string GetNome(){
            return _nome;
        }

        public double GetPreco(){
            return _preco;
        }

        public int GetQuantidade(){
            return _quantidade;
        }*/
/*
        public void SetName(string nome){
            //aqui temos a posibilidade de fazer logicas
            // se nome for diferente de null e seu tamanho maior que 1
            if(_nome != null && _nomeLength > 1){
                _nome = nome;
           
                }
            
        }
        */
        public double ValorTotalEmEstoque(){
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            _quantidade = _quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade){
            _quantidade = _quantidade - quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $" + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades , Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}