using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите ваш любимый цвет на английском?");
            
                var color = Console.ReadLine();

            if (color == "Red")       
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine($"Your color is Red");
            }
            else if (color == "Green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine($"Your color is Green");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine($"Your color is Cyan");

                Console.ReadKey();
            }

            //switch (Console.ReadLine())
            //{
            //    case "red":
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.ForegroundColor = ConsoleColor.Black;
            //
            //        Console.WriteLine("Your color is red!");
            //        break;
            //
            //    case "green":
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.ForegroundColor = ConsoleColor.Black;
            //
            //        Console.WriteLine("Your color is green!");
            //        break;
            //    case "cyan":
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //        Console.ForegroundColor = ConsoleColor.Black;
            //
            //        Console.WriteLine("Your color is cyan!");
            //        break;
            //    default:
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.ForegroundColor = ConsoleColor.Red;
            //
            //        Console.WriteLine("Your color is yellow!");
            //        break;
            //}

        }
    }
}
