using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_Nye
{
    /// <summary>
    /// Activates the Controller class
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Infomation();
            Console.ReadKey();
        }

    }
}
