using System;
using System.Globalization;
using System.Collections.Generic;
using Course;

namespace Aula18 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
                N funcionários. Não deve haver repetição de id.
                Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
                Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
                mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
                conforme exemplos.
                Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
                ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
                aumento por porcentagem dada.
                (exemplo na próxima página)

                How many employees will be registered? 3
                    Emplyoee #1:
                    Id: 333
                    Name: Maria Brown
                    Salary: 4000.00

                    Emplyoee #2:
                    Id: 536
                    Name: Alex Grey
                    Salary: 3000.00

                    Emplyoee #3:
                    Id: 772
                    Name: Bob Green
                    Salary: 5000.00

                    Enter the employee id that will have salary increase : 536
                    Enter the percentage: 10.0

                    Updated list of employees:
                    333, Maria Brown, 4000.00
                    536, Alex Grey, 3300.00
                    772, Bob Green, 5000.00
            */
     
            Console.WriteLine("How many employees will be registered? ");

            int n = int.Parse(Console.ReadLine());

            List<Employeer> list = new List<Employeer>();

            int count = 0;
            for(int i = 0; i < n; i++){
                count += 1;

                Console.WriteLine("Employee #" + count + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                list.Add(new Employeer(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            
            Employeer emp = list.Find(x => x.Id == idIncrease);
            if(emp != null){

                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);
           
                emp.IncreseSalary(percentage);

            }else {
                Console.WriteLine("This id does not exist!");
            }


            Console.WriteLine("Updated list of employees: ");
            foreach(Employeer obj in list) {

                Console.WriteLine(obj);//.Id + obj.Name + obj.Salary deveria ser assim mas como estou usando o override na classe não precisa
            }

        }    
    }
}