using System;
using System.Collections.Generic;
using System.Text;

namespace Etap2_Katalog
{
    public class Auto
    {
        //atrybuty
        public string marka;
        public string model;
        public string silnik;
        public int rocznik;
        public int pojemnosc;
        public int moc;
        public int przebieg;
        public string biegi;

        public static int nr_auta;


        //przeciazenie / przepełnienie operatora
        //public string Nazwa { get; set; }
        //public override string ToString()
        //{
        //    return Nazwa;
        //}
        // // Nazwa = marka;

        //konstruktor domyślny 

        //public Auto()
        //{
        //    marka = "nieznany";
        //    model = "nieznany";
        //    rocznik = 0000;
        //    pojemnosc = 0;
        //    moc = 0
        //    przebieg = 0;
        //    biegi = "nieznana";
        //}

        //konstruktor narzucony
        public Auto(string _marka, string _model, string _silnik, int _rocznik, int _pojemnosc, int _moc, int _przebieg, string _biegi)
        {
            
            marka = _marka;
            model = _model;
            silnik = _silnik;
            rocznik = _rocznik;         //int
            pojemnosc = _pojemnosc;     //int
            moc = _moc;                 //int
            przebieg = _przebieg;       //int
            biegi = _biegi;
        }
        //destruktor
        ~Auto() { }

        public void Wypisz()
        {
            System.Console.WriteLine(marka, model, silnik, rocznik, pojemnosc, moc, przebieg, biegi);
        }


    }
}