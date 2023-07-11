using System;

namespace Aula01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variavel tipos 
            bool b = true;
            sbyte x = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            x++;

            float n4 = 4.5f; //para o float funcionar no final se coloca a letra f para não se confundir com dooble
            string nome = "wesley maihcak";

            //a variavel object pode ser declarada para conterqualquer valor tanto string quanto numerico
            object obj1 = "Pedro";
            object obj2 = 123;

            //valor min e max
            int c1 = int.MinValue;
            int c2 = int.MaxValue;
            sbyte c3 = sbyte.MinValue;
            decimal c4 = decimal.MaxValue;

            Console.WriteLine(b);
            Console.WriteLine(x);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
