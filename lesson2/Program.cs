using System;

namespace lesson2
{
    class Program
    {
    static void Main(string[] args)
        {

            Console.SetCursorPosition(30, 5);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Hello!,What's your name?");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"hello,{name}!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"" +
                $"{DateTime.Now} Now,{name}!");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}

