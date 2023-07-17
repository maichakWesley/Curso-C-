using Course.Tabuleiro;
using Course;
using System;
using xadrez;
using tabuleiro;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            */
            
            try
            {
                Console.WriteLine();
                Table tab = new Table(8, 8);


                //colocando pecas
                tab.InsertPiece(new Torre(tab, Color.White), new Position(0, 0));
                tab.InsertPiece(new Torre(tab, Color.White), new Position(1, 7));
                tab.InsertPiece(new Rei(tab, Color.Black), new Position(0, 3));
                tab.InsertPiece(new Rei(tab, Color.Black), new Position(3, 4));
                Windon.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            

        }

    }
}
