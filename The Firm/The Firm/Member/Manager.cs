using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.The_Firm
{
    public class Manager : Employee
    {
        protected int phoneNumber;

        protected void ShowManager()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nThis is Manager class\n");
            Console.BackgroundColor = ConsoleColor.Black;
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
            //if (phoneNumber == 0)
            //{
            //    Console.WriteLine("No phonenumber");
            //}
            Console.ReadKey();
        }
    }
}
