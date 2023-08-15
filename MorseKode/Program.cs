using System.Numerics;

namespace MorseKode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In this program I WILL convert your input to morse");
            Console.WriteLine("I WILL NOT ACCEPT UPPERCASE LETTERS. (Thats too much, and im laz-z-z-z-y-y-y)");
            Console.SetCursorPosition(0, 5);

            while (true)
            {
                // variables
                var key = Console.ReadKey(false).Key;
                string space = "   ";

                switch (key)
                {
                    case ConsoleKey.A:
                        {
                            Console.WriteLine(space + "· —");

                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Console.WriteLine(space + "— · · ·");

                            break;
                        }
                    case ConsoleKey.C:
                        {
                            Console.WriteLine(space + "— · — ·");

                            break;
                        }
                    case ConsoleKey.D:
                        {
                            Console.WriteLine(space + "— · ·");

                            break;
                        }
                    case ConsoleKey.E:
                        {
                            Console.WriteLine(space + "·");

                            break;
                        }
                    case ConsoleKey.F:
                        {
                            Console.WriteLine(space + "· · — ·");

                            break;
                        }
                    case ConsoleKey.G:
                        {
                            Console.WriteLine(space + "— — ·");

                            break;
                        }
                    case ConsoleKey.H:
                        {
                            Console.WriteLine(space + "· · · ·");

                            break;
                        }
                    case ConsoleKey.I:
                        {
                            Console.WriteLine(space + "· ·");

                            break;
                        }
                    case ConsoleKey.J:
                        {
                            Console.WriteLine(space + "· — — —");

                            break;
                        }
                    case ConsoleKey.K:
                        {
                            Console.WriteLine(space + "— · —");

                            break;
                        }
                    case ConsoleKey.L:
                        {
                            Console.WriteLine(space + "· — · ·");

                            break;
                        }
                    case ConsoleKey.N:
                        {
                            Console.WriteLine(space + "— ·");

                            break;
                        }
                    case ConsoleKey.M:
                        {
                            Console.WriteLine(space + "— — ");

                            break;
                        }
                    case ConsoleKey.O:
                        {
                            Console.WriteLine(space + "— — —");

                            break;
                        }
                    case ConsoleKey.P:
                        {
                            Console.WriteLine(space + "· — — ·");

                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            Console.WriteLine(space + "— — · — ");

                            break;
                        }
                    case ConsoleKey.R:
                        {
                            Console.WriteLine(space + "· — ·");

                            break;
                        }
                    case ConsoleKey.S:
                        {
                            Console.WriteLine(space + "· · ·");

                            break;
                        }
                    case ConsoleKey.T:
                        {
                            Console.WriteLine(space + "—");

                            break;
                        }
                    case ConsoleKey.U:
                        {
                            Console.WriteLine(space + "· · —");

                            break;
                        }
                    case ConsoleKey.V:
                        {
                            Console.WriteLine(space + "· · · — ");

                            break;
                        }
                    case ConsoleKey.W:
                        {
                            Console.WriteLine(space + "· — —");

                            break;
                        }
                    case ConsoleKey.X:
                        {
                            Console.WriteLine(space + "— · · —");

                            break;
                        }
                    case ConsoleKey.Y:
                        {
                            Console.WriteLine(space + "— · — —");

                            break;
                        }
                    case ConsoleKey.Z:
                        {
                            Console.WriteLine(space + "— — · ·");

                            break;
                        }
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine(space + "· — — — —");

                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Console.WriteLine(space + "· · — — —");

                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            Console.WriteLine(space + "· · · — —");

                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            Console.WriteLine(space + "· · · · —");

                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            Console.WriteLine(space + "· · · · ·");

                            break;
                        }
                    case ConsoleKey.D6:
                        {
                            Console.WriteLine(space + "— · · · ·");

                            break;
                        }
                    case ConsoleKey.D7:
                        {
                            Console.WriteLine(space + "— — · · ·");

                            break;
                        }
                    case ConsoleKey.D8:
                        {
                            Console.WriteLine(space + "— — — · ·");

                            break;
                        }
                    case ConsoleKey.D9:
                        {
                            Console.WriteLine(space + "— — — — ·");

                            break;
                        }
                    case ConsoleKey.D0:
                        {
                            Console.WriteLine(space + "— — — — —");

                            break;
                        }
                    case ConsoleKey.OemPeriod:
                        {
                            Console.WriteLine(space + "· — · — · —");

                            break;
                        }
                    case ConsoleKey.OemComma:
                        {
                            Console.WriteLine(space + "— — · · — —");

                            break;
                        }
                }
            }
        }
    }
}