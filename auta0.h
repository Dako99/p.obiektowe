#include <iostream>
#include <stdio.h>
#include <fstream> //ob³suga pliku .txt
#include <string>


using namespace std;

class Auto {

    //atrybuty
public:
    string marka;
    string model;
    string silnik;
    int rocznik;          //int
    int pojemnosc;        //int
    int moc;              //int
    int przebieg;         //int
    string biegi;

public:
    int nr_auta;
    int d;

    //metody
public:
    Auto();               //konstruktor
    //~Auto();            //dekonstruktor
    bool wczytaj();       //wczytuje dane z pliku
    void zapisz();        //zapisuje dane do pliku
    //void kasuj();         //usuwa dane z pliku
    void przepisz();      //przepisuje dane do konsoli
    void dodaj_auto();    //dodawanie nowego auta

    Auto(string marka, string model, string silnik, int rocznik, int pojemnosc, int moc, int przebieg, string biegi)
    {
        this->marka = marka;
        this->model = model;
        this->silnik = silnik;
        this->rocznik = rocznik;         //int
        this->pojemnosc = pojemnosc;     //int
        this->moc = moc;                 //int
        this->przebieg = przebieg;       //int
        this->biegi = biegi;
    }

};

