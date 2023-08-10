using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Mail;
using System.Text.RegularExpressions;

class keystrokes
{
    public static void Main(string[] args)
    {
        // variabler
        // 196 ─
        // 192 └
        // 217 ┘
        // 218 ┌
        // 179 │
        // 191 ┐
        double tal1 = 0;
        double tal2 = 0;
        int heltal1 = 0;
        int heltal2 = 0;
        int fakul1 = 0;
        double resul = 1;
        bool exit = false;
        double resultatet = 0;
        double result = 0;
        string fornavn = null;
        string efternavn = null;
        string adresse = null;
        string by = null;
        bool slut = false;
        string emailadressen;
        string menu =
        "\n┌───────────────────────────────────────────────────────────────────────┐\n" +
        "│ Opagve. 1 MateMatik                                                   │\n" +
        "│ Opgave. 2 Loop ned sumering                                           │\n" +
        "│ Opgave. 3 Beregne fakultetet af et tal                                │\n" +
        "│ Opgave. 4 Læs og skriv til en fil                                     │\n" +
        "│ Opgave. 5 JSON string editor og syntaks checker                       │\n" +
        "│ Opgave. 6 Email checker - med loop, if, regler                        │\n" +
        "│ Opgave. 7 Email checker - regulær udtryk                              │\n" +
        "│             Brug 1 - 7 for at vælge opgaven du vil ind i              │\n" +
        "└───────────────────────────────────────────────────────────────────────┘";
        // Function for at slette linje/område
        //static string ryd(int left, int top, int weidth, int height)
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
                Console.SetCursorPosition(0,11);
            }
        }
        Console.Write(menu);

        while (exit == false)
        {
            Console.WriteLine("\nTryk venligst på en tast\n");
            ConsoleKeyInfo key = Console.ReadKey();
            ClearArea(0, 11, 75, 20);
            Console.SetCursorPosition(0, 11);

            switch (key.KeyChar)
            {
                case '1':
                    {
                        Console.WriteLine("\nSkriv venligst første tal: ");
                        tal1 = double.Parse(Console.ReadLine());
                        Console.Write("\nSkriv veligst andet tal: ");
                        tal2 = double.Parse(Console.ReadLine());
                        ClearArea(0, 11, 29, 4);
                        resultatet = tal1 * tal2 / (tal1 - tal2) + tal2;
                        Console.Write("\nResultatet er: " + resultatet);
                    }
                    break;
                case '2':
                    {
                        Console.Write("\nSkriv venligst første heltal her: ");
                        heltal1 = int.Parse(Console.ReadLine());
                        Console.Write("\nSkriv Venligst andet heltal her: ");
                        heltal2 = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(0, 11);
                        ClearArea(0, 11, 40, 4);
                        Console.SetCursorPosition(0, 11);
                        Console.Write("\nTal 1 er: " + heltal1 + "\nDit andet Tal er: " + heltal2);
                        result = heltal1 * heltal2;
                        Console.Write("\nSummen er: " + result);
                    }
                    break;
                case '3':
                    {
                        Console.Write("Skriv venligst det tal der skal regnes fakultet af: ");
                        fakul1 = int.Parse(Console.ReadLine());
                        for (double i = 1; i != 1 + fakul1; i++)
                        {
                            resul *= i;
                        }
                        ClearArea(0, 11, 15, 2);
                        Console.Write("\n" + resul + "\n");
                    }
                    break;
                case '4':
                    {
                        string path = @"C:\Users\zbcrvsa\Desktop";
                        Console.Write("\nHvad skal filen hedde: ");
                        string navn = Console.ReadLine();
                        string pathnavn = path + navn + ".txt";
                        FileStream fs = File.Create(pathnavn);
                        ClearArea(0, 11, 35, 5);
                        if (File.Exists(pathnavn))
                        {
                            Console.SetCursorPosition(0, 11);
                            Console.Write("\nDin Fil er nu lavet\n");
                        }
                        else
                        {
                            ClearArea(0, 11, 34, 3);
                            Console.Write("Denne fil eksistere alleredet");
                            ClearArea(0, 11, 30, 1);
                        }
                        Console.Write("vil du gerne skrive noget i filen\n indtast j for Ja og n for Nej\n");
                        string JN = Console.ReadLine();
                        if (JN == "j")
                        {
                            ClearArea(0, 11, 55, 5);
                            File.OpenWrite(pathnavn);
                            Console.Write("\nHvad vil du gerne skrive i filen? ");
                            string text = Console.ReadLine();
                            File.WriteAllText(pathnavn, text);
                            string read = File.ReadAllText(pathnavn);

                        }
                        else
                        {
                            ClearArea(0, 11, 55, 5);
                            Console.SetCursorPosition(0, 11);
                            Console.Write("Vil du gerne se hvad der er i denne fil?\n brug j for Ja og n for Nej ");
                            string indhold = Console.ReadLine();
                            if (indhold == "j")
                            {
                                ClearArea(0, 11, 55, 5);
                                Console.SetCursorPosition(0, 11);
                                string læs = File.ReadAllText(pathnavn);
                                Console.Write(læs);
                            }
                        }

                    }
                    break;
                case '5':
                    {
                        Console.Write("Hvad er dit fornavn");
                        fornavn = Console.ReadLine();
                        //JSON Serializise and desiralzise
                    }
                    break;
                case '6':
                    {
                        emailadressen = ("\n┌────────────────┬───────┬──────────────────────────┐\n" +
                             "│  Kontonavn:    │SnabelA│  Server adresse:         │\n" +
                             "├────────────────┼───────┼──────────────────────────┤\n" +
                             "│                │       │                          │\n" +
                             "├────────────────┼───────┼──────────────────────────┤\n" +
                             "│                │       │                          │\n" +
                             "├────────────────┼───────┼──────────────────────────┤\n" +
                             "│                │       │                          │\n" +
                             "└────────────────┴───────┴──────────────────────────┘\n");

                        Console.Write(emailadressen);
                        Console.Write("\nSkriv venligst den Email du gerne ville validere\n");
                        string email = Console.ReadLine();
                        string gmail = email.Substring(0, email.IndexOf('@'));
                        string efter = email.Substring(email.IndexOf('@') + 1);
                        ClearArea(0, 21, 55, 14);
                        Console.SetCursorPosition(0, 21);

                        int længde = gmail.Length;
                        if (længde.Equals(1))
                        {
                            Console.SetCursorPosition(0, 22);
                            Console.Write("Dit Kontonavn skal være mellem 2 og 50 tegn\n");
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(4, 15);
                            Console.Write(gmail);
                            Console.SetCursorPosition(0, 28);
                            ClearArea(0, 11, 55, 1);
                            Console.SetCursorPosition(0, 21);
                        }

                        int snabel = efter.IndexOf('.');
                        if (snabel >= 2 && snabel <= 30)
                        {
                            Console.SetCursorPosition(20, 15);
                            Console.Write("@");
                            Console.SetCursorPosition(29, 15);
                            Console.Write(efter.Substring(0, snabel));
                            Console.SetCursorPosition(0, 21);
                            ClearArea(0, 21, 40, 4);

                        }
                        else
                        {
                            Console.Write("Ugyldig længde på Domæne\n");
                            break;
                        }
                        Console.SetCursorPosition(0, 11);
                        if (IsValidEmail(email))
                        {
                            Console.Write("E-mailen er gyldig\n");
                            Console.SetCursorPosition(0, 29);
                        }
                        else
                        {
                            Console.Write("Ugyldig e-mailadresse\n");
                            break;
                        }

                        static bool IsValidEmail(string email)
                        {
                            ClearArea(0, 21, 55, 9);
                            Console.SetCursorPosition(0, 22);
                            try
                            {
                                var addr = new System.Net.Mail.MailAddress(email);
                                return addr.Address == email;
                            }
                            catch
                            {
                                return false;
                            }
                        }

                    }
                    break;
                case '7':
                    {
                        var regexEmail = new Regex(@"([2-50])");
                        var regexaddr = new Regex(@"([a-z]||[A-Z][.])");
                        string menu1 = ("\n┌────────────────┬───────┬──────────────────────────┐\n" +
     "│  Kontonavn:    │SnabelA│  Server adresse:         │\n" +
     "├────────────────┼───────┼──────────────────────────┤\n" +
     "│                │       │                          │\n" +
     "├────────────────┼───────┼──────────────────────────┤\n" +
     "│                │       │                          │\n" +
     "├────────────────┼───────┼──────────────────────────┤\n" +
     "│                │       │                          │\n" +
     "└────────────────┴───────┴──────────────────────────┘\n");
                        Console.Write(menu1);
                        Console.Write("Hvilken Email vil du gerne validere med regulært udtryk: \n");
                        string email = Console.ReadLine();
                        if (email.Contains("@"))
                        {
                            string gmail = email.Substring(0, email.IndexOf('@'));
                            string efter = email.Substring(email.IndexOf('@') + 1);
                            ClearArea(0, 21, 75, 14);
                            Console.SetCursorPosition(0, 21);

                            if (regexEmail.IsMatch(gmail))
                            {
                                Console.Write("Gyldigt kontonavn");
                                Console.SetCursorPosition(0, 21);
                                Console.SetCursorPosition(2, 15);
                                Console.Write(gmail);
                                ClearArea(0, 21, 30, 2);
                            }
                            else
                            {
                                Console.Write("Ugyldigt kontonavn");
                                ClearArea(0, 21, 40, 15);
                                Console.Write("L boxzo");
                            }
                            if (regexaddr.IsMatch(efter))
                            {
                                Console.Write("Gyldigt domæne navn");
                                Console.SetCursorPosition(18, 15);
                                Console.Write(efter);

                            }
                            else
                            {
                                Console.SetCursorPosition(0, 22);
                                Console.Write("Ugyldigt Domæne navn");
                            }
                            Console.SetCursorPosition(0, 28);
                        }
                        else
                        {
                            Console.Write("Du mangler et @ i din Email");
                            break;
                        }
                    }
                    break;
                case 'q':
                    {
                        exit = true;
                        Console.Read();
                    }
                    break;
            }
        }
        Console.Write("\n\n\nTak for at kigge på mit lille projekt håber alt var til din belejlighed\n\n\n\n\n\n\n");
    }
}
