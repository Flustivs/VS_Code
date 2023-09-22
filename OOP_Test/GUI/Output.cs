using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test.GUI
{
    /// <summary>
    /// This class was meant for all the different apartments output
    /// </summary>
    internal class Output
    {
        // The output of a apartment with 1 room
        internal void OneRoom(short window, int kitchen, short floor)
        {
            floor *= 179;
            int result = window + kitchen + floor;
            if (window == 6465)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Frontdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            if (window == 4879)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Backdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            else
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                    $"the windows cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            Console.ReadKey();
        }
        internal void TwoRoom(short window, double kitchen, short floor)
        {
            floor *= 179;
            double result = window + kitchen + floor;
            if (window == 6465)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Frontdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            if (window == 4879)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Backdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            else
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                    $"the windows cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            Console.ReadKey();
        }
        internal void ThreeRoom(short window, double kitchen, short floor)
        {
            floor *= 179;
            double result = window + kitchen + floor;
            if (window == 6465)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Frontdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            if (window == 4879)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Backdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            else
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                    $"the windows cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            Console.ReadKey();
        }
        internal void FourRoom(short window, double kitchen, short floor)
        {
            floor *= 179;
            double result = window + kitchen + floor;
            if (window == 6465)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Frontdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            if (window == 4879)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Backdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            else
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                    $"the windows cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            Console.ReadKey();
        }
        internal void FiveRoom(short window, double kitchen, short floor)
        {
            floor *= 179;
            double result = window + kitchen + floor;
            if (window == 6465)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Frontdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            if (window == 4879)
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                $"the Backdoor window cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            else
            {
                Console.WriteLine($"The total cost of this is {result} kr\n" +
                    $"the windows cost was {window} kr, the kitchen cost was {kitchen} kr and the floor cost was {floor} kr");
            }
            Console.ReadKey();
        }
    }
}
