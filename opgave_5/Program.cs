namespace opgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cel = 0;

            Console.WriteLine("Please enter your temperature in celsius: ");
            cel = int.Parse(Console.ReadLine());

            if (cel != 0 )
            {
                Console.WriteLine("Would you like to convert it to fahrenheit press y: ");
                var far = Console.ReadLine();
                
                if (far == "y")
                {
                    float fahren = (float)((cel * 1.8) + 32);
                    Console.Write("This is your celsius in fahrenheit: " +  fahren);
                    Console.Write("\n\nOkay, Have a Great Day\n\n\n");
                }
                else 
                {
                    Console.Write("Would you like to convert it to reaumur press y: ");
                    var rea = Console.ReadLine();
                    if (rea == "y")
                    {
                        var reaum = cel * 0.8;
                        Console.Write("This is your clesius in Reaumur: " + reaum);
                    }
                    else
                    {
                        Console.Write("\n\nOkay, Have a Great Day\n\n\n");
                    }
                }
            }
            else
            {
                Console.Write("\n\nOkay, Have a Great Day\n\n\n");
            }

        }
    }
}