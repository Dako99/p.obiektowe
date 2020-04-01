#include "auta0.h"

using namespace std;


//metody:

bool Auto::wczytaj() {		//wczytuje dane z pliku
	fstream plik;
	plik.open("Baza.txt", fstream::in);
	if (plik.good() == false) {
		cout << "Nie udalo sie otworzyc pliku!";
		exit(0);
	}
	int nr_linii = (nr_auta - 1) * 8 + 1;
	int aktualny_nr = 1;
	string linia;

	while (getline(plik, linia)) //(skad,gdzie) 0=nie udało sie pobrac
	{		
		if (aktualny_nr == nr_linii)	 ;
		if (aktualny_nr == nr_linii + 1) marka = linia;
		if (aktualny_nr == nr_linii + 2) model = linia;
		if (aktualny_nr == nr_linii + 3) silnik = linia;
		if (aktualny_nr == nr_linii + 4) rocznik = atoi(linia.c_str());
		if (aktualny_nr == nr_linii + 5) pojemnosc = atoi(linia.c_str());
		if (aktualny_nr == nr_linii + 6) moc = atoi(linia.c_str());
		if (aktualny_nr == nr_linii + 7) przebieg = atoi(linia.c_str());
		if (aktualny_nr == nr_linii + 8) biegi = linia;
		aktualny_nr++;
	}
	if (!plik.eof() == 1) return true;
	plik.close();
}

void Auto::zapisz() {		//zapisuje dane do pliku
	fstream plik;
	plik.open("Baza.txt", fstream::out | fstream::app);

	int d = 0;
	//plik << "add" << d++ << endl;
	plik << marka << endl;
	plik << model << endl;
	plik << silnik << endl;
	plik << rocznik << endl;
	plik << pojemnosc << endl;
	plik << moc << endl;
	plik << przebieg << endl;
	plik << biegi << endl;

	plik.close();

}

//void Auto::kasuj() { }


void Auto::przepisz() {		//przepisuje dane do konsoli
	cout << "---------------------------" << endl;
	cout << "Marka: " << marka << endl;
	cout << "Model: " << model << endl;
	cout << "Silnik: " << silnik << endl;
	cout << "Rocznik: " << rocznik << endl;
	cout << "Pojemność: " << pojemnosc << endl;
	cout << "Moc: " << moc << endl;
	cout << "Przebieg: " << przebieg << endl;
	cout << "Typ skrzyni biegów: " << biegi << endl;
	cout << "---------------------------" << endl << endl;
}

void Auto::dodaj_auto() {		//dodawanie nowego auta
	cout << "Dodaj nowe auto do katalogu:" << endl;
	cout << "Podaj marke:" << endl;
	cin >> marka;
	cout << "Podaj model:" << endl;
	cin >> model;
	cout << "Podaj silnik [benzyna / diesel / LPG]:" << endl;
	cin >> silnik;
	
	while ((cout << "Podaj rocznik [RRRR]:" << endl)
		&& (!(cin >> rocznik) || rocznik < 1885 || rocznik > 2022)) {
		cout << "To nie jest prawidłowa data" << endl;
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	} //zabezpieczenie przed nieprawidłowym rokiem
	
	while ((cout << "Podaj pojemność [ccm]:" << endl)
		&& (!(cin >> pojemnosc) || pojemnosc < 1 || pojemnosc > 20000)) {
		cout << "To nie jest prawidłowa pojemność" << endl;
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	} //zabezpieczenie przed nieprawidłową pojemnością

	while ((cout << "Podaj moc [KM]:" << endl)
		&& (!(cin >> moc) || moc < 1 || moc > 2000)) {
		cout << "To nie jest prawidłowa moc" << endl;
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	} //zabezpieczenie przed nieprawidłową mocą

	while ((cout << "Podaj przebieg [km]:" << endl)
		&& (!(cin >> przebieg) || przebieg < 0 || przebieg > 3000000)) {
		cout << "To nie jest prawidłowy przebieg" << endl;
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	} //zabezpieczenie przed nieprawidłowym przebiegiem

	cout << "Podaj typ skrzyni biegów: [manual / automat]" << endl;
	cin >> biegi;

}
Auto::Auto() {}
/*Auto::Auto(string ma, string mo, int si, int ro, int po, int mc, int prz, string bi) {

	marka = ma;
	model = mo;
	silnik = si;
	rocznik = ro;
	moc = mc;
	przebieg = prz;
	biegi = bi;
}
*/
/*
Auto::~Auto() {
	cout << "Czy ja mam co sprzątać?" << endl;;
}
*/

//void pow_sto_km() { if (moc >= 100) cout << ; }
