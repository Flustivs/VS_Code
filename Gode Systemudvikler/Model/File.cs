using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gode_Systemudvikler.Model
{
    /// <summary>
    /// Read File and looks through the data for specifically e and have exceptions for if the file is not found or
    /// if the file is still opend, or format exceptions
    /// </summary>
    internal class File
    {
        Controller.Controller controller = new Controller.Controller();
        internal void FileReader()
        {
            string FileName = @"C:\Users\rune1\Desktop\Firm V2.txt";
            try
            {
                StreamReader reader = new StreamReader(FileName);
                //Looks through the whole file then looks for e's and then give the amount of e's to the gui to print out
                controller.Data(DataSave(reader.ReadToEnd()));
            }
            catch (FileNotFoundException e)
            {
                controller.FileNotFound(e);
                throw e;
            }
            catch (IOException IO)
            {
                controller.IOException(IO);
            }
            catch (FormatException F)
            {
                controller.FormatException(F);
            }
            finally
            {
                controller.Final();
                StreamReader reader = new StreamReader(FileName);
                reader.Close();
            }
        }
        internal short DataSave(string reader)
        {
            short NumberOfE = 0;
            try
            {
                //Looks for e's
                foreach (var item in reader)
                {
                    if (item == 'e')
                    {
                        NumberOfE++;
                    }
                }
                return NumberOfE;
            }
            catch (NullReferenceException e)
            {
                controller.Nullreference(e);
            }
            finally
            {
                controller.Final();
            }
            return NumberOfE;
        }
    }
}
