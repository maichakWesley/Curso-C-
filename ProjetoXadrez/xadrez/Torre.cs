using Course.Tabuleiro;

namespace xadrez
{
    class Torre : WorckPiece
    {
        public Torre(Table tab, Color cor) : base(tab, cor){

        }

        public override string ToString()
        {
            return "T";
        }
    }
}