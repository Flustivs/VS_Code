using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gode_Systemudvikler.View
{
    internal class GUI
    {
        internal void FileNotFound(FileNotFoundException e)
        {
            Console.WriteLine(e + " is not found");
        }
        internal void IOException(IOException e)
        {
            Console.WriteLine(e + " Closed while running");
        }
        internal void FormatException(FormatException e)
        {
            Console.WriteLine(e + " Not correct format");
        }
        internal void NullReference(NullReferenceException e)
        {
            Console.WriteLine("The file have no data");
        }
        internal void Final()
        {
            Console.WriteLine("Everything is good");
            Console.ReadKey();
        }
        internal void NumberOfE(short E)
        {
            Console.WriteLine("There are " + E + " e's");
        }
    }
}
