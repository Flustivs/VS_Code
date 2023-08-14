using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace NIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            int sticks = 7;
            Random rnd = new Random();
            //Guidence to the game
            Console.WriteLine("┌──────────────────────────────┐\n" +
                  "│ Each player picks how many   │\n" +
                  "│ sticks they want between 1-3 │\n" +
                  "│ If you try and pick more     │\n" +
                  "│ you will get a \"message\"     │\n" +
                  "└──────────────────────────────┘");

            Console.WriteLine("Hello, Today we will play a \"friendly\" game, youll need to choose to go against a computer or your friend");

            Console.WriteLine("If you want to try your luck against the computer than press: 1\n" +
                "if you want to play against your friend press: 2");

            Thread.Sleep(1000);

            int opponent = int.Parse(Console.ReadLine());

            if (opponent == 1)
            {
                Console.WriteLine("haha so you choose me, you will go down");
            }
            if (opponent == 2)
            {
                Console.WriteLine("MU-HA-HA-HA, YOU KNOW YOUR INFERIOR...");
            }

            //the game for the player against player mode
            switch (opponent)
            {
                case 1:
                    Console.WriteLine("Theres this many " + sticks + " on the table right now");
                    int j = 2;
                    for (int i = 0; i < sticks;)
                    {
                        if (j % 2 == 0)
                        {
                            Console.WriteLine("Now its players turn, Good luck, you'll need it");
                            Console.WriteLine("How many sticks would you like to take: ");
                            sticks = sticks - int.Parse(Console.ReadLine());
                            if (int.Parse(Console.ReadLine()) > 3 || int.Parse(Console.ReadLine()) == 0)
                            {
                                Console.WriteLine("THATS NOT ACCEPTABLE YOU LITTLE DWEEB. NOW TRY AGAI-I-I-I-N-N-N");
                                break;
                            }
                            Console.WriteLine("There is now " + sticks + " left on the table");
                        }
                        if (j % 2 == 1)
                        {
                            Console.WriteLine("HA, now its my turn");
                            int pc = rnd.Next(1, 4);
                            sticks -= pc;
                            Console.WriteLine("There is now " + sticks + " left on the table");
                        }
                        if (sticks == 0)
                        {
                            if (j % 2 == 0)
                            {
                                Console.WriteLine("HA-HA-HA-HA JUST LIKE I PREDICTED, YOUR TRASH");
                            }
                            if (j % 2 == 1)
                            {
                                Console.WriteLine("wa-a-o-o-w you just hit a 1 in a million, cause normally no one defeats me, but now yoö'll never win in lotto");
                            }
                        }
                        j++;
                    }
                    break;
                case 2:
                    Console.WriteLine("Player 1 goes first");
                    for (int i = 0; i < sticks;)
                    {
                        int h = 2;
                        Console.WriteLine("How many sticks would you like to take: ");
                        sticks = sticks - int.Parse(Console.ReadLine());
                        if (int.Parse(Console.ReadLine()) > 3 || int.Parse(Console.ReadLine()) == 0)
                        {
                            Console.WriteLine("THATS NOT ACCEPTABLE YOU LITTLE DWEEB. NOW TRY AGAI-I-I-I-N-N-N");
                            break;
                        }
                        Console.WriteLine("There is now " + sticks + " left on the table");
                        if (h % 2 == 0)
                        {
                            Console.WriteLine("Now its player 2");
                        }
                        if (h % 2 == 1)
                        {
                            Console.WriteLine("Now its player 1");
                        }
                        if (sticks == 0 || sticks < 0)
                        {
                            if (h % 2 == 0)
                            {
                                Console.WriteLine("PLAYER 2 HAVE WO-O-O-O-N, AND PLAYER 1 IS TRASH");
                            }
                            if (h % 2 == 1)
                            {
                                Console.WriteLine("PLAYER 1 HAVE WO-O-O-O-N, AND PLAYER 2 IS TRASH");
                            }
                        }
                        h++;
                    }
                    break;
            }
        }
    }
}