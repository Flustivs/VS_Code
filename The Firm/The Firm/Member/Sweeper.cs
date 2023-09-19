using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.The_Firm
{
    public class Sweeper : Employee
    {
        public void ShowSweeper()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nThis is Sweeper class\n");
            Console.BackgroundColor= ConsoleColor.Black;
            Console.WriteLine(ToString());
            //if (firstName == null)
            //{
            //    Console.WriteLine("No firstname");
            //}
            //if (lastName == null)
            //{
            //    Console.WriteLine("No lastname");
            //}
            //if (CPR_Number == 0)
            //{
            //    Console.WriteLine("No CPR-Number");
            //}
            Console.ReadKey();

        }
        public override string ToString()
        {
            return $"Firstname {firstName} Lastname {lastName} CPR-Number {CPR_Number}";
        }

    }
}
