using System;
using System.Security.Cryptography;

namespace FlowChar_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start();
        }
        #region Control
        static void start()
        {
            instructions();
            while (true)
            {
                ClearArea(0, 9, 90, 7);
                int passed = validator();
                password(passed);
                bool done = donezo();
                if (done)
                {
                    break;
                }
            }
        }
        #endregion

        #region Module
        static bool donezo()
        {
            bool done = false;
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                done = true;
            }
            return done;
        }
        static void ClearArea(int left, int top, int width, int height)
        {
            Console.SetCursorPosition(left, top);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                }
                //Console.CursorLeft = left;
                //Console.CursorTop++;
                Console.SetCursorPosition(0, 8);
            }
        }
        static int validator()
        {
            bool end = true;
            bool UPPER = false;
            bool lower = false;
            bool number = false;
            bool CHAR = false;
            bool sequence = false;
            bool same = false;
            int passed = 0;

            while (end)
            {
                string UserPassword = Console.ReadLine();
                //check for length
                if (UserPassword.Length > 11)
                {
                    if (UserPassword.Length < 65)
                    {
                        // check for upper and lower case letters
                        for (int i = 0; i < UserPassword.Length; i++)
                        {
                            if (Char.IsUpper(UserPassword[i]))
                            {
                                UPPER = true;
                            }
                            if (Char.IsLower(UserPassword[i]))
                            {
                                lower = true;
                            }
                            
                        }
                        // check for numbers
                        if ((UPPER == true) && (lower == true))
                        {
                            for (int i =0; i < UserPassword.Length; i++)
                            {
                                if (char.IsNumber(UserPassword[i]))
                                {
                                    number = true;
                                }
                            }
                            //Check for special char
                            for (int i = 0;i < UserPassword.Length; i++)
                            {
                                if (!char.IsUpper(UserPassword[i]) && !char.IsLower(UserPassword[i]) && !char.IsNumber(UserPassword[i]))
                                {
                                    CHAR = true;
                                }
                            }
                            //check for 4 of the same chars in a row and a sequence
                            for (int i = 0;i < UserPassword.Length - 4; ++i)
                            {
                                if (UserPassword[i] == UserPassword[i + 1] && UserPassword[i] == UserPassword[i + 2] && UserPassword[i] == UserPassword[i + 3])
                                {
                                    same = true;
                                }

                            }
                            //check for a sequence of numbers for example 1234, 2345, 3456
                            for (int i =0;i < UserPassword.Length - 4; i++)
                            {
                                if (Char.IsNumber(UserPassword[i]) && Char.IsNumber(UserPassword[i + 1]) && 
                                    Char.IsNumber(UserPassword[i + 2]) && Char.IsNumber(UserPassword[i + 3]))
                                {
                                    int one = int.Parse(Convert.ToString(UserPassword[i]));
                                    int two = int.Parse(Convert.ToString(UserPassword[i + 1]));
                                    int three = int.Parse(Convert.ToString(UserPassword[i + 2]));
                                    int four = int.Parse(Convert.ToString(UserPassword[i + 3]));

                                    if ((two == one + 1) && (three == two + 1) && (four == three + 1))
                                    {
                                        sequence = true;
                                        break;
                                    }
                                }
                            }
                        }

                    }
                }
                else
                {
                    end = false;
                }
                if (UPPER && lower && number && CHAR && !same && !sequence)
                {
                    passed = 1;
                }
                else if (UPPER && lower && number && CHAR && same || sequence)
                {
                    passed = 2;
                }
                else if (!UPPER || !lower || !number)
                {
                    passed = 3;
                }
            }
            return passed;
        }
        #endregion

        #region GUI
        static string instructions()
        {
            Console.WriteLine("This program is a password validator\n" +
"Your password must contain between 12 - 64 characters\n" +
"Must contain UPPER and lower case letters\n" +
"Must contain at least 1 number and 1 special character\n" +
"You should avoid using more than 3 of the same letters or numbers in a row (for example 1111, bbbb, BBBB)\n" +
"You should also avoid using a sequence of numbers (for example 1234)\n" +
"\nPlease enter the password you want to validate: ");
            return "";
        }
        static string password(int passed = 0)
        {
            if (passed == 3)
            {
                ClearArea(0, 11, 60, 5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYour password is not valid");
                Console.ResetColor();
                Console.WriteLine("Do you want to try another password press any key, else press ESC\n");
            }
            if (passed == 2)
            {
                ClearArea(0, 11, 60, 5);
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("\nYour password is valid but weak and its not recommended");
                Console.ResetColor();
                Console.WriteLine("Do you want to try another password press any key, else press ESC\n");
            }
            if (passed == 1)
            {
                ClearArea(0, 11, 60, 5);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYour password is valid and strong");
                Console.ResetColor();
                Console.WriteLine("Do you want to try another password press any key, else press ESC\n");
            }
            return "";
        }
        #endregion
    }
}