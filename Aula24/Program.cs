using System;
using System.Globalization;
using Course;


namespace Aula18 //Modificadores de parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(s1);
             Console.WriteLine(s2);


             string[] vect = new string[] {"Maria", "Alex", "Bob"};

             foreach(string obj in vect){
                
                Console.WriteLine(obj);

                }//forech passamos o tipo do dados criamos um nome generico e colocamos nosso vetor isso facilita não precisamos escrever igual o for
     
        }    
    }
}
