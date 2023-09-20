using Opdrætterstation.Model.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation.Model
{
    internal class Stattion : Animal
    {
        internal void Animals()
        {
            Animal bunny = new Bunny(true, true, true, 0);
            Animal dog = new Dog(true, true, true, 0);
            Animal chicken = new Chicken(true, true, true, 0);

            ((Bunny)bunny).GetBunny(true, true, false, 3);
            ((Dog)dog).GetDog(true, false, true, 2);
            ((Chicken)chicken).GetChicken(false, false, true, 9);
            ((Bunny)bunny).GetBunny(false, true, false, 1);
            ((Dog)dog).GetDog(true, false, false, 7);
            ((Chicken)chicken).GetChicken(false, true, true, 5);

            Console.ReadKey();
        }
        public override void Print()
        {

        }
    }
}
