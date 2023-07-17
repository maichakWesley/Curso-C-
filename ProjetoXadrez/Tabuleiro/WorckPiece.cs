using Course.Tabuleiro;

namespace Course.Tabuleiro
{
    class WorckPiece
    {
      

        public Position Posicao { get; set; }
        public Color Cor { get; protected set; }
        public int Moviment { get; protected set; }
        public Table Tab { get; set; }

        public WorckPiece(Table tab, Color cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            Moviment = 0;
            
           
        }

        public void incrementarQtMovimentos(){
            Moviment++;
        }

    }
}