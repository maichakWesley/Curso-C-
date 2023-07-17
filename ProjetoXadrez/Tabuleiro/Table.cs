
using tabuleiro;
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

        public WorckPiece peca(Position pos){
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool existePeca(Position pos){
            
            validarPosicao(pos);            
            return peca(pos) != null;
        }

        public WorckPiece retirarPeca(Position pos){
            if (peca(pos) == null){
                return null;
            }
            WorckPiece aux = peca(pos);
            aux.Posicao = null;
            Pecas[pos.Linha, pos.Coluna] = null;
            return aux;
            
        }

        public void InsertPiece(WorckPiece p, Position pos){

            if(existePeca(pos)){
                throw new TabuleiroException("Já existe uma peça nesa posição");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;

        }

        public bool posicaoValida(Position pos){

            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas){
                return false;
            }

            return true;
        }

        public void validarPosicao(Position pos){

            if(!posicaoValida(pos)){
                throw new TabuleiroException("Posição inválida");
            }

        }
    }
}