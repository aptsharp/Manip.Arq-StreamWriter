using System;
using System.IO;

namespace Manip.Arq
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\aff-o\source\repos\Manip.Arq\Msg.txt";
            string targetPath = @"C:\Users\aff-o\source\repos\Manip.Arq\Msg0.txt";

            Console.WriteLine(sourcePath);

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                //append é uma palavra de concatenação (acrescenta no final do arquivo o que for escrito)
                using (StreamWriter sw = File.AppendText(targetPath))
                {

                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);

            }
        }
    }
}
