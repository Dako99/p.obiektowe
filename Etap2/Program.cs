using System;

namespace Etap2_Katalog
{
    class Program
    {
        //public static int nr_auta;

        static void Main() //string[] args ??
        {

            int nr_auta;
            int[] tablica = new int[30];

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("MENU GŁÓWNE");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("1. Dodaj nowe auto");
                Console.WriteLine("2. Przeglądaj cały katalog");
                Console.WriteLine("3. Szukaj auta po ID");
                Console.WriteLine("4. /Usuwanie aut");
                Console.WriteLine("5. /Sorotowanie");
                Console.WriteLine("6.");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("9. Koniec programu  ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("0. Back");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;


                switch (Console.ReadKey(true).Key)
                {

                    case (ConsoleKey.D1):

                        Console.Clear();
                        PressF.Dodaj_auto();
                        PressF.Zapisz();
                        PressF.Przepisz();

                        Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                        Console.ReadKey();
                        break;


                    case ConsoleKey.D2:

                        Console.Clear();
                        for (int i = 0; i <= 10; i++)       //do zmiany
                        {
                            nr_auta = i + 1;
                            PressF.Wczytaj();
                            if (PressF.Wczytaj())
                            {
                                PressF.Przepisz();
                            }

                            //Console.WriteLine("There were {0} lines.", aktualny_nr);
                            //tablica[i].nr_auta = i + 1;
                            //tablica[i].wczytaj();
                            //tablica[i].przepisz();
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" ");
                        Console.WriteLine("Wczytano prawidłowowo");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(" ");
                        Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                        Console.ReadKey();
                        break;


                    case ConsoleKey.D3:
                        //PressF.SzukajAutoPoNr();


                        if (Console.ReadKey().Key != ConsoleKey.D0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Podaj ID samochodu");
                            Console.WriteLine("Nacisnij 0 aby wrócić");
                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            string id = Console.ReadLine();
                            //tablica[id].nr_auta = id;
                            //tablica[id].wczytaj();
                            //tablica[id].przepisz();
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }
                        break;


                    case ConsoleKey.D4:
                        Console.Clear();
                        //PressF.UsuwanieAuta();
                        //Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                        //Console.ReadLine();
                        break;


                    case ConsoleKey.D5:
                        //PressF.Sortowanie();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Wybór parametru do posortowania");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("1. Marka");
                        Console.WriteLine("2. Model");
                        Console.WriteLine("3. Silnik");
                        Console.WriteLine("4. Rocznik");
                        Console.WriteLine("5. Pojemność");
                        Console.WriteLine("6. Moc");
                        Console.WriteLine("7. Przebieg");
                        Console.WriteLine("8. Typ skrzyni biegów");
                        Console.WriteLine("  ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("0. Back");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("  ");


                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine("1");
                                //sort(wgMarki);
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine("2");
                                //sort(wgModelu);
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D3:
                                Console.WriteLine("3");
                                //sort(wgRocznika);
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D4:
                                Console.WriteLine("4");
                                //sort(wgPojemnosci);
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D5:
                                Console.WriteLine("5");
                                //sort(wgMocy);
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D6:
                                Console.WriteLine("6");
                                //sort(wgPrzebiegu);
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D7:
                                Console.WriteLine("7");
                                //sort(wgSkrzyni);
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine(" "); //system("cls");
                                Console.WriteLine("Nieprawidlowo wybrano parametr");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadLine();
                                break;
                        }
                        Console.WriteLine(" "); //system("cls");
                        break;


                    case ConsoleKey.D6:
                        //PressF.();

                        //KOT
                        Console.WriteLine("        | \\_/ |");
                        Console.WriteLine("       /  @ @ \\");
                        Console.WriteLine("      ( > o < )");
                        Console.WriteLine("       `>>x<<' ");
                        Console.WriteLine("       /  O  \\ ");

                        Console.ReadLine();
                        break;


                    case ConsoleKey.D7:
                        //PressF.();
                        break;

                    case ConsoleKey.D9:
                        Environment.Exit(0);
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
