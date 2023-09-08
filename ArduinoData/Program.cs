using System;
using System.IO.Ports;
using System.IO;
namespace ArduinoSerialToFile
{
    class Program
    {
        //Global variabler
        static string previousSentence = null;
        static byte count = 0;
        static string data = "";

        static void Main(string[] args)
        {
            // Hvilken Port og dens bits i sekundet
            SerialPort serialPort = new SerialPort("COM3", 9600);
            // Den her lytter på på dens representive method
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);

            serialPort.Open();
            Console.WriteLine("Listening on " + serialPort.PortName);
            Console.ReadKey();
            serialPort.Close();
        }
        private static void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Try reading my arduinos data and put it in a file
            try
            {
                SerialPort sp = (SerialPort)sender;
                data = sp.ReadLine();
                Console.WriteLine(data);

                
                // Looking for 2 Clap
                /*
                if (data.Equals(previousSentence, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
                else
                {
                    count = 0;
                    previousSentence = data;
                }
                */

                // Gemme data i en tekstfil
                using (StreamWriter sw = new StreamWriter("C:\\Users\\rune1\\Desktop\\output.txt", true))
                {
                    sw.WriteLine(data);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " +  ex.Message);
            }
        }
        // A bad try on making something
        /* 
        public void HTML()
        {
            byte Blinds = 0;
            byte clap = 0;
            byte light = 0;

            if (Blinds == 2)
            {
                //over i HTML og ændre billedet
            }
            else
            {

            }
        }*/
    }
}
