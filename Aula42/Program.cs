using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Entities.Exceptions;
/*Try e Cat

serve para pegar as exeções*/
namespace Aula41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                 int n1 = int.Parse(Console.ReadLine());
                 int n2 = int.Parse(Console.ReadLine());

                    int result = n1 / n2;
                    Console.WriteLine(result);
            }
            catch (DivideByZeroException e)//cada exeção tem um tipo, então devemos pesquisaro erro e achar qual a exeção. podemos usar varias ex: Exception, DivideByZeroException etc
            {
               Console.WriteLine("Error! " + e.Message);

            }catch(FormatException e){
                Console.WriteLine("Format Error! " + e.Message);
            }
           
            */
            //Criando exeções personalizadas

                try {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (FormatException e) {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e) {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}