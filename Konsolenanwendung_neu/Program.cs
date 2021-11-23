using System;
using System.Diagnostics;
using System.Windows;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop_program = false;

            while (stop_program == false)
            {
                Console.WriteLine("Welches Programm solls heute sein?");
                Console.WriteLine("1 --- ganzzahlen von 0 bis 99\n2 --- alle geraden zahlen von 0 bis 99\n3 --- zahlen 0 bis 99 teilbar durch 3 und 5\n4 --- von 0 bis n alle primzahlen und deren anzahl\n5 --- dezimalwerte von 0 bis 999 in dualzahlen konvertieren\n6 --- Schere, Stein, Papier, Echse, Spock\n");

                string program_auswahl = Console.ReadLine();
                try
                {
                    switch (Convert.ToInt32(program_auswahl))
                    {
                        case 1:
                            string alle_ganzzahlen = "";
                            for (int i = 0; i < 100; i++)
                            {
                                alle_ganzzahlen += i + " ";
                            }
                            Console.WriteLine(alle_ganzzahlen);
                            end_program();
                            break;
                        case 2:
                            string alle_geraden_zahlen = "";
                            for (int i = 0; i < 100; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    alle_geraden_zahlen += i + " ";
                                }
                            }
                            Console.WriteLine(alle_geraden_zahlen);
                            end_program();
                            break;
                        case 3:
                            string durch_3_und_5_teilbar = "";
                            for (int i = 0; i < 100; i++)
                            {
                                if (i % 3 == 0 || i % 5 == 0)
                                {
                                    durch_3_und_5_teilbar += i + " ";
                                }
                            }
                            Console.WriteLine(durch_3_und_5_teilbar);
                            end_program();
                            break;
                        case 4:
                            Console.WriteLine("Bis zu welcher Zahl willst du alle Primzahlen wissen?");
                            int n = Convert.ToInt32(Console.ReadLine());
                            int primzahl;
                            int zahler = 0;
                            double wurzel = 0;
                            for (int i = 2; i <= n; i++)
                            {
                                wurzel = Math.Floor(Math.Sqrt(i));
                                primzahl = 1;
                                for (int teiler = 2; teiler <= wurzel; teiler++)
                                {
                                    if (i % teiler == 0) primzahl = 0;
                                }
                                if (primzahl == 1)
                                {
                                    Console.WriteLine(i);
                                    zahler++;
                                }
                            }
                            Console.WriteLine("\nZwischen " + n + " und 0 gab es " + zahler + " primzahlen");
                            end_program();
                            break;
                        case 5:
                            Console.Write("Gib eine Dezimalzahl ein: ");
                            double dezimalzahl = Convert.ToInt32(Console.ReadLine());
                            double binarzahl_ziffer;
                            string binarzahl = "";
                            while (dezimalzahl != 0)
                            {
                                binarzahl_ziffer = dezimalzahl % 2;
                                dezimalzahl = Math.Floor(dezimalzahl / 2);
                                binarzahl = binarzahl_ziffer + binarzahl;
                            }
                            Console.WriteLine(binarzahl);
                            end_program();
                            break;
                        case 6:
                            Console.Write("Wähle zwischen Schere(1), Stein(2), Papier(3), Echse(4) oder Spock(5): ");
                            int spielerwahl = Convert.ToInt32(Console.ReadLine());
                            Random random = new Random();
                            int gegnerauswahl = random.Next(1, 5);
                            Console.WriteLine();
                            spiele_schere_stein_papier(spielerwahl, gegnerauswahl);
                            Console.WriteLine();
                            end_program();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("\nError\n");
                    string target = "https://www.lernen.net/artikel/lesen-lernen-21606/#:~:text=Magazin-,Lesen%20lernen,-%3A%2012%20Tipps%20f%C3%BCr";
                    Process.Start(System.Environment.GetEnvironmentVariable("COMSPEC"), "/C " + "start " + target);
                    /*Process P = new Process();
                    P.StartInfo.FileName = "chrome.exe(https://www.google.de)";
                    P.Start();*/
                }

                void spiele_schere_stein_papier(int spielerwahl, int gegnerauswahl)
                {
                    if (spielerwahl == gegnerauswahl)
                    {
                        Console.WriteLine("\nGleichstand!");
                    }
                    else if (spielerwahl != gegnerauswahl)
                    {
                        switch (spielerwahl)
                        {
                            case 1:
                                switch (gegnerauswahl)
                                {
                                    case 2: Console.WriteLine("Stein schleift Schere! Dein Gegner hat gewonnen."); break;
                                    case 3: Console.WriteLine("Schere schneidet Papier! Du hast gewonnen."); break;
                                    case 4: Console.WriteLine("Schere köpft Echse! Du hast gewonnen."); break;
                                    case 5: Console.WriteLine("Spock zertrümmert Schere! Dein Gegner hat gewonnen."); break;
                                }
                                break;
                            case 2:
                                switch (gegnerauswahl)
                                {
                                    case 1: Console.WriteLine("Stein schleift Schere! Du hast gewonnen."); break;
                                    case 3: Console.WriteLine("Papier bedeckt Stein! Dein Gegner hat gewonnen."); break;
                                    case 4: Console.WriteLine("Stein zerquetscht Echse! Du hast gewonnen."); break;
                                    case 5: Console.WriteLine("Spock verdampft Stein! Du hast gewonnen."); break;
                                }
                                break;
                            case 3:
                                switch (gegnerauswahl)
                                {
                                    case 1: Console.WriteLine("Schere schneidet Papier! Dein Gegner hat gewonnen."); break;
                                    case 2: Console.WriteLine("Papier bedeckt Stein! Du hast gewonnen."); break;
                                    case 4: Console.WriteLine("Echse frisst Papier! Dein Gegner hat gewonnen."); break;
                                    case 5: Console.WriteLine("Papier widerlegt Spock! Du hast gewonnen."); break;
                                }
                                break;
                            case 4:
                                switch (gegnerauswahl)
                                {
                                    case 1: Console.WriteLine("Schere köpft Echse! Dein Gegner hat gewonnen."); break;
                                    case 2: Console.WriteLine("Stein zerquetscht Echse! Dein Gegner hat gewonnen."); break;
                                    case 3: Console.WriteLine("Echse frisst Papier! Du hast gewonnen."); break;
                                    case 5: Console.WriteLine("Echse vergiftet Spock! Du hast gewonnen."); break;
                                }
                                break;
                            case 5:
                                switch (gegnerauswahl)
                                {
                                    case 1: Console.WriteLine("Spock zertrümmert Schere! Du hast gewonnen."); break;
                                    case 2: Console.WriteLine("Spock verdampft Stein! Du hast gewonnen."); break;
                                    case 3: Console.WriteLine("Papier widerlegt Spock! Dein Gegner hat gewonnen."); break;
                                    case 4: Console.WriteLine("Echse vergiftet Spock! Dein Gegner hat gewonnen."); break;
                                }
                                break;
                        }
                    }
                }

                void end_program()
                {
                    Console.WriteLine("Programm beenden? j/n");
                    string stop = Console.ReadLine();
                    Console.Clear();
                    if (stop == "j")
                        stop_program = true;
                    return;
                }
            }
        }
    }
}
