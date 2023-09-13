using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    /// <summary>
    /// In this class i use and adjust data for the game
    /// </summary>
    public class GameData
    {
        // Just a few Variables
        private Random random = new Random();
        private Struct.GiveCard card = new Struct.GiveCard();
        private string[] user;
        private string UserCard;
        private string UserCard2;
        private string[] Pc;
        private string _pcCard;
        private string _pcCard2;
        private int CardNumber;
        private int PlayerResult1;
        private int PlayerResult2;
        private string _result1;
        private string _result2;
        private int PcResult1;
        private int PcResult2;
        private string _pcresult1;
        private string _pcresult2;
        private string _hitCard;
        private string[] _userHit;
        private string _hitResult;
        private int HitResult;

        // Gets a Random number
        public int RandomCard()
        {
            CardNumber = random.Next(0,40);
            return CardNumber;
        }
        // Makes the users first card
        public string GetUserCard1()
        {
            RandomCard();
            user = card.Card();
            UserCard = user[CardNumber];
            CardToNumber();
            return UserCard;
        }
        // Makes the users second card
        public string GetUserCard2()
        {
            RandomCard();
            user = card.Card();
            UserCard2 = user[CardNumber];
            CardToNumber();
            return UserCard;
        }
        // Makes the pc's first card
        public string GetPcCard1()
        {
            RandomCard();
            Pc = card.Card();
            _pcCard = Pc[CardNumber];
            PccardToNumber();
            return _pcCard;
        }
        // Makes the pc's second card
        public string GetPcCard2()
        {
            RandomCard();
            Pc = card.Card();
            _pcCard2 = Pc[CardNumber];
            PccardToNumber();
            return _pcCard2;
        }
        // Converts for exemple a "10 spades" to a 10 for the the user
        public void CardToNumber()
        {
            if (PlayerOutput2 == null)
            {
                _result1 = PlayerOutput1.Split(' ')[0];
                if (PictureCard1() == "10" || PictureCard1() == "11")
                {
                    _result1 = PictureCard1();
                    PlayerResult1 = int.Parse(_result1);
                }
                else
                {
                    PlayerResult1 = int.Parse(_result1);
                }
            }
            if (PlayerOutput2 != null)
            {
                _result2 = PlayerOutput2.Split(' ')[0];
                if (PictureCard2() == "10" || PictureCard2() == "11")
                {
                    _result2 = PcPictureCard2();
                    PlayerResult2 = int.Parse(_result2);
                }
                else
                {
                    PlayerResult2 = int.Parse(_result2);
                }
            }

        }
        // Converts for exemple a "10 spades" to a 10 for the pc
        public void PccardToNumber()
        {
            if (_pcCard2 == null)
            {
                _pcresult1 = PcOutput1.Split(' ')[0];
                if (PcPictureCard1() == "10" || PcPictureCard1() == "11")
                {
                    _pcresult1 = PcPictureCard1();
                    PcResult1 = int.Parse(_pcresult1);
                }
                else
                {
                    PcResult1 = int.Parse(_pcresult1);
                }
            }
            if (_pcCard2 != null)
            {
                _pcresult2 = PcOutput2.Split(' ')[0];
                if (PcPictureCard2() == "10" || PcPictureCard2() == "11")
                {
                    _pcresult2 = PcPictureCard2();
                    PcResult2 = int.Parse(_pcresult2);
                }
                else
                {
                    PcResult2 = int.Parse(_pcresult2);
                }
            }
        }
        // Converts for exemple a "Queen spades" to a 10 for users card1
        public string PictureCard1()
        {
            if (_result1 == "Ace")
            {
                _result1 = "11";
            }
            if (_result1 == "Jack" || _result1 == "Queen" || _result1 == "King")
            {
                _result1 = "10";
            }
            return _result1;
        }
        // Converts for exemple a "Queen spades" to a 10 for users card2
        public string PictureCard2()
        {
            if (_result2 == "Ace")
            {
                _result2 = "11";
            }
            if (_result2 == "Jack" || _result2 == "Queen" || _result2 == "King")
            {
                _result2 = "10";
            }
            return _result2;
        }
        // Converts for exemple a "Queen spades" to a 10 for pc's card1
        public string PcPictureCard1()
        {
            if (_pcresult1 == "Ace")
            {
                _pcresult1 = "11";
            }
            if (_pcresult1 == "Jack" || _pcresult1 == "Queen" || _pcresult1 == "King")
            {
                _pcresult1 = "10";
            }
            return _pcresult1;
        }
        // Converts for exemple a "Queen spades" to a 10 for pc's card2
        public string PcPictureCard2()
        {
            if (_pcresult2 == "Ace")
            {
                _pcresult2 = "11";
            }
            if (_pcresult2 == "Jack" || _pcresult2 == "Queen" || _pcresult2 == "King")
            {
                _pcresult2 = "10";
            }
            return _pcresult2;
        }
        // If they want to Hit thell get a card
        public string HitPictureCard()
        {
            if (_hitResult == "Ace")
            {
                _hitResult = "11";
            }
            if (_hitResult == "Jack" || _hitResult == "Queen" || _hitResult == "King")
            {
                _hitResult = "10";
            }
            return _hitResult;
        }
        // Coverts the hitted card to a number
        public string HitCard()
        {
            RandomCard();
            _userHit = card.Card();
            _hitCard = _userHit[CardNumber];
            HitCardToNumber();
            return _hitCard;
        }
        public void HitCardToNumber()
        {
            _hitResult = Hit_Card.Split(' ')[0];
            if (HitPictureCard() == "10" || HitPictureCard() == "11")
            {
                _hitResult = HitPictureCard();
                HitResult = int.Parse(_hitResult);
            }
            else
            {
                HitResult = int.Parse(_hitResult);
            }
        }
        public string PlayerOutput1
        {
            get { return UserCard; }
            set { UserCard = value; }
        }
        public string PlayerOutput2
        {
            get { return UserCard2; }
            set { UserCard2 = value; }
        }
        public int PlayerCard1
        {
            get { return PlayerResult1; }
            set { PlayerResult1 = value; }
        }
        public int PlayerCard2
        {
            get { return PlayerResult2; }
            set { PlayerResult2 = value; }
        }
        public string PcOutput1
        {
            get { return _pcCard; }
            set { _pcCard = value; }
        }
        public string PcOutput2
        {
            get { return _pcCard2; }
            set { _pcCard2 = value; }
        }
        public int PcCard_1
        {
            get { return PcResult1; }
            set { PcResult1 = value; }
        }
        public int PcCard_2
        {
            get { return PcResult2; }
            set { PcResult2 = value; }
        }
        public string Hit_Card
        {
            get { return _hitCard; }
            set { _hitCard = value; }
        }
        public int HitCardResult
        {
            get { return HitResult; }
            set { HitResult = value; }
        }
    }
}
