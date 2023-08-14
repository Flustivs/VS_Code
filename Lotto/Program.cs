using System;
using System.Threading;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            Random num = new Random();

            // Generate random numbers and put in array and print
            for (byte i = 0; i < 7; i++)
            {
                int randomNumber = num.Next(1, 37);
                numbers[i] = randomNumber;
            }
            Array.Sort(numbers);

            foreach (int pickedNumber in numbers)
            {
                Console.Write(pickedNumber + "  ");
                Thread.Sleep(2000);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            int lastNumber = num.Next(1, 37);
            numbers[6] = lastNumber;
            Console.Write(lastNumber);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
