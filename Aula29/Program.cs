using System;
using System.Globalization;
using System.Collections.Generic;


namespace Aula29 //Date time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Horario e data atual
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine();
            //---------------------------------------

            //retorna o numero de criação até agora
            Console.WriteLine(d1.Ticks);//criação
            Console.WriteLine();
            //Preset manual de data e hora
            DateTime t1 = new  DateTime(2018, 11, 25, 20, 45, 36);
            Console.WriteLine(t1);
            //---------------------------------------
            
            //timeSpam 
            TimeSpan r1 = new TimeSpan();
            TimeSpan r2 = new TimeSpan(900000000L);
            TimeSpan r3 = new TimeSpan(2 , 11, 21);
            TimeSpan r4 = new TimeSpan();

            Console.WriteLine();
            Console.WriteLine(r1);
            Console.WriteLine();
            Console.WriteLine(r2);
            Console.WriteLine();
            Console.WriteLine(r3);
            Console.WriteLine();

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

             Console.WriteLine();
            DateTime c = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = c.ToLongDateString();
            string s2 = c.ToLongTimeString();
            string s3 = c.ToShortDateString();
            string s4 = c.ToShortTimeString();
            string s5 = c.ToString();
            string s6 = c.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = c.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            
        }    
    }
}