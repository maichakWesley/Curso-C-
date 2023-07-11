using System;
using System.Globalization;
using System.Collections.Generic;


namespace Aula18 //var + switcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // uso do var 
        var x = 10;
        var y = 20.0;
        var z = "Maria"; 
        
        //uso swit case
        Console.WriteLine("Digite um valor para saber o dia: ");
        int w = int.Parse(Console.ReadLine());
        string day;

        switch(w){
            case 1:
                day = "Sunday";
                        break;
            case 2:
                day = "monday";
                    break;
            case 3:
                day = "Tuesday";
                        break;
            case 4:
                day = "Wenesday";
                    break;
            case 5:
                day = "Thursday";
                    break;
            case 6:
                day = "Friday";
                        break;
            case 7:
                day = "Saturday";
                    break;
            default:
                day = "Invalid value";
                break;
        }

        Console.WriteLine("Day: " + day);

        }    
    }
}