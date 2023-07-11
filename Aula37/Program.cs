﻿using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;
using Course.Entities.Enums;

namespace Aula29 //Exercicio resolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> lista = new List<Shape>();
           
           Console.WriteLine("Enter the number of shapes?: ");
           int n = int.Parse(Console.ReadLine());

           for(int i = 1; i <= n; i++){

            Console.WriteLine($"Shape #{i} data: ");
            Console.WriteLine($"Rectangle or Cicle (r/c)?");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if(ch =='r'){

                Console.WriteLine("Width: ");
                double w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Height: ");
                double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Rectangle(w, h, color));
            }else{

                Console.WriteLine("Radius: ");
                double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Cicle(r, color));
            }


           }

           Console.WriteLine();
           Console.WriteLine("Shape Areas: ");
           foreach (Shape shape in lista)
           {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
           }
           
           
        
        }    
    }
}

