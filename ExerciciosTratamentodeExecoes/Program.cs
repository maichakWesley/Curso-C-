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
                try {

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account conta = new Account(number, name, balance, withdraw);


                Console.Write("Enter amount for withdraw: ");
                double removewithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.WithDraw(removewithdraw);
                
                Console.Write(conta);

            
            }
            catch (FormatException e) {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e){
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}