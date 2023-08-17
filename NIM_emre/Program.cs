namespace NIM_emre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            control();
        }
        #region Control
        static void control()
        {
            GUI();
            int stick = sticks();
        }
        #endregion

        #region Model
        static int sticks()
        {
            // You dont tell me to make an array or int with the amount of sticks but i will make an int with the sticks just in case
            int stick = 7;
            // a variable to to see who lost
            bool end = true;
            bool start = true;
            while (start)
            {
                int input = int.Parse(Console.ReadLine());
                if (stick == 0)
                {
                    // you dont say to write who won in the console, but i will do it anyways
                    if (end = false)
                    {
                        Console.WriteLine("Player Won");
                    }
                    else
                    {
                        Console.WriteLine("AI Won");
                    }

                }
                // The amount of sticks would allways be greater than 0 
                stick = stick - input;
                while (stick > 0)
                {
                    if (stick > 0)
                    {
                        Random rnd = new Random();
                        int pc = rnd.Next(1, 4);
                        stick = stick - pc;
                    }
                }
                start = false;
            }
            return stick;
        }
        #endregion

        #region View
        static void GUI()
        {
            Console.WriteLine("How many sticks ya want ");
            return;
        }
        #endregion
    }
}