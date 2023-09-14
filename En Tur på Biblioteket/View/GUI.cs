using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_Tur_på_Biblioteket.View
{
    public class GUI
    {
        private bool _yes = true;
        private bool _bookLending = true;
        private byte _num;

        public List<string> LibraryList()
        {
            Controller.Controller controller = new Controller.Controller();
            List<string> Booklist = new List<string>();
            foreach (string item in controller.Booklist())
            {
                Booklist.Add(item);
            }
            return Booklist;
        }
        public void AskUser(string item, byte Num)
        {
            if (_yes)
            {
                Console.WriteLine("What books would you like to lend?\nThis is your options, Press 8 to go register your lends");
                Console.WriteLine(Num + ". " + item);
                _yes = false;
            }
            else
            {
                Console.WriteLine(Num + ". " + item);
            }
        }
        public void UserInput()
        {
            Controller.Controller controller = new Controller.Controller();
            List<string> Booklist = LibraryList();
            while (_bookLending)
            {
                Console.Clear();
                _yes = true;
                _num = 1;
                foreach (var item in Booklist)
                {
                    AskUser(item,_num);
                    _num++;
                }

                string UserBook = Console.ReadLine();
                switch (UserBook)
                {
                    case "1":
                        controller.GetUserlend.Push(Booklist[0]);
                        break;
                    case "2":
                         controller.GetUserlend.Push(Booklist[1]);

                        break;
                    case "3":
                        controller.GetUserlend.Push(Booklist[2]);

                        break;
                    case "4":
                        controller.GetUserlend.Push(Booklist[3]);

                        break;
                    case "5":
                        controller.GetUserlend.Push(Booklist[4]);

                        break;
                    case "6":
                        controller.GetUserlend.Push(Booklist[5]);

                        break;
                    case "7":
                        controller.GetUserlend.Push(Booklist[6]);
                        break;
                    case "8":
                        _bookLending = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
            ConfirmLend();

        }
        public void ConfirmLend()
        {
            Console.Clear();
            Controller.Controller controller = new Controller.Controller();
            List<string> Booklist = LibraryList();
            List<string> ItDidntLetMe = new List<string> { "hej", "hej", "hej", "hej", "hej", "hej", "hej" };

            foreach(string item in  Booklist)
            {
                controller.GetUserlend.Push(item);
            }
            foreach (string item in ItDidntLetMe)
            {
                Console.WriteLine(controller.GetUserlend.Peek());
                controller.GetUserlend.Pop();
                
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Now its you books, for now ☺ ☺ ☺\nUntill i kill you");
            Console.ReadKey();
        }
    }
}
