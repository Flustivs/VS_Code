using System;

namespace ConsoleOutputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = 15;
            int y = Console.CursorTop;
            int x = Console.CursorLeft;

            for (int i = 0; i < lines; i++)
            {
                string output = "*";
                Console.SetCursorPosition(x + (i / 2), y + (i + 1));
                Console.Write(output);
                i++;
            }

            Console.ReadKey();
        }
    }
}
