using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    /// <summary>
    /// Shows how i have used the struct to my 1d array with all my cards
    /// </summary>
    public class Struct
    {
        public struct GiveCard
        {
            public string[] cards;
            public string[] Card()
            {
                cards = new string[]{"Ace Heart", "Ace Diamond", "Ace Clubs", "Ace Spades",
                "2 Heart", "2 Diamond", "2 Clubs", "2 Spades",
                "3 Heart", "3 Diamond", "3 Clubs", "3 Spades",
                "4 Heart", "4 Diamond", "4 Clubs", "4 Spades",
                "5 Heart", "5 Diamond", "5 Clubs", "5 Spades",
                "6 Heart", "6 Diamond", "6 Clubs", "6 Spades",
                "7 Heart", "7 Diamond", "7 Clubs", "7 Spades",
                "8 Heart", "8 Diamond", "8 Clubs", "8 Spades",
                "9 Heart", "9 Diamond", "9 Clubs", "9 Spades",
                "10 Heart", "10 Diamond", "10 Clubs", "10 Spades",
                "Jack Heart", "Jack Diamond", "Jack Clubs", "jack Spades",
                "Queen Heart", "Queen Diamond", "Queen Clubs", "Queen Spades",
                "King Heart", "King Diamond", "King Clubs", "King Spades"};


                return cards;
            }
        }
    }
}
