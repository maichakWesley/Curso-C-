using Course.Tabuleiro;
using Course;
using System;
using xadrez; 

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Table tab = new Table(8, 8);
           

           //colocando pecas
           tab.InsertPiece(new Torre(tab, Color.White), new Position(0,0));
           tab.InsertPiece(new Torre(tab, Color.White), new Position(1,3));
           tab.InsertPiece(new Rei(tab, Color.White), new Position(2,4));
            Windon.imprimirTabuleiro(tab);

            Console.ReadLine();

        }

    }
}
