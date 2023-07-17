using Course.Tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
      

        public char Coluna {get; set;}
        public int Linha {get; set;}

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Position toPosicao(){
            return new Position(8 - Linha, Coluna - 'a');
        }

        public override string ToString(){
            return "" + Coluna + Linha;
        }
        
     }
}