using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elon_s_Nye
{
    /// <summary>
    /// This class uses the gui to display the Display
    /// </summary>
    public class Controller
    {
        private string _display;
        private byte _charging;
        private ConsoleKeyInfo _recharge;
        CarGUI GUI = new CarGUI();

        // To loop around untill theres no power, and you can recharge with r
        public void Infomation()
        {
            RemoteCar car1 = new RemoteCar();
            for (int i = 0; i < car1.PowerAmount;)
            {
                if (_recharge.Key == ConsoleKey.R)
                {
                    CarGUI R = new CarGUI();
                    R.PressedR();
                    Console.WriteLine("\n"+ R.PressedR());
                    Thread.Sleep(5000);
                    Console.WriteLine("\n"+R.charged());
                    R.charged();
                    Thread.Sleep(2500);
                    Console.WriteLine("press any key to continue");
                    /*car1._totalDistance = 0; 
                    car1._powerAmount = 100;
                    Couldnt get it to reset*/
                }
                else
                {
                    Console.Clear();
                    _display = car();

                    Console.WriteLine(_display);
                }
                _recharge = Console.ReadKey();
            }
        }
        // To "activate" the GUI
        string car()
        {
            _display = GUI.Infomation();
            return _display;
        }

        public string Display
        {
            get { return _display; }
            set { _display = value; }
        }
        public byte Charge
        {
            get { return _charging; }
            set { _charging = value; }
        }
    }
}
