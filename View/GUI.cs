using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind.View
{
    public class GUI
    {
        public void AllValues(Dictionary<string,int> dictionary)
        {
            foreach(var par in dictionary)
            {
                Console.WriteLine($"Key: {par.Key}, Value: {par.Value}");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void Writefirst(Dictionary<string, int> dictionary)
        {
            var First = dictionary.First();
            Console.WriteLine($"Key: {First.Key}, Value: {First.Value}");
            Console.ReadKey();
            Console.Clear();
        }
        public void Remove(Dictionary<string, int> dictionary)
        {
            Console.WriteLine("Removed: Han");
            Console.ReadKey();Console.Clear();
        }
    }
}
