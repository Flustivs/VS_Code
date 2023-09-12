using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robboterne.Model
{
    public class QT8339
    {
        public string _microchip { set; get; };
        public bool _WIFI = true;
        public QT8339()
        {
            _microchip = "You can clean the floor\n";
        }
        public QT8339(string _microchip) : this()
        {
            _microchip += "You can also change tires\n";
        }
        public QT8339(string Microchip, bool _WIFI) : this(Microchip)
        {
            if (_WIFI)
            {
                _microchip += "You dont have WIFI\n";
            }
        }

    }
}
