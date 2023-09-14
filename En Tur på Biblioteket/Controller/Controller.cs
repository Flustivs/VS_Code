using En_Tur_på_Biblioteket.Model;
using En_Tur_på_Biblioteket.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace En_Tur_på_Biblioteket.Controller
{
    public class Controller
    {
        Books Books = new Books();
        GUI GUI = new GUI();
        private List<string> user;
        
        public List<string> Booklist()
        {
            List<string> list = new List<string>();
            list = Books.BookList();
            return list;
        }
        public void Start()
        {
            user = Booklist();
            /*foreach (string item in user)
            {
                GUI.AskUser(item);
            }*/
            GUI.UserInput();
        }

        public List<string> LibraryBooks()
        {
            user = Booklist();
            return user;
        }
        public Stack<string> GetUserlend
        {
            get { return Books.UserLend; }
            set { Books.UserLend = value; }
        }
    }
}
