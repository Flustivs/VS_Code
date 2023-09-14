using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_Tur_på_Biblioteket.Model
{
    public class Books
    {
        List<string> AllBooks = new List<string>();
        public List<string> BookList()
        {
            AllBooks.Add("Rest in Peace");
            AllBooks.Add("Henry Totter");
            AllBooks.Add("king of the Bracelets");
            AllBooks.Add("Tim Bruise");
            AllBooks.Add("Cruce Tee");
            AllBooks.Add("EdderKoppeManden");
            AllBooks.Add("Avatar the first genderbender");
            return AllBooks;
        }
        Stack<string> Userbook = new Stack<string>();

        public Stack<string> UserLend
        {
            get { return Userbook; }
            set { Userbook = value; }
        }
    }
}
