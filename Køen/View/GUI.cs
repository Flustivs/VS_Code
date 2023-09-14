using Køen.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Køen.View
{
    /// <summary>
    /// Here i make the fantastico GUI that the user sees.
    /// </summary>
    public class GUI
    {
        Logik logik = new Logik();
        public string Menu()
        {
            string UserMenu = "========================================\n" +
                "\n" +
                              "        H1 Queue Operations Menu\n" +
                              "\n========================================\n" +
                "\nPress the reprensentive number for what you want to do\n" +
                "1. Add items\n2. Delete items\n3. Show number of items\n4. Show min and max items\n5. Find an item\n6. Print all items\n7. Exit";
            Console.WriteLine(UserMenu);
            return UserMenu;
        }
        public ConsoleKeyInfo UserTypo()
        {
            ConsoleKeyInfo userkey = Console.ReadKey();
            return userkey;
        }
        public void ClearScreen()
        {
            Console.Clear();
        }
        public void PrintQueue(Queue<string> queue)
        {
            foreach (string item in queue)
            {
                Console.WriteLine("\n" + item);
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void PrintQueueCount(int queue)
        {
            Console.WriteLine("\n" + queue);
            Console.ReadKey();
            Console.Clear();
        }
        public string Add()
        {
            while (true)
            {
                Console.WriteLine("What playstation would you like, we have\n1. Playstation 1\n2. Playstation 2\n3. Playstation 3\n4. Playstation 4\n5. Playstation 5");
                string Userinput = Console.ReadLine();
                if (Userinput == "1" || Userinput == "2" || Userinput == "3" || Userinput == "4" || Userinput == "5")
                {
                    switch(Userinput)
                    {
                        case "1":
                            return "Playstation 1";
                        case "2":
                            return "Playstation 2";
                        case "3":
                            return "Playstation 3";
                        case "4":
                            return "Playstation 4";
                        case "5":
                            return "Playstation 5";
                    }
                }
                else
                {
                    Console.WriteLine("Your wrong go back!!!");
                }
            }
        }
        public void FindItem(Queue<string> queue)
        {
            Console.WriteLine("What item would you like to find in your queue");
            string find = Console.ReadLine();
            if (queue.Contains(find))
            {
                byte i = 0;
                Console.WriteLine();
                foreach(string item in queue)
                {
                    if (item.Contains(find))
                    {
                        i++;
                    }
                }
                if (i > 0)
                {
                    Console.WriteLine("You have " +  i + "  of " + find);
                }
            }
            else
            {
                Console.WriteLine("\n" + find + " This shit dosnt even exist");
            }
            Console.ReadKey();
        }
        /* I didnt understand and i aksed camilla she said no need.
         * public void MinMaxQueue(string min, string max)
        {
            Console.WriteLine("\nYour minimum is: " + min + "\nYour maximum is: " + max);
            Console.ReadKey();
        }*/
    }
}
