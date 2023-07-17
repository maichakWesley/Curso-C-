using Course.Tabuleiro;
using System;

namespace Course
{
    class Windon
    {

        public static void imprimirTabuleiro(Table tab){

            for(int i = 0; i < tab.Linhas; i++){
                for(int e = 0; e < tab.Colunas; e++){

                    if(tab.peca(i, e) == null){
                        
                        Console.Write("- ");
                    }else{
                        Console.Write(tab.peca(i, e) + " ");
                    }

                    

                }

                Console.WriteLine();
            }
        }
        
    }
}