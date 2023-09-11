using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_Nye
{
    /// <summary>
    /// Takes the logic from RemoteCar and depending on the result we change what the user sees
    /// </summary>
    public class CarGUI
    {
        // Variables
        private string _infomation;
        private short _totalDistance;
        private byte _powerRemain;
        public RemoteCar car1 = new RemoteCar();



        // public so the controller can use it
        public string Infomation()
        {
            _infomation = Display();
            return _infomation;
        }

        // Tells the user how to use the app
        string Display()
        {

            Console.WriteLine("In this app you type how many times you want the car to be driven\n" +
                "and for each time its driven it drives 20 meters and uses 1 % battery\n" +
                "If you press R you recharge your car\n\n");
            _powerRemain = car1.PowerCapacity();
            _totalDistance = car1.TotalDistance();
            if (_powerRemain == 100)
            {
                _infomation = "\n┌───────┬─────────┐\n" +
                                "│ Power │Distance │\n" +
                                "│ " + _powerRemain + "%  │ " + _totalDistance + "       │\n" +
                                "└───────┴─────────┘";
            }
            if (10 <= _powerRemain && _powerRemain <= 99)
            {
                _infomation = "┌───────┬──────────┐\n" +
                              "│ Power │ Distance │\n" +
                              "│ " + _powerRemain + "%   │ " + _totalDistance + "      │\n" +
                              "└───────┴──────────┘";
            }
            if (10 < _powerRemain && _powerRemain <= 0)
            {
                _infomation = "┌───────┬─────────┐\n" +
                              "│ Power │Distance │\n" +
                              "│ " + _powerRemain + "%    │ " + _totalDistance + "    │\n" +
                              "└───────┴─────────┘";
            }
            if (_powerRemain == 0)
            {
                _infomation = "┌───────┬────────────┐\n" +
                              "│ Power │Distance    │\n" +
                              "│ " + _powerRemain + "%    │ " + _totalDistance + "       │\n" +
                              "├───────┴────────────┤\n" +
                              "│ You need to charge │\n" +
                              "└────────────────────┘";
            }
            return _infomation;
        }

        public string PressedR()
        {
            _infomation = "┌────────────────────┐\n" +
                          "│   Your charging    │\n" +
                          "│This takes 5 seconds│\n" +
                          "└────────────────────┘\n";
            return _infomation;
        }
        public string charged()
        {
            _infomation = "┌────────────────────┐\n" +
                          "│    Your charged    │\n" +
                          "└────────────────────┘\n";
            return _infomation;
        }


        public string Info
        {
            get { return _infomation; }
            set { _infomation = value; }
        }
    }
}
