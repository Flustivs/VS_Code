using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.The_Firm
{
    public class Employee
    {
        protected string firstName;
        protected string lastName;
        protected int CPR_Number;

        protected void ShowEmployee()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("This is Employee class\n");
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
            Console.ReadKey();

        }
    }
}
