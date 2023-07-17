using Course.Tabuleiro;
using System;
using xadrez;
namespace Course
{
    class Windon
    {

        public static void imprimirTabuleiro(Table tab){

            for(int i = 0; i < tab.Linhas; i++){
                
                Console.Write(8 - i + " ");

                for(int e = 0; e < tab.Colunas; e++){

                    if(tab.peca(i, e) == null){
                        
                        Console.Write("- ");

                    }else{

                        imprimirPeca(tab.peca(i, e));
                        Console.Write(" ");

                    }
                }

                Console.WriteLine();
            }
        Console.WriteLine("  a b c d e f g h ");
        }

        public static PosicaoXadrez lerPosicaoXadrez(){
            string s =  Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);

        }

        public static void imprimirPeca(WorckPiece peca){
            if (peca.Cor == Color.White){
                Console.Write(peca);
            }else{
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
        
    }
}