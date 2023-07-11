using System;
using System.Globalization;
using System.Collections.Generic;


namespace Aula18 //Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        /*
            //Matriz bidimensional
            double[,] mat = new double[2,3];

            Console.WriteLine(mat.Length);//quantos elementos no total
            Console.WriteLine(mat.Rank);//quantidade de linha
            Console.WriteLine(mat.GetLength(0));//volta a dimenção linhas
            Console.WriteLine(mat.GetLength(1));//volta a dimenção colunas
        */

        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n , n];

        for(int l = 0; l < n; l++){

            string[] values = Console.ReadLine().Split(' ');

            for(int c = 0; c < n; c++){

              Console.Write(mat[l,c] = int.Parse(values[c]));  

            }

        }

        Console.WriteLine("Main diagonal: ");

        for( int i = 0; i < n; i++){

            Console.Write((mat[i,i] + " "));
        }

            Console.WriteLine();

        int count = 0;
        for(int l = 0; l < n; l++){
            for(int c = 0; c < n; c++){

               if (mat[l,c] < 0){
                    count++;
               } 

            }

        }
        Console.WriteLine("Negative numbers: " + count);
        

        }    
    }
}