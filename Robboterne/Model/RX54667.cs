using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robboterne.Model
{
    public class RX54667
    {
        public string _microchip { set; get; }
        public float _soabDisposer { set; get; }
        public bool _WIFI = false;

        

        public RX54667()
        {
            _microchip = "You can clean the floor\n";
        }
        public RX54667(string _microchip) : this()
        {
            _microchip += "You can also clean the windows\n";
        }
        public RX54667(string _microchip, bool WIFI) : this(_microchip)
        {
            if (WIFI == false)
            {
                _microchip += "You dont have WIFI\n";
            }
        }
        public RX54667(string _microchip,bool WIFI, float SoabDisposer) : this(_microchip, WIFI)
        {
            if (SoabDisposer == 2.3f)
            {
                _microchip += "You have a SoabDisposer with " + SoabDisposer + " Liters soab\n";
            }
        }
    }
}
