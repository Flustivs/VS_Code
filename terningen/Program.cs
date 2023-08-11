namespace terningen
{
    internal class Program
    {
        static void ClearArea(int left, int top, int width, int height)
        {
            Console.SetCursorPosition(left, top);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        static void Main(string[] args)
        {
            Random ran = new Random();
            bool end = true;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("                                                  \n" +
                "                                                  \n" +
                "                                                  \n" +
                "                                                  \n" +
                "                                                  \n" +
                "                                                  \n" +
                "                                                  \n" +
                "                                                  \n" +
                "                                                  \n");

            while (end)
            {
                Console.SetCursorPosition(0, 0);
                int dice = ran.Next(1, 7);
                // Check for the dices value

                if (dice == 1)
                {
                    Console.WriteLine("You ro-o-o-o-lled a ONE ");
                }
                else if (dice == 2)
                {
                    Console.WriteLine("You ro-o-o-o-lled a TWO ");
                }
                else if(dice == 3)
                {
                    Console.WriteLine("You ro-o-o-o-lled a THREE ");
                }
                else if (dice == 4)
                {
                    Console.WriteLine("You ro-o-o-o-lled a FOUR");
                }
                else if (dice == 5)
                {
                    Console.WriteLine("You ro-o-o-o-lled a FIVE");
                }
                else if (dice == 6)
                {
                    Console.WriteLine("You ro-o-o-o-lled a SIX");
                }
                else
                {
                    Console.WriteLine("You Somehow ro-o-o-o-lled nothing");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(0, 20);
                end = false;
            }
        }
    }
}