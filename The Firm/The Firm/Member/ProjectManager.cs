using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.The_Firm
{
    public class ProjectManager : Manager
    {
        protected string Gmail;

        public void ShowProjectManager()
        {
            ShowEmployee();
            ShowManager();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nThis is ProjectManager class\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(ToString());
            //if ( firstName == null)
            //{
            //    Console.WriteLine("no firstname");
            //}
            //if (lastName == null)
            //{
            //    Console.WriteLine("no lastname");
            //}
            //if (CPR_Number == 0)
            //{
            //    Console.WriteLine("No CPR-Number");
            //}
            //if (phoneNumber == 0)
            //{
            //    Console.WriteLine("No phonenumber");
            //}
            //if (Gmail == null)
            //{
            //    Console.WriteLine("No Gmail");
            //}
            Console.ReadKey();
        }
        public override string ToString()
        {
            return $"Firstname {firstName} Lastname {lastName} CPR-Number {CPR_Number} phonenumber {phoneNumber} Gmail {Gmail}";
        }

    }
}
