using Playlisten.GUI;
using Playlisten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.Controller
{
    public class Controller
    {
        Track Track = new Track();
        Playlist Playlist = new Playlist();
        GUI.GUI GUI = new GUI.GUI();
        public void StartGame()
        {
            bool go = true;
            while (go)
            {
                GUI.ClearScreen();
                string output = GUI.StartMenu();
                if (output != "0")
                {
                    switch (output)
                    {
                        case "1":
                            GUI.Printout(Playlist.PlaylistMain());
                            break;
                        case "2":
                            GUI.Printout(Playlist.countrylist(GUI.AskUserSong("Country")));
                            break;
                        case "3":
                            GUI.Printout(Playlist.Heavy(GUI.AskUserSong("Heavy")));
                            break;
                        case "4":
                            GUI.Printout(Playlist.Firserne(GUI.AskUserSong("Firserne")));
                            break;
                        case "5":
                            GUI.Printout(Playlist.Halvfemserne(GUI.AskUserSong("Halvfemserne")));
                            break;
                        case "6":
                            go = false;
                            break;
                        default:
                            GUI.WrongInput();
                            break;
                    }
                }
            }
            
        }
    }
}
