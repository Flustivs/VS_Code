using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.View
{
    /// <summary>
    /// Shows the user what the user is supposed to see and
    /// depending on what they have they can Hit, Stand or if they went over they  busted
    /// </summary>
    public class GUI
    {
        private string _intro;
        private string _pc;
        private string _user;
        // A little menu with instructions
        public string Instructions()
        {
            _intro = "This is a Blackjack App\nThe way to win in Blackjack is to be the one closest to 21 in combined cars\n" +
                "All picture cards for exemple jack is 10, if you get over 21 you lose\n" +
                "by pressing h you ask for another card, for pressing s you dont want any more cards\n";
            Console.WriteLine(_intro);
            return _intro;
        }
        // what the pcs first card is
        public string DisplayPc(string pccard1, string pccard2, int result)
        {
            _pc = pccard1 + "   " + "█" + "\n";
            Console.WriteLine(_pc);
            Console.WriteLine("Press any key ´to continue\n");
            Console.ReadKey();
            return _pc;
        }
        // Shows what the user have and what the value of the combined cards is
        public string DisplayUser(string usercard1, string usercard2, int result)
        {
            _user = "Your cards\n" + usercard1 + "   " + usercard2 + "\n" + "Combined: " + result;
            Console.WriteLine(_user);
            Console.WriteLine("\nPress H for another card, press S for no more cards");
            Console.ReadKey();
            return _user;
        }
        public string Intro
        {
            get { return _intro; }
            set { _intro = value; }
        }
    }
}
