using System;
using System.IO;

namespace CSharpFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "/Users/chelsea/Documents/MissCoding/example.txt";
            Console.WriteLine("Writing to file");
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine("Hi everyone!");
                sw.WriteLine("This file has multiple lines");
            }
            Console.WriteLine("Wrote to file");

            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    Console.WriteLine("Reading from file");
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }
                    Console.WriteLine("Read from file");
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
