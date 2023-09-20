using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.Model.Animals
{
    internal class Chicken : Animal
    {
        internal Chicken(bool Mammal, bool Gender, bool Hair, byte Legs)
        {
            mammal = Mammal;
            gender = Gender;
            hair = Hair;
            legs = Legs;
        }
        internal void GetChicken(bool Mammal, bool Gender, bool Hair, byte Legs)
        {
            if (Mammal)
            {
                Console.WriteLine("Im a mammal");
            }
            else
            {
                Console.WriteLine("Im not a mammal");
            }
            if (Gender)
            {
                Console.WriteLine("Im a male");
            }
            else
            {
                Console.WriteLine("Im a female");
            }
            if (hair)
            {
                Console.WriteLine("I have long hair");
            }
            else
            {
                Console.WriteLine("I have short hair");
            }
            if (Legs > 0)
            {
                Console.WriteLine($"I have {Legs} legs");
            }
            else
            {
                Console.WriteLine("I have 0 legs");
            }
        }
        public override void Print()
        {

        }

    }
}
