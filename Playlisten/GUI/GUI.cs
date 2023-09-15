using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.GUI
{
    public class GUI
    {
        public void ClearScreen()
        {
            Console.Clear();
        }
        public string WrongInput()
        {
            string wrong = "Not valid input";
            Console.WriteLine(wrong);
            Console.ReadKey();
            return wrong;
        }
        public string StartMenu()
        {
            string start = "==================================" +
                              "\n\n" +
                              "  Choose your playlist or create\n" +
                              "       Press 6 to end\n\n" +
                              "==================================" +
                              "\n1. Predefined playlist\n2. Country\n3. Heavy\n4. Firserne\n5. Halvfemserne";
            Console.WriteLine(start);
            string ouput = Console.ReadLine();
            return ouput;
        }
        public string AskUserSong(string playlist)
        {
            string ask = "What song would you like to add to " + playlist;
            Console.WriteLine(ask);
            string output = Console.ReadLine();
            return output;
        }
        public void Printout(LinkedList<string> output)
        {
            foreach (string item in output)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
