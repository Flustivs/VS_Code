using OOP_Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test.GUI
{
    /// <summary>
    /// This class is meant for taking the users input on the different matters of the apartment
    /// </summary>
    internal class UserInput
    {
        private string _instructions;
        internal void Instructions()
        {
            _instructions = "In this program you will be able to make different rooms and then get the result of cost\n";
            Console.WriteLine(_instructions);
        }
        // Ask the user for how many rooms to determind what apartment it is he would like to make
        internal string HowManyRooms()
        {
            Console.WriteLine("Please write how many rooms this apartment should have\nThere can be up till 5 rooms per apartment");
            string rooms = Console.ReadLine();
            if (rooms == null && rooms != "1" && rooms != "2" && rooms != "3" && rooms != "4" && rooms != "5")
            {
                throw new NullReferenceException("Invalid input");
            }

            Console.Clear();
            return rooms;
        }
        // Ask the user for what kind of windows he would like
        internal string WhatWindows()
        {
            Console.WriteLine("Please write what kind of window this apartment should have\n these are the different types\n" +
                "1 = 1 fags window after measurements is 1879 kr and 30% more expensive with a mattered glass\n" +
                "2 = 2 fags window after measurements is 2798 kr can's be mattered\n" +
                "3 = 3 fags window after measurements is 4678 kr can't be mattered\n" +
                "4 = Entry door window is 6465 kr can't be mattered\n" +
                "5 = Back door window is 4879 kr can't be mattered\n" +
                "(If you want the 1 fags with mattered glass write 10");
            string windows = Console.ReadLine();
            if (windows == null && windows != "1" && windows != "2" && windows != "2" && windows != "4" && windows != "5" && windows != "10")
            {
                throw new NullReferenceException("Invalid input");
            }
            Console.Clear();
            return windows;
        }
        // Ask the user for input of squaremeters of the apartment
        internal string Floor()
        {
            Console.WriteLine("How big is the apartment in square meters");
            string floor = Console.ReadLine();
            if (floor == null)
            {
                throw new NullReferenceException("Invalid input");
            }
            Console.Clear();
            return floor;
        }
    }
}
