using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gode_Systemudvikler.Model
{
    internal class File
    {
        Controller.Controller controller = new Controller.Controller();
        internal void FileReader()
        {
            string FileName = @"C:\Users\rune1\Desktop\Firm V2.txt";
            StreamReader reader;
            try
            {
                reader = new StreamReader(FileName);
                controller.Data(DataSave(reader.ReadToEnd()));

            }
            catch (FileNotFoundException e)
            {
                controller.FileNotFound(e);
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
            }
        }
        internal short DataSave(string reader)
        {
            short NumberOfE = 0;
            try
            {
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
