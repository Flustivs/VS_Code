using Gode_Systemudvikler.Model;
using Gode_Systemudvikler.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gode_Systemudvikler.Controller
{
    internal class Controller
    {
        View.GUI GUI = new View.GUI();
        internal void File()
        {
            Model.File start = new Model.File();
            start.FileReader();
        }
        internal void FileNotFound(FileNotFoundException e)
        {
            GUI.FileNotFound(e);
        }
        internal void IOException(IOException e)
        {
            GUI.IOException(e);
        }
        internal void FormatException(FormatException e)
        {
            GUI.FormatException(e);
        }
        internal void Nullreference(NullReferenceException e)
        {
            GUI.NullReference(e);
        }
        internal void Final()
        {
            GUI.Final();
        }
        internal void Data(short E)
        {
            GUI.NumberOfE(E);
        }
    }
}
