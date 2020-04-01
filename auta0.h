#include <iostream>
#include <stdio.h>
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

	//metody
public:
	Auto();               //konstruktor
	//??? Auto(string marka, string model, string silnik, int rocznik, int pojemnosc, int moc, int przebieg, string biegi)
	//~Auto();              //dekonstruktor
	bool wczytaj();       //wczytuje dane z pliku
	void zapisz();        //zapisuje dane do pliku
	//void kasuj();         //usuwa dane z pliku
	void przepisz();      //przepisuje dane do konsoli
	void dodaj_auto();    //dodawanie nowego auta
	//void sortowanie();    //sortowanie wed³ug parametru

};

