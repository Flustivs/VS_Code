using Microsoft.VisualBasic;

namespace Vinos_Blancos
{
    internal class Program
    {        static void Main(string[] args)
        {
            start();
        }
        #region Control
        static void start()
        {
            //int[] sales =  VIN();
            (int[] sales, int[] year, int[] stars) = VIN();
            GUI(sales, year, stars);
        }
        #endregion

        #region Model
        static (int[] sales, int[] year, int[] stars) VIN()
        {
            double amount = 0;
            int[] stars = new int[11];

            int[] sales = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            sales[0] = 175134;
            sales[1] = 175388;
            sales[2] = 172818;
            sales[3] = 142709;
            sales[4] = 151437;
            sales[5] = 152620 + 35432;
            sales[6] = 150979;
            sales[7] = 152210;
            sales[8] = 149450;
            sales[9] = 154398;
            sales[10] = 150160;

            int[] year = { 0, 1, 2,3,4,5,6,7,8,9,10 };
            year[0] = 2014;
            year[1] = 2010;
            year[2] = 2009;
            year[3] = 2011;
            year[4] = 2019;
            year[5] = 2018;
            year[6] = 2016;
            year[7] = 2013;
            year[8] = 2015;
            year[9] = 2017;
            year[10] = 2012;

            Array.Sort(sales);
            Array.Reverse(sales);

            for (int i = 0; i < sales.Length; i++)
            {
                amount = sales[i];
                amount = amount / 2000;
                amount = Math.Floor(amount);
                stars[i] = Convert.ToInt32(amount);
            }
            return (sales , year, stars);
        }
        #endregion

        #region View
        static void GUI (int[] sales, int[] year, int[] stars)
        {
            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write(year[i] + ": ");
                for (int j = 0; j < stars[i]; j++)
                {
                    Console.Write("*");
                }
                Console.Write("  " + sales[i]);
                Console.WriteLine();
            }
        }
        #endregion
    }
}