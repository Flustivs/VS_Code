using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test.Model
{
    /// <summary>
    /// This class is for the standard room cost (Not the fully intended setup)
    /// </summary>
    internal abstract class Room
    {
        protected int kitchen = 37899;
        protected short window;
        //protected int floor;
        protected string room;

        /*internal Room(int kitchen, short window, int floor)
        {
            this.kitchen = kitchen;
            this.window = window;
            this.floor = floor;
        }*/

        protected Room(string Room, short window, int kitchen)
        {
            this.room = Room;
            //this.floor = floor;
            this.kitchen = kitchen;
            this.window = window;
        }
    }
}
