using System;
using System.Linq;

namespace Etap2_Katalog
{
    class Program
    {
        //public static int nr_auta;

        static void Main() //??string[] args??
        {
            int nr_auta;
            Auto[] tab0;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("MENU GŁÓWNE");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("1. Dodaj nowe auto");
                Console.WriteLine("2. Przeglądaj cały katalog");
                Console.WriteLine("3. Szukaj auta po ID");
                Console.WriteLine("4. /Usuwanie aut");
                Console.WriteLine("5. Sorotowanie aut po parametrach");
                Console.WriteLine("6. ?");
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
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Katalog samochodów:");
                        Console.WriteLine("  ");
                        Console.ResetColor();

                        PressF.Wczytaj();
                        int z = PressF.lista0.Count;
                        //foreach()
                        for (int i = 0; i < 10; i++)       //do zmiany
                        {

                            Auto.nr_auta = i + 1;
                            PressF.Wczytaj();
                            PressF.Przepisz();


                            //for (int i = 0; i <= 10; i++)
                            //{ //do zmiany
                            //    PressF.tab0[i].nr_auta = i + 1;
                            //    PressF.tab0[i].Wypisz();
                            //    PressF.Wczytaj();
                            //    PressF.Przepisz();
                            //}

                            //    for (int i = 0; i <= 10; i++)
                            //{ //do zmiany
                            //    tab[i].nr_auta = i + 1;
                            //    tab[i].wczytaj();
                            //    tab[i].przepisz();
                            //}

                            //PressF.lista0[10 - 1].Wypisz();

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

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Podaj ID samochodu");
                        Console.WriteLine("Nacisnij 0 aby wrócić");
                        Console.WriteLine(" ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        if (Console.ReadKey().Key != ConsoleKey.D0)
                        {
                            string id = Console.ReadLine();
                            //tablica[id].nr_auta = id;
                            //tablica[id].wczytaj();
                            //tablica[id].przepisz();




                            //PressF.lista0.Count();

                            Console.Write("{0,-4}", id);
                            //PressF.lista0[Int.Parse(id)].Wypisz();Dod
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }
                        break;


                    case ConsoleKey.D4:

                        Console.Clear();
                        PressF.Przepisz();
                        Console.WriteLine(" ");
                        Console.WriteLine("Nacisnij 0 aby wrócić");
                        Console.WriteLine(" ");
                        PressF.Usun_auto();
                        Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                        Console.ReadLine();
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
                                //sort wgMarki
                                PressF.lista0 = PressF.lista0.OrderBy(p => p.marka).ToList();
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine("2");
                                //sort wgModelu
                                PressF.lista0 = PressF.lista0.OrderBy(p => p.model).ToList();
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D3:
                                Console.WriteLine("3");
                                //sort wgRocznika
                                PressF.lista0 = PressF.lista0.OrderBy(p => p.rocznik).ToList();
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D4:
                                Console.WriteLine("4");
                                //sort wgPojemnosc
                                PressF.lista0 = PressF.lista0.OrderBy(p => p.marka).ToList();
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D5:
                                Console.WriteLine("5");
                                //sort wgMocy
                                PressF.lista0 = PressF.lista0.OrderBy(p => p.moc).ToList();
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D6:
                                Console.WriteLine("6");
                                //sort wgPrzebiegu
                                PressF.lista0 = PressF.lista0.OrderBy(p => p.przebieg).ToList();
                                Console.WriteLine("Posortowano");
                                Console.WriteLine("Naciśnij klawisz, aby kontynuować");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D7:
                                Console.WriteLine("7");
                                //sort wgSkrzyni
                                PressF.lista0 = PressF.lista0.OrderBy(p => p.biegi).ToList();
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

                        //KOT
                        do
                        {
                            Console.WriteLine("                 ");
                            Console.WriteLine("        | \\_/ | ");
                            Console.WriteLine("       /  @ @ \\ ");
                            Console.WriteLine("      ( > o < )  ");
                            Console.WriteLine("       `>>x<<'   ");
                            Console.WriteLine("       /  O  \\  ");
                            Console.WriteLine("                 ");

                            Console.WriteLine("Nacisnij 0 aby wrócić");
                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        } while (Console.ReadKey().Key != ConsoleKey.D0);

                        Console.Clear();
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
