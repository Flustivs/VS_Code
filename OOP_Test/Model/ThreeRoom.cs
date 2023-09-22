using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test.Model
{
    /// <summary>
    /// This class is for the 3 room apartment and has its inheritance from Room
    /// </summary>
    internal class ThreeRoom : Room
    {
        internal ThreeRoom(string room, short window, int kitchen) : base(room, window, kitchen)
        {

        }
    }
}
