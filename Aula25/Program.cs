using System;
using System.Globalization;
using System.Collections.Generic;


namespace Aula18 //Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Lista é um estrutura de dados:
                * Homogênea (dados do mesmo tipo)
                * Ordenada (elementos acessados por meio de posições)
                * Inicia vazxia, e seus elementos são alocados sob demanda
                * Cada elemento ocupa um nó (ou nodo) lista
            *Classe: list
                * NameSpace: System.Collections.Generic

            *Vantagens:
                * Tamanho variaveis
                * Facilidade para se realizar inserções e deleções
            *Desvantagens:
                * Acesso sequencial aos elementos
            
            */

            List<string> list1 = new List<string>();//instanciando uma lista vazia

            List<string> list2 = new List<string> {"Maria", "Alex"}; //iniciando com elementos

            //add elemtes na lista

            list1.Add("Maria");
             list1.Add("Bob");
              list1.Add("Alex");
               list1.Add("Ana");

               //insert pode escolher a posição para add
               list1.Insert(2, "Ademir");

               

               foreach ( string obj in list1){

                    Console.WriteLine(obj);

               }
                //mostar o tamanho da lista
                Console.WriteLine("List Count: " + list1.Count);

                //função find acha o predicado: é uma função que pega um valor e retorna verdadeiro ou falso conforme a logica.
                // vamos usar um expressão Lambida para não precisar criar um função normal x => x[0] == 'A' passamos o X como parametro usamos um aron => que x[0] vai procurar alguma coisa que inicia com a letra A

                string s1 = list1.Find(x => x[0] == 'A');
                Console.WriteLine("First 'A': " + s1);
                Console.WriteLine("-------------------------------------------------------------------------");
                string s2 = list1.FindLast(x => x[0] == 'A');
                Console.WriteLine("Last 'A': " + s2);
                Console.WriteLine("-------------------------------------------------------------------------");
                int s3 = list1.FindIndex(x => x[0] == 'A');
                Console.WriteLine("First position 'A': " + s3);
                Console.WriteLine("-------------------------------------------------------------------------");
                int s4 = list1.FindLastIndex(x => x[0] == 'A');
                Console.WriteLine("Last position 'A': " + s4);
                Console.WriteLine("-------------------------------------------------------------------------");
                //filtrando lista, precisamos criar uma lsita nova com os filtros que definimos com base na lista existente
                List<string> List3 = list1.FindAll(x => x.Length == 5);//filtra somente os nomes que tem 5 caracteres

                foreach(string obj in List3){
                    Console.WriteLine(obj);
                }

                //remove
                list1.Remove("Alex");
                Console.WriteLine("---------------------------------------------------------------------------");
                foreach(string obj in list1){
                    Console.WriteLine(obj);
                }

                //remove all
                list1.RemoveAll(x => x[0] == 'M');
                Console.WriteLine("---------------------------------------------------------------------------");
                foreach(string obj in list1){
                    Console.WriteLine(obj);
                }

     
        }    
    }
}