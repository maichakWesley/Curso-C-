using System;
using System.Globalization;
using Course;


namespace Aula18 //encapsulamento usando novos recursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
           
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?: ");
            char deposito = char.Parse(Console.ReadLine());

            if(deposito == 's' || deposito == 'S'){

                Console.WriteLine("Entre com o valor de depósito inicial: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, valorDeposito);

            }else{

                conta = new ContaBancaria(numero, titular);

            }

            
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double newDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(newDeposito);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
    

            Console.WriteLine("Entre com um valor para saque: ");
            double newSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(newSaque);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
        /*
            Console.WriteLine($"Dados da Conta: \n Conta: {p.Numero}, Titular: {p.Titular}, Saldo: ${p.ValorDeposito}");
           
           Console.WriteLine("Entre com um valor para depósito: ");
            double newDeposito = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados atualizados: ");


            Console.WriteLine($"Dados da Conta: \n Conta: {p.Numero}, Titular: {p.Titular}, Saldo: ${pp.}");

            Console.WriteLine("Entre com um valor para saque: ");
            
            double newSaque = double.Parse(Console.ReadLine());
           Console.WriteLine("Dados atualizados: ");
           */
        }    
    }
}
