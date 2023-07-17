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
                PartidaXadrez partida = new PartidaXadrez();
                while(!partida.Terminada){

                    Console.WriteLine();
                    Windon.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Digite a posição de Origem: ");
                    Position origem = Windon.lerPosicaoXadrez().toPosicao();
                    Console.Write("Digite a posição de Destino: ");
                    Position destino = Windon.lerPosicaoXadrez().toPosicao();

                    partida.executandoMovimento(origem, destino);

                }
              

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            

        }

    }
}
