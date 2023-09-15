using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.Model
{
    public class Track
    {
        private string _name;
        LinkedList<string> heavy = new LinkedList<string>();
        LinkedList<string> halvfemserne = new LinkedList<string>();
        LinkedList<string> firserne = new LinkedList<string>();
        LinkedList<string> country = new LinkedList<string>();
        LinkedList<string> Main = new LinkedList<string>();

        public LinkedList<string> Predefined
        {
            get { return Main; }
            set { Main = value; }
        }
        public LinkedList<string> Heavy
        {
            get { return heavy; }
            set { heavy = value; }
        }
        public LinkedList <string> Firserne
        {
            get { return firserne; }
            set { firserne = value; }
        }
        public LinkedList<string> Halvfemserne
        {
            get { return halvfemserne; }
            set { halvfemserne = value;}
        }
        public LinkedList<string> Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
