﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.Controller controller = new Controller.Controller();
            controller.Start();
        }
    }
}
