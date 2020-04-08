using System;
using System.Collections.Generic; //List
using System.Text;
using System.IO; //obsługa plików
using System.Linq;
using System.Collections;

namespace Etap2_Katalog
{
    class PressF
    {
        public static string marka;
        public static string model;
        public static string silnik;
        public static int rocznik;
        public static int pojemnosc;
        public static int moc;
        public static int przebieg;
        public static string biegi;

        public static int nr_auta;
        //public static string Nazwa;

        public static List<Auto> lista0 = new List<Auto>();  //kolekcja (List)
        public static Auto[] tab0; // = new Auto[8]

        //metody

        public static bool Wczytaj()             //wczytuje dane z pliku
        {

            if (File.Exists("Baza.txt"))
            {//System.IO. ????
                FileStream plik = new FileStream("Baza.txt", FileMode.Open, FileAccess.Read);
                StreamReader strumienOdczytu = new StreamReader("Baza.txt");


                int aktualny_nr = 1;
                string linia; //= strumienOdczytu.ReadToEnd().ToString() 
                int nr_linii = (nr_auta - 1) * 8 + 0; //do zmiany

                while ((strumienOdczytu.ReadLine()) != null) //?????????
                {
                    marka = strumienOdczytu.ReadLine();
                    model = strumienOdczytu.ReadLine();
                    silnik = strumienOdczytu.ReadLine();
                    rocznik = int.Parse(strumienOdczytu.ReadLine());
                    pojemnosc = int.Parse(strumienOdczytu.ReadLine());
                    moc = int.Parse(strumienOdczytu.ReadLine());
                    przebieg = int.Parse(strumienOdczytu.ReadLine());
                    biegi = strumienOdczytu.ReadLine();


                    if (aktualny_nr == nr_linii + 0) ;
                    if (aktualny_nr == nr_linii + 1) marka = strumienOdczytu.ReadLine();
                    if (aktualny_nr == nr_linii + 2) model = strumienOdczytu.ReadLine();
                    if (aktualny_nr == nr_linii + 3) silnik = strumienOdczytu.ReadLine();
                    if (aktualny_nr == nr_linii + 4) rocznik = int.Parse(strumienOdczytu.ReadLine());
                    if (aktualny_nr == nr_linii + 5) pojemnosc = int.Parse(strumienOdczytu.ReadLine());
                    if (aktualny_nr == nr_linii + 6) moc = int.Parse(strumienOdczytu.ReadLine());
                    if (aktualny_nr == nr_linii + 7) przebieg = int.Parse(strumienOdczytu.ReadLine());
                    if (aktualny_nr == nr_linii + 8) biegi = strumienOdczytu.ReadLine();


                    Auto noweAuto = new Auto(marka, model, silnik, rocznik, pojemnosc, moc, przebieg, biegi);
                    //lista0.Add(noweAuto); //test

                    // mozna zamiennie^
                    //lista0.Add(new Auto(marka, model, silnik, rocznik, pojemnosc, moc, przebieg, biegi));

                    tab0 = lista0.ToArray();

                    foreach (Auto item in lista0)
                    {
                        Console.WriteLine(item.marka);
                        Console.WriteLine(item.model);
                        Console.WriteLine(item.silnik);
                        Console.WriteLine(item.rocznik);
                        Console.WriteLine(item.pojemnosc);
                        Console.WriteLine(item.moc);
                        Console.WriteLine(item.przebieg);
                        Console.WriteLine(item.biegi);
                    }

                    //foreach (var item in lista0)
                    //{
                    //    Console.WriteLine(item);
                    //}


                    //ArrayList list0 = new ArrayList();

                    //Console.WriteLine(lista0[0].ToString());

                    strumienOdczytu.Close();
                    plik.Close();
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Plik nie istnieje!");
                return false;
            }
            return true;
        }

        public static void Zapisz()             //zapisuje dane do pliku
        {
            FileStream plik = new FileStream("Baza.txt", FileMode.Append, FileAccess.Write);
            plik.Seek(0, SeekOrigin.End);
            StreamWriter strumienZapisu = new StreamWriter(plik);

            // for (int i = 0; i < lista0.Count; i++)
            //{
            strumienZapisu.WriteLine("add");
            strumienZapisu.WriteLine(marka);
            strumienZapisu.WriteLine(model);
            strumienZapisu.WriteLine(silnik);
            strumienZapisu.WriteLine(rocznik);
            strumienZapisu.WriteLine(pojemnosc);
            strumienZapisu.WriteLine(moc);
            strumienZapisu.WriteLine(przebieg);
            strumienZapisu.WriteLine(biegi);
            // }


            Console.WriteLine(" ");
            Console.WriteLine("Dodanych aut:");
            for (int i = 0; i < lista0.Count; i++)
            {
                Console.Write("add{0,-4}", i + 1);
                Console.WriteLine(" ");
            }

            strumienZapisu.Close();
            plik.Close();

            lista0.RemoveRange(0, lista0.Count());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine("Zapisano!");
            Console.WriteLine(" ");
            Console.ResetColor();
        }


        public static void Przepisz()           //przepisuje dane do konsoli
        {

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Marka:{0} ", marka);
            Console.WriteLine("Model:{0} ", model);
            Console.WriteLine("Silnik:{0} ", silnik);
            Console.WriteLine("Rocznik:{0} ", rocznik);
            Console.WriteLine("Pojemność:{0} ", pojemnosc);
            Console.WriteLine("Moc:{0} ", moc);
            Console.WriteLine("Przebieg:{0} ", przebieg);
            Console.WriteLine("Typ skrzyni biegów:{0} ", biegi);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("---------------------------");
            Console.ResetColor();
        }


        public static void Dodaj_auto()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Dodaj nowe auto do katalogu");
            Console.WriteLine("  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Podaj marke:");
            marka = Console.ReadLine();
            Console.WriteLine("Podaj model:");
            model = Console.ReadLine();
            Console.WriteLine("Podaj silnik [benzyna / diesel / LPG]:");
            silnik = Console.ReadLine();
            Console.WriteLine("Podaj rocznik [RRRR]:");
            rocznik = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pojemność [ccm]:");
            pojemnosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj moc [KM]:");
            moc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj przebieg [km]:");
            przebieg = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj typ skrzyni biegów [maual / automat]:");
            biegi = Console.ReadLine();

            Auto noweAuto = new Auto(marka, model, silnik, rocznik, pojemnosc, moc, przebieg, biegi);
            lista0.Add(noweAuto);
        }


        public static void Usun_auto()
        {
            int nr_usu;
            do
            {
                Console.WriteLine("Podaj numer samochodu do usunięcia: ");
                nr_usu = Convert.ToInt32(Console.ReadLine());
                lista0.RemoveAt(nr_usu - 1);        //?
                if (nr_usu < 0 || nr_usu > lista0.Count)
                {
                    Console.WriteLine("Nieprawidłowy numer");

                }
            } while (nr_usu > 0 && nr_usu < lista0.Count);
            Console.WriteLine("Usunięto auto nr {0}", nr_usu);
        }


    }
}