using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = "";
            String[] wordMass;
            Console.WriteLine("Enter the path");
            string path_name = Console.ReadLine();
            StreamReader sr = new StreamReader(path_name);

            if (path_name.Contains(".txt"))
            {
                while (sr.EndOfStream != true)
                {
                    word += sr.ReadLine();
                }
                wordMass = word.Split(" ");
                Console.WriteLine("Количество слов:");
                Console.WriteLine(wordMass.Length);
            }
            else
            {
                Console.WriteLine("Неверный тип файла");
            }
            sr.Close();
            Console.ReadLine();

        }
    }
}

