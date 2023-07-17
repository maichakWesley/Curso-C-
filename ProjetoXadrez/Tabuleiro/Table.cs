

namespace Course.Tabuleiro
{
    class Table
    {

        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private WorckPiece[,] Pecas;

        public Table(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new WorckPiece[Linhas, Colunas];
        }

        public WorckPiece peca(int l, int c){
            return Pecas[l, c];
        }

        public void InsertPiece(WorckPiece p, Position pos){

            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;

        }
    }
}