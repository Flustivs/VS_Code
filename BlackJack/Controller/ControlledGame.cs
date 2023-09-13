using BlackJack.Model;
using BlackJack.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackJack.Controller
{
    /// <summary>
    /// In this class i take my data and take my view and have them work together to display the correct output
    /// </summary>
    public class ControlledGame
    {
        private GameData Begin = new GameData();
        private GUI Intro = new GUI();

        // Makes the Console with the values form the Model going through the Controller to the View
        public void StartGame()
        {
            Intro.Instructions();
            Intro.DisplayPc(GetPcOutput1(), GetPcOutput2(), PcResult());
            Intro.DisplayUser(PlayerOutput1(), PlayerOutput2(), PlayerCard());
            ConsoleKeyInfo H = Intro.HitCard;
            // Check if user input equals H and then checks for who won
            if (H.Key == ConsoleKey.H)
            {
                HitCard();
                Intro.DisplayHitCard(Begin.Hit_Card, Begin.HitCardResult, PlayerCard());
                int CheckIfBust = Begin.HitCardResult + PlayerCard();
                if (CheckIfBust > 21)
                {
                    Intro.DisplayBust(Begin.HitCardResult, PlayerCard(), GetPcOutput2(), PcResult());
                }
                else
                {
                    if (CheckIfBust <= 21 && CheckIfBust > PcResult())
                    {
                        Intro.DisplayWon(Begin.HitCardResult, PlayerCard());
                    }
                    if (CheckIfBust < 21 && CheckIfBust < PcResult())
                    {
                        Intro.DisplayBust(Begin.HitCardResult, PlayerCard(), GetPcOutput2(), PcResult());
                    }
                }
            }
            //Check if the user input equals S if so they have standed and it will check who won
            if (H.Key == ConsoleKey.S)
            {
                int CheckIfBust = Begin.HitCardResult + PlayerCard();

                if (CheckIfBust <= 21 && CheckIfBust > PcResult())
                {
                    Intro.DisplayWon(Begin.HitCardResult, PlayerCard());
                }
                if (CheckIfBust < 21 && CheckIfBust < PcResult())
                {
                    Intro.DisplayStandedBust(Begin.HitCardResult, PlayerCard(), GetPcOutput2(), PcResult());
                }
            }
        }

        // I know these probaly should be in the model, but i forgot ☺ ☺ ☺
        // Gets the users first card
        public string PlayerOutput1()
        {
            Begin.GetUserCard1();
            string PlayerOutput1 = Begin.PlayerOutput1;
            return PlayerOutput1;
        }
        // Gets the users second card
        public string PlayerOutput2()
        {
            Begin.GetUserCard2();
            string PlayerOutput2 = Begin.PlayerOutput2;
            return PlayerOutput2;
        }
        // Gets the combined value for the users cards
        public int PlayerCard()
        {
            int Result1 = Begin.PlayerCard1;
            int Result2 = Begin.PlayerCard2;
            int result = Result1 + Result2;
            return result;
        }
        // Gets the first card for the pc
        public string GetPcOutput1()
        {
            Begin.GetPcCard1();
            string PcOutput1 = Begin.GetPcCard1();
            return PcOutput1;
        }
        // Gets the second card for the pc
        public string GetPcOutput2()
        {
            Begin.GetPcCard2();
            string PcOutput2 = Begin.GetPcCard2();
            return PcOutput2;
        }
        // Makes the combined value for the pc's cards
        public int PcResult()
        {
            int Result1 = Begin.PcCard_1;
            int Result2 = Begin.PcCard_2;
            int PcResult = Result1 + Result2;
            return PcResult;
        }
        public string HitCard()
        {
            Begin.HitCard();

            return "";
        }
    }
}
