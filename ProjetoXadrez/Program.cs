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
            try
            {
                Console.WriteLine();
                Table tab = new Table(8, 8);


                //colocando pecas
                tab.InsertPiece(new Torre(tab, Color.White), new Position(0, 0));
                tab.InsertPiece(new Torre(tab, Color.White), new Position(1, 7));
                tab.InsertPiece(new Rei(tab, Color.White), new Position(0, 3));
                Windon.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }



        }

    }
}
