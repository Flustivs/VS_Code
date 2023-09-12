using BlackJack.Controller;
using BlackJack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlledGame game = new ControlledGame();
            game.StartGame();
        }
    }
}
