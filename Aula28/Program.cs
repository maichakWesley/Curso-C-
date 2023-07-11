using System;
using System.Globalization;
using System.Collections.Generic;


namespace Aula18 //String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string original = "asdf AJHGSD ASD asdf DEKJR";

            //Convertendo tudo para maiuscula
            string s1 = original.ToUpper();
            Console.WriteLine("Original: " + original);
            Console.WriteLine("ToUpper: " + s1);
            Console.WriteLine();
            //----------------------------------------------
            //Convertendo tudo para minusculo
            string s2 = original.ToLower();
            Console.WriteLine("Original: " + original);
            Console.WriteLine("ToLower: -     " + s2    + "   -");
            Console.WriteLine();
            //----------------------------------------------
             //Apaga os espaços em branço
            string s3 = original.Trim();
            Console.WriteLine("Original: " + original);
            Console.WriteLine("Trim: -   " + s3  + "-");
            Console.WriteLine();
            //----------------------------------------------
            //Apaga os espaços em branço
            int s4 = original.IndexOf("df");
            Console.WriteLine("Original: " + original);
            Console.WriteLine("IndexOf: " + s4);
            Console.WriteLine();
            //----------------------------------------------

             //Cortando string
            string s5 = original.Substring(0, 5);
            Console.WriteLine("Original: " + original);
            Console.WriteLine("Substring: " + s5);
            Console.WriteLine();
            //----------------------------------------------

            //replace
            string s6 = original.Replace('a' , 'X');
            Console.WriteLine("Original: " + original);
            Console.WriteLine("Replace: " + s6);
            Console.WriteLine();
            //----------------------------------------------

            //Testando se está vazia ou nula
            //para teste
            string original2 = "";
            bool s7 = string.IsNullOrEmpty(original);
            bool s8 = string.IsNullOrEmpty(original2);
            Console.WriteLine("Original: " + original);
            Console.WriteLine("IsNullorEmpty: " + s7);
            Console.WriteLine("IsNullorEmpty: " + s8);
            Console.WriteLine();
            //----------------------------------------------


            
        }    
    }
}