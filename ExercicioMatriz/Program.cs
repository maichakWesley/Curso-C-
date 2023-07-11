using System;
using System.Globalization;
using System.Collections.Generic;


namespace Aula18 //Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Quantas linhas na Matriz: ");
            int L = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas colunas na Matriz: ");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite os valores da matriz: ");
            
            int[,] mat = new int[L, C];

            for (int i = 0; i < L; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int e = 0; e < C; e++)
                {
                    mat[i, e] = int.Parse(values[e]);
                   
                }
            }
            Console.WriteLine();
            Console.WriteLine("Qual número da matriz deseja encontrar? ");
            int x = int.Parse(Console.ReadLine());
      
              for (int i = 0; i < L; i++){
                for (int e = 0; e < C; e++){
                    
                    if(mat[i , e] == x){

                       Console.WriteLine("Position " + i + "," + e + ":");

                       if(e > 0){
                            Console.WriteLine("Left: " + mat[i, e - 1]);
                       }
                       if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, e]);
                        }
                        if (e < L - 1) {
                            Console.WriteLine("Right: " + mat[i, e + 1]);
                        }
                        if (i < C - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, e]);
                        }
                       
                    }
                }
                 //Console.WriteLine();

                  
    
            }
            


/*
        //Console.WriteLine(mat.GetLength(1));
        Console.WriteLine("Minha matriz");
         for (int i = 0; i < l; i++)
            {

                for (int e = 0; e < c; e++)
                {
                    
                    Console.Write(mat[i, e] + " ");

                }
                 Console.WriteLine();
            }

        */

        }    
    }
}