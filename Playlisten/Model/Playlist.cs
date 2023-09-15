using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Playlisten.Model
{
    public class Playlist
    {
        Track track = new Track();
        public LinkedList<string> PlaylistMain()
        {
            LinkedList<string> Main = track.Predefined;
            Main.AddFirst("heat Waves");
            Main.AddFirst("As It Was");
            Main.AddFirst("Stay");
            Main.AddFirst("Easy On Me");
            Main.AddFirst("Shivers");
            Main.AddFirst("First Class");
            Main.AddFirst("Big Energy");
            Main.AddFirst("Ghost");
            Main.AddFirst("Super Gremlin");
            Main.AddFirst("Cold Heart");
            Main.AddFirst("Wait For U");
            Main.AddFirst("About Damn Time");
            Main.AddFirst("Bad Habbits");
            Main.AddFirst("Thats What I Want");
            Main.AddFirst("Enemy");

            return Main;
        }
        public LinkedList<string> countrylist(string name)
        {
            track.Country.AddFirst(name);
            return track.Country;
        }
        public LinkedList<string> Halvfemserne(string name)
        {
            track.Halvfemserne.AddFirst(name);
            return track.Halvfemserne;
        }
        public LinkedList<string> Firserne(string name)
        {
            track.Firserne.AddFirst(name);
            return track.Firserne;
        }
        public LinkedList<string> Heavy(string name)
        {
            track.Heavy.AddFirst(name);
            return track.Heavy;
        }
    }
}
