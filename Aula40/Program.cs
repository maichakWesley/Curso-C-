using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

namespace Aula29 //Leitura de pastas e sub pastas
/*
FileStream
https://msdn.microsoft.com/en-us/library/system.io.filestream(v=vs.90).aspx
Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura
e escrita.
Suporte a dados binários.
Instanciação:
• Vários construtores
• File / FileInfo

read bytes---------------FileStream
write bytes----------´´
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //com esse metodo podemos instanciar sem precisar fechar o stream. diminuindo codigo
            string path = @"C:\Users\mie3ct\Desktop\undemyC#\Curso-C-\Exercicios-io";

           try {
            // IEnumerable<string> folder para conseguir criar uma variavel com as informações devemos usar dessa forma, e também usar a biblioteca using System.Collections.Generic;
             IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);//"*.*" qualquer nome de arquivo e qualquer extensão, SearchOption.AllDirectories quais diretorios
                Console.WriteLine("FOLDERS: ");
            foreach(string s in folders){
                Console.WriteLine(s); //listando os caminhos e as pastas 
            }
            //podemos usar tam´bem o var que faz o tipo eferencia, se passar o mouse por cima vemos e assim não precisa usar a biblioteca using System.Collections.Generic;
             var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);//"*.*" qualquer nome de arquivo e qualquer extensão, SearchOption.AllDirectories quais diretorios
                Console.WriteLine("FILES: ");
            foreach(string f in files){
                Console.WriteLine(f); //listando os caminhos e as pastas 
            }
            //criando pasta
            Directory.CreateDirectory(path + "\\newFolder");//precisa das duas barras invertidas se não usarmos o @"\newFolder"



           }
            catch (IOException e) {

                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);

            }

       
            
        }    
    }
}


