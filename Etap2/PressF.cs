using System;
using System.Collections.Generic;
using System.Text;
using System.IO; //obsługa plików

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


        //metody

        public static bool Wczytaj()        //wczytuje dane z pliku
        {
            //Console.WriteLine("GetFullPath('Baza.txt') returns '{0}'", Path.GetFullPath("Baza.txt"));

            if (File.Exists("Baza.txt"))
            {//System.IO. ????
                FileStream plik = new FileStream("Baza.txt", FileMode.Open, FileAccess.Read);
                StreamReader strumienOdczytu = new StreamReader("Baza.txt");

                int nr_linii = (nr_auta - 1) * 8 + 0; //do zmiany
                int aktualny_nr = 1;
                string linia;

                while ((linia = strumienOdczytu.ReadLine()) != null) //?????????
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
                    aktualny_nr++;
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
            //Console.WriteLine("Wczytano prawidłowowo"); //może jakis if?
        }



        public static void Zapisz()         //zapisuje dane do pliku
        {

            FileStream plik = new FileStream("Baza.txt", FileMode.Append, FileAccess.Write);
            //plik.Seek(0, SeekOrigin.End);
            StreamWriter strumienZapisu = new StreamWriter(plik);

            strumienZapisu.WriteLine("add");
            strumienZapisu.WriteLine(marka);
            strumienZapisu.WriteLine(model);
            strumienZapisu.WriteLine(silnik);
            strumienZapisu.WriteLine(rocznik);
            strumienZapisu.WriteLine(pojemnosc);
            strumienZapisu.WriteLine(moc);
            strumienZapisu.WriteLine(przebieg);
            strumienZapisu.WriteLine(biegi);


            strumienZapisu.Close();
            plik.Close();

            //Rejestr.lista.RemoveRange(0, Rejestr.lista.Count());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine("Zapisano!");
            Console.ResetColor();

        }


        public static void Przepisz()
        {       //przepisuje dane do konsoli
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

        }


    }
}

