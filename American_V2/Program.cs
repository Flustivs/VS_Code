namespace American_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] blue = new char[23,11];
            char[,] flag = new char[38,26];


            bool exit = true;


            int i = 2;

            while (exit)
            {
                if (i % 2 == 0)
                {
                    for (int row = 0; row < 2; row++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        for (int col = 0; col < flag.GetLength(0); col++)
                        {
                            Console.Write(flag[col, row] = ' ');
                        }
                        Console.WriteLine();
                    }
                    i++;
                    if (i == 15)
                    {
                        exit = false;
                        Console.BackgroundColor= ConsoleColor.Black;
                    }
                }
                if (i % 2 == 1)
                {
                    for (int row = 0; row < 2; row++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        for (int col = 0; col < flag.GetLength(0); col++)
                        {
                            Console.Write(flag[col, row] = ' ');
                        }
                        Console.WriteLine();
                    }
                    i++;
                }
            }
            Console.SetCursorPosition(0, 0);
            for (int row = 0; row < blue.GetLength(1); row++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                for (int col = 0; col < blue.GetLength(1); col++)
                {
                    Console.Write(blue[col, row] = ' ');
                }
                Console.WriteLine() ;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            


        }
    }
}