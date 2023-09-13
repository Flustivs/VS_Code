using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private ConsoleKeyInfo _userHit;
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
            _userHit = Console.ReadKey();
            return _user;
        }
        public string DisplayHitCard(string hitcard, int hitcardresult, int result)
        {
            hitcardresult = hitcardresult + result;
            string DisplayCard = "\n" + hitcard + " now your Total is " + hitcardresult;
            Console.WriteLine(DisplayCard);
            Console.ReadKey();
            return DisplayCard;
        }
        public string DisplayBust(int hitcard, int result, string Pccard, int pcCombined)
        {
            result = result + hitcard;
            string Busted = "\n" + result + " Is over 21 that means you lost";
            string PcWon = "\nMy Second card was " + Pccard + " So my combined was " + pcCombined;
            Console.WriteLine(Busted);
            Console.WriteLine(PcWon);
            Console.ReadKey();
            return Busted;
        }
        public string DisplayStandedBust(int hitcard, int result, string Pccard, int pcCombined)
        {
            result = result + hitcard;
            string busted = "\n" + result + " The pc have a higher number than you";
            string PcWon = "\nMy Second card was " + Pccard + " So my combined was " + pcCombined;
            Console.WriteLine(busted);
            Console.WriteLine(PcWon);
            Console.ReadKey();
            return busted;
        }
        public string DisplayWon(int hitcard, int result)
        {
            result = result + hitcard;
            string Won = "\nYour total was " + result + " That means you won";
            Console.WriteLine(Won);
            Console.ReadKey();
            return Won;
        }
        public string Intro
        {
            get { return _intro; }
            set { _intro = value; }
        }
        public ConsoleKeyInfo HitCard
        {
            get { return _userHit; }
            set { _userHit = value; }
        }
    }
}
