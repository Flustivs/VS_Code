using Planeterne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.Controller Start = new Controller.Controller();
            Start.WritePlanet();
        }
    }
}
