namespace MorseKode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In this program I WILL convert your input to morse");
            Console.WriteLine("I WILL NOT ACCEPT UPPERCASE LETTERS. (Thats too much, and im laz-z-z-z-y-y-y)");

            while (true)
            {
                var key = Console.ReadKey(false).Key;



                switch (key)
                {
                    case ConsoleKey.A:

                        break;
                }
            }
        }
    }
}