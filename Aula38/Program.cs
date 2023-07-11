using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

namespace Aula29 //File, FileInfo
/*File, FileInfo
• Namespace System.IO
• Realiza operações com arquivos (create, copy, delete, move, open, etc.) e
ajuda na criação de objetos FileStream.
• File
• static members (simples, mas realiza verificação de segurança para cada operação)
• https://msdn.microsoft.com/en-us/library/system.io.file(v=vs.110).aspx
• FileInfo
• instance members
• https://msdn.microsoft.com/en-us/library/system.io.fileinfo(v=vs.110).aspx

IOException
Namespace System.IO
• IOException
• DirectoryNotFoundException
• DriveNotFoundException
• EndOfStreamException
• FileLoadException
• FileNotFoundException
• PathTooLongException
• PipeException

*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string sourcePath = @"C:\Users\mie3ct\Desktop\undemyC#\Curso-C-\file1.txt";
            string targetPath = @"C:\Users\mie3ct\Desktop\undemyC#\Curso-C-\file2.txt";

            try{

                FileInfo fileInfo = new FileInfo(sourcePath);

                //fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines){
                    Console.WriteLine(line);
                }

            }catch(IOException e){
                Console.WriteLine("An erro occurred");
                 Console.WriteLine(e.Message);
            }

            
        }    
    }
}

