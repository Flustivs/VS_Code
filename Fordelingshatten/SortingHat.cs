using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordelingshatten
{
    public class SortingHat
    {
        enum Colleges { Griffindor, Hufflepuff, Ravenclaw, Slytherin };

        public int Random()
        {
            Random random = new Random();
            int num = random.Next(0,4);
            return num;

        }
        public void College()
        {
            while(true)
            {
                int x = Random();
                switch (x)
                {
                    case 0:
                        Console.WriteLine(Colleges.Griffindor);
                        break;
                    case 1:
                        Console.WriteLine(Colleges.Hufflepuff);
                        break;
                    case 2:
                        Console.WriteLine(Colleges.Ravenclaw);
                        break;
                    case 3:
                        Console.WriteLine(Colleges.Slytherin);
                        break;
                    default:
                        Console.WriteLine("Your not worht it");
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
