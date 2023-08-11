namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Enter in in this format 1.75 M)\n" +
                "Please enter your height: ");

            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("(Enter in KG)" +
                "Please enter your weight: ");

            float weight = float.Parse(Console.ReadLine());

            float BMI = weight / (height * height) * 100;

            if (BMI > 16 && BMI < 18.5)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("                              ");
                Console.WriteLine("Your BMI is-s-s-s " + BMI + "           ");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            if (BMI > 18.5 && BMI < 24)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                              ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your BMI is-s-s-s " + BMI + "           ");
                Console.BackgroundColor = ConsoleColor.Black;

            }

            if (BMI > 24 && BMI < 30)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                              ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your BMI is-s-s-s " + BMI + "           ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (BMI > 30 && BMI < 35)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                              ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your BMI is-s-s-s " + BMI + "           ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (BMI > 35 && BMI < 40)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("                              ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your BMI is-s-s-s " + BMI + "           ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (BMI > 40)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("                              ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your BMI is-s-s-s " + BMI + "           ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.ReadKey();
        }
    }
}