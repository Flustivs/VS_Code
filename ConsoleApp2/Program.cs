using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleKeyInfo key;
        bool end = false;
        double tal1 = 0;
        double tal2 = 0;
        int n = 0;
        double nums = 1;
        var navn = "";
        bool slut = false;
        string fornavn = "";
        string efternavn = "";
        string adresse = "";
        string by = "";
        while (!end)
        {
            Console.WriteLine("|- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -|");
            Console.WriteLine("|   Opg. 1 Matematik                                                |");
            Console.WriteLine("|   Opg. 2 Loop med summering                                       |");
            Console.WriteLine("|   Opg. 3 Beregne fakultetet af et tal                             |");
            Console.WriteLine("|   Opg. 4 Læs og skriv til en fil                                  |");
            Console.WriteLine("|   Opg. 5 JSON string editor og syntaks checker                    |");
            Console.WriteLine("|   Opg. 6 Email checker - med loop, if, regler                     |");
            Console.WriteLine("|   Opg. 7 Email checker - regulær udtryk                           |");
            Console.WriteLine("|   Tast et tal 1 - 7 eller q for at afslutte                       |");
            Console.WriteLine("|- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -|");


            key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    Console.WriteLine("\nSkriv venligst første tal:");
                    if (double.TryParse(Console.ReadLine(), out tal1))
                    {
                        Console.WriteLine("Skriv venligst andet tal:");
                        if (double.TryParse(Console.ReadLine(), out tal2))
                        {
                            Console.WriteLine("Resultat: " + (tal1 * tal2 / (tal1 - tal2) + tal2));
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt input for andet tal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt input for første tal.");
                    }
                    break;
                case '2':
                    Console.WriteLine("\nSkriv første heltal her:");
                    tal1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nSkriv andet heltal her:");
                    tal2 = double.Parse(Console.ReadLine());

                    for (double i = tal1; i < tal2; i++)
                    {
                        i = tal1 * tal2;
                        Console.WriteLine("Summen er :" + i);
                        i = i * i;
                    }
                    break;
                case '3':
                    Console.WriteLine("\nSkriv et heltal her :");
                    n = int.Parse(Console.ReadLine());
                    for (double i = 1; i != 1 + n; i++)
                    {
                        nums *= i;
                    }

                    Console.WriteLine("Fakulteten af er :" + nums);
                    break;
                case '4':
                    Console.WriteLine("\nSkriv navnet på din fil her:");
                    navn = Console.ReadLine();
                    string path = @"C:\Users\rune1\Desktop\" + navn + ".txt";

                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            Console.WriteLine("Filen er blevet oprettet. Skriv indholdet her:");
                            string content = Console.ReadLine();
                            sw.WriteLine(content);
                            Console.WriteLine("Indholdet er blevet skrevet til filen");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Filen eksisterer allerede. Skriv indholdet her:");
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            string content = Console.ReadLine();
                            sw.WriteLine(content);
                            Console.WriteLine("Indholdet er blevet skrevet til filen.");
                        }
                    }
                    break;
                case '5':
                    while (!slut)
                    {
                        if (fornavn == "")
                        {
                            Console.WriteLine("\nHvad er dit fornavn :");
                            fornavn = Console.ReadLine();
                        }
                        else { break; }
                        if (efternavn == "")
                        {
                            Console.WriteLine("\nhvad er dit efternavn :");
                            efternavn = Console.ReadLine();
                        }
                        else { break; }
                        if (adresse == "")
                        {
                            Console.WriteLine("\nhvad er din adresse :");
                            adresse = Console.ReadLine();
                        }
                        else { break; }
                        if (by == "")
                        {
                            Console.WriteLine("Og hvilken by bor du i :");
                            by = Console.ReadLine();
                        }
                        
;
                        fornavn = fornavn.Insert(0, "Fornavn: ");
                        efternavn = efternavn.Insert(0, "Efternavn: ");
                        adresse = adresse.Insert(0, "Adresse: ");
                        by = by.Insert(0, "By: ");
                        Console.WriteLine(fornavn);
                        Console.WriteLine(efternavn);
                        Console.WriteLine(adresse);
                        Console.WriteLine(by);


                        //backspace til og slette
                        Console.WriteLine("Er der noget du gerne ville slette skriver du bare dens kategorie her: ");
                        string i = Console.ReadLine();
                        if (i == "Fornavn")
                        {
                            while (i == "Fornavn")
                            {
                                Console.WriteLine(fornavn);
                                var del = Console.ReadKey();
                                var backslashal = '\b';
                                //if (del = backslashal);
                            }
                            
                        }
                        int længeden = fornavn.Length;
                        fornavn = fornavn.Insert(længeden, "");
                        efternavn = efternavn.Insert(længeden, "");
                        adresse = adresse.Insert(længeden, "");
                        by = by.Insert(længeden, "");

                        slut = true;
                    }
                    break;
                case '6':
                    Console.WriteLine("6");
                    break;
                case '7':
                    Console.WriteLine("7");
                    break;
                case 'q':
                    end = true;
                    break;
            }
        }
        Console.WriteLine("Nu er programmet slut");
    }
}