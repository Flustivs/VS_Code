using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 15;
            int height = 8;

            for (int i = 0; i < height; i++)
            {
                bool isEvenLine = i % 2 == 0;

                if (isEvenLine)
                {
                    //goes in a loop that makes spaces
                    for (int j = 0; j < width - i; j++)
                    {
                        Console.Write(" ");
                    }
                    //loops between red and green stars
                    for (int k = 0; k < (2 * i + 1); k++)
                    {
                        if (k % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.Write("*");
                    }
                }
                else
                {
                    //makes the stars only green
                    for (int j = 0; j < width - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < (2 * i + 1); k++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
