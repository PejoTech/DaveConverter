using System;
using DaveConverter.Common;

namespace DaveConverter.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pfad zum .itf angeben:");

            var fileText = ReadFile.LoadStringFromFile(Console.ReadLine());

            Console.WriteLine("TABL Abschnitte einzeln augeben? (j/n)");

            switch (Console.ReadLine())
            {
                case "j":
                {
                    ReadFile.WriteTextFromFileByLine(fileText);
                    break;
                }
                default:
                {
                    Console.WriteLine(fileText);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
