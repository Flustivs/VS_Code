using Køen.model;
using Køen.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen.Controller
{
    /// <summary>
    /// Here i check for what the user wants to do if its either 
    /// </summary>
    public class Controller
    {
        Logik logik = new Logik();
        GUI gui = new GUI();
        private bool Yes = true;
        public void StartGUI()
        {
            while (Yes)
            {
                string menu = gui.Menu();
                userOutput(gui.UserTypo());
            }
        }
        public void userOutput(ConsoleKeyInfo key)
        {
            Queue<string> queue = logik.Queue;
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    string useradd = gui.Add();
                    queue.Enqueue(useradd);
                    gui.ClearScreen();
                    break;
                case ConsoleKey.D2:
                    queue.Dequeue();
                    gui.ClearScreen();
                    break;
                case ConsoleKey.D3:
                    gui.PrintQueueCount(queue.Count);
                    gui.ClearScreen();
                    break;
                /*case ConsoleKey.D4:
                    string min = queue.Min();
                    string max = queue.Max();
                    gui.MinMaxQueue(min, max);
                    gui.ClearScreen();
                    break;*/
                case ConsoleKey.D5:
                    gui.FindItem(queue);
                    gui.ClearScreen();
                    break;
                case ConsoleKey.D6:
                    gui.PrintQueue(queue);
                    break;
                case ConsoleKey.D7:
                    Yes = false;
                    break;
            }
        }
    }
}
