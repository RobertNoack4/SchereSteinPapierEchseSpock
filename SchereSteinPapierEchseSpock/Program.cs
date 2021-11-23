using System;
using System.Linq.Expressions;

namespace SchereSteinPapierEchseSpock
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool wiederholung;
            do
            {
                wiederholung = false;

                Console.WriteLine("Bitte wählen sie eine Option: ");
                Console.WriteLine("1 = Schere");
                Console.WriteLine("2 = Stein");
                Console.WriteLine("3 = Papier");
                Console.WriteLine("4 = Echse");
                Console.WriteLine("5 = Spock");

                Console.WriteLine("Geben sie eine Zahl zwischen 1 und 5 ein!");
                bool fehler;
                int spielerZahl = 0;
                do
                {
                    fehler = false;
                    try
                    {
                        spielerZahl = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Bitte geben sie eine ZAHL zwischen 1 und 5 ein!");
                        fehler = true;
                        spielerZahl = 1;
                    }

                    if (spielerZahl < 1 || spielerZahl > 5)
                    {
                        Console.WriteLine("Bitte geben sie eine Zahl ZWISCHEN 1 UND 5 ein!");
                        fehler = true;
                    }
                } while (fehler);

                Random rnd = new Random();
                int computerZahl = rnd.Next(1, 6);

                switch (spielerZahl)
                {
                    case 1:
                        switch (computerZahl)
                        {
                            case 1:
                                Console.WriteLine("unentschieden");
                                break;
                            case 2:
                                Console.WriteLine("Stein schleift Schere");
                                Console.WriteLine("Turing gewinnt");
                                break;
                            case 3:
                                Console.WriteLine("Schere schneidet Papier");
                                Console.WriteLine("Spieler gewinnt");
                                break;
                            case 4:
                                Console.WriteLine("Schere köpft Echse");
                                Console.WriteLine("Spieler gewinnt");
                                break;
                            case 5:
                                Console.WriteLine("Spock zertrümmert Schere");
                                Console.WriteLine("Turing gewinnt");
                                break;
                        }

                        break;
                    case 2:
                        switch (computerZahl)
                        {
                            case 1:
                                Console.WriteLine("Stein schleift Schere");
                                Console.WriteLine("Spieler gewinnt");
                                break;

                            case 2:
                                Console.WriteLine("unentschieden");
                                break;
                            case 3:
                                Console.WriteLine("Papier bedeckt Stein");
                                Console.WriteLine("Turing gewinnt");
                                break;
                            case 4:
                                Console.WriteLine("Stein zerquetscht Echse");
                                Console.WriteLine("Spieler gewinnt");
                                break;
                            case 5:
                                Console.WriteLine("Spock verdampft Stein");
                                Console.WriteLine("Turing gewinnt");
                                break;
                        }

                        break;
                    case 3:
                        switch (computerZahl)
                        {
                            case 1:
                                Console.WriteLine("Schere schneidet Papier");
                                Console.WriteLine("Turing gewinnt");
                                break;
                            case 2:
                                Console.WriteLine("Papier bedeckt Stein");
                                Console.WriteLine("Spieler gewinnt");
                                break;
                            case 3:
                                Console.WriteLine("unetschieden");
                                break;
                            case 4:
                                Console.WriteLine("Echse frisst Papier");
                                Console.WriteLine("Turing gewinnt");
                                break;
                            case 5:
                                Console.WriteLine("Papier widerlegt Spock");
                                Console.WriteLine("Spieler gewinnt");
                                break;
                        }

                        break;
                    case 4:
                        switch (computerZahl)
                        {
                            case 1:
                                Console.WriteLine("Schere köpft Echse");
                                Console.WriteLine("Turing gewinnt");
                                break;
                            case 2:
                                Console.WriteLine("Stein zerquetscht Echse");
                                Console.WriteLine("Turing gewinnt");
                                break;
                            case 3:
                                Console.WriteLine("Echse frisst Papier");
                                Console.WriteLine("Spieler gewinnt");
                                break;
                            case 4:
                                Console.WriteLine("unentschieden");
                                break;
                            case 5:
                                Console.WriteLine("Echse vergiftet Spock");
                                Console.WriteLine("Spieler gewinnt");
                                break;
                        }
                        break;
                    case 5:
                        switch (computerZahl)
                        {
                            case 1:
                                Console.WriteLine("Spock zertrümmert Schere");
                                Console.WriteLine("Spieler gewinnt");
                                break;
                            case 2:
                                Console.WriteLine("Spock verdampft Stein");
                                Console.WriteLine("Spieler gewinnt");
                                break;
                            case 3:
                                Console.WriteLine("Papier widerlegt Spock");
                                Console.WriteLine("Turing gewinnt");
                                break;
                            case 4:
                                Console.WriteLine("Echse vergiftet Spock");
                                Console.WriteLine("Turing gewinnt");
                                break;
                            case 5:
                                Console.WriteLine("unentschieden");
                                break;
                        }

                        break;
                }

                Console.WriteLine("Möchten sie weiter spielen?");
                Console.WriteLine("Y/N");
                string antwort = Console.ReadLine();
                if (antwort == "Y" || antwort == "y")
                {
                    wiederholung = true;
                }
            } while (wiederholung);
        }
    }
}