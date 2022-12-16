using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nimi");
            string name = Console.ReadLine();

            Console.WriteLine("Tere " + name + ", nüüd hakkab värvimuusika");

            if (name != "")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Tere " + name);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Nimi ei ole sisestatud. Head aega!");
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
            Console.ReadKey();
        }
    }
}