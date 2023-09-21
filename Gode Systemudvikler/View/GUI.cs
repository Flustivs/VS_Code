using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gode_Systemudvikler.View
{
    /// <summary>
    /// Prints out the exception and a little message by me
    /// </summary>
    internal class GUI
    {
        internal void FileNotFound(FileNotFoundException e)
        {
            Console.WriteLine(e + "\n\nFile is not found");
        }
        internal void IOException(IOException e)
        {
            Console.WriteLine(e + "\n\nClosed while running");
        }
        internal void FormatException(FormatException e)
        {
            Console.WriteLine(e + "\n\nNot correct format");
        }
        internal void NullReference(NullReferenceException e)
        {
            Console.WriteLine("\n\nThe file have no data");
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
