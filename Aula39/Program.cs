using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

namespace Aula29 //Strem Reader
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
            string path = @"C:\Users\mie3ct\Desktop\undemyC#\Curso-C-\file1.txt";

           try {

            using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e) {

                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);

            }

            /*
            string path = @"C:\Users\mie3ct\Desktop\undemyC#\Curso-C-\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try{
                //abrindo stream
                
                sr = File.OpenText(path);

               
                while(!sr.EndOfStream){
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

                

            }catch(IOException e){
                Console.WriteLine("An erro occurred");
                 Console.WriteLine(e.Message);
            }finally{//fechando stream

                if(sr != null) sr.Close();
             

            }
            */
            
        }    
    }
}


