using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_Nye
{
    public class RemoteCar
    {
        // Variables
        public short _totalDistance = 0;
        private short _distance = 0;
        //private string[] _color = {"Red", "Yellow", "Green"};
        private byte _powerCapacity = 100;
        public byte _powerAmount = 100;
        private short driving;
        private byte _color = 1;

        // sees how many times the user wants to drive (Thats how i understood the problem)
        short Driving()
        {
            try
            {
                Console.WriteLine("\nHow many time would you like to drive");
                _distance = short.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.Write("Error :" + e);
            }
            /*try
            {
                _distance = float.Parse(Console.ReadLine());
                _distance = _distance / 20;
                Math.Round(_distance, 1);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }*/
            return _distance;
        }

        // Figures out how much power you have used
        public byte PowerCapacity()
        {
            driving = Driving();
            if (_powerAmount == 100)
            {
                _powerAmount = (byte)(_powerCapacity - driving);
            }
            else
            {
                _powerAmount = (byte)(_powerAmount - driving);
            }

            return _powerAmount;
        }

        // Figures out how many meters you have driven
        public short TotalDistance()
        {
            if (_totalDistance == 0)
            {
                _distance = (short)(driving * 20);
                _totalDistance = _distance;
            }
            else
            {
                _distance = (short)(driving * 20);
                _totalDistance = (short)(_totalDistance + _distance);
            }
            return _totalDistance;
        }

        public byte CarColor()
        {
            string color;
            color = Console.ReadLine();
            if (color == "Red" || color == "red")
            {
                _color = 1;
            }
            else if (color == "Yellow" || color == "yellow")
            {
                _color = 2;
            }
            else if(color == "Green" || color == "green")
            {
                _color = 3;
            }

            return _color;
        }

        public short Drove
        {
            get { return _totalDistance; }
            set { _totalDistance = value; }
        }

        public byte PowerAmount
        {
            get { return _powerAmount; }
            set { _powerAmount = value; }
        }
    }
}
