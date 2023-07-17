using Course.Tabuleiro;

namespace xadrez
{
    class PartidaXadrez
    {
        public Table tab {get; private set;}
        private int turno;
        private Color jogadorAtual;
        public bool Terminada {get; private set;}

        public PartidaXadrez(){
            tab = new Table(8,8);
            turno = 1;
            jogadorAtual = Color.White;
            Terminada = false;
            colocarPecas();
        }

        public void executandoMovimento(Position origem, Position destino){
            WorckPiece w = tab.retirarPeca(origem);
            w.incrementarQtMovimentos();
            WorckPiece pecaCapturada = tab.retirarPeca(destino);
            tab.InsertPiece(w, destino);
        }

        private void colocarPecas(){

                tab.InsertPiece(new Torre(tab, Color.White), new PosicaoXadrez('c',1).toPosicao());
               tab.InsertPiece(new Torre(tab, Color.White), new PosicaoXadrez('h',1).toPosicao());

        }
    }
}