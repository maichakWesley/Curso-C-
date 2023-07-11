using System;
using System.Globalization;
using Course;


namespace Aula18 //vetores parte 2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many rooms will be rented? ");

            int n = int.Parse(Console.ReadLine());

            Registro[] vect = new Registro[n];
            int[] Quartos = new int[9];

            for(int i = 0; i < n; i++){
                
                string name = Console.ReadLine();
                string email = Console.ReadLine();
                int room = int.Parse(Console.ReadLine());

                vect[i] = new Registro {Name = name, Email = email, Room = room};
                Quartos[i] = room;
            }

            int Rooms = 0;
            Console.Clear();
            for(int i = 0; i < n; i++){
                Rooms += 1;
                Console.WriteLine($"Rent #{Rooms}");
                Console.WriteLine($"Name: {vect[i].Name}");
                Console.WriteLine($"Email: {vect[i].Email}");
                Console.WriteLine($"Room: {vect[i].Room}");
                Console.WriteLine();
            }

   
            Console.WriteLine("Busy Rooms");
            
            for (int i = 0; i < Quartos.Length; i++)
            {
                if (Quartos[i] != null)
                {
                    Console.WriteLine($"{Quartos[i]}: {vect[i].Name}, {vect[i].Email}");
                }
}



            
        }    
    }
}
