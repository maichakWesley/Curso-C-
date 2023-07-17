using Course.Tabuleiro;

namespace xadrez
{
    class Rei : WorckPiece
    {
        public Rei(Table tab, Color cor) : base(tab, cor){

        }

        public override string ToString()
        {
            return "R";
        }
    }
}