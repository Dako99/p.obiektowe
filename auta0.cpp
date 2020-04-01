#include <fstream> //ob³suga pliku .txt
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

	while (getline(plik, linia)) //(skad,gdzie) 0=nie uda³o sie pobrac
	{
		if (aktualny_nr == nr_linii);
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
	cout << "Wczytano prawid³owowo" << endl;
	if (!plik.eof() == 1) return true;

	//if(marka != "" && model != "" && silnik != "" && rocznik != NULL && pojemnosc != NULL && moc != NULL && przebieg != NULL && biegi != "")
	//rejestr.push_back(*nowyPojazd);

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

/*
void Auto::kasuj() {

	int nrPojazdu;
	do {
		system("cls");
		std::cout << "Podaj nr pojazdu do usuniecia: ";
		std::cin >> nrPojazdu;
		if (nrPojazdu > rejestr.size() || nrPojazdu <= 0)
		{
			std::cout << "Nie ma takiego pojazdu w rejestrze!";
			system("pause");
		}
	} while (nrPojazdu > rejestr.size() || nrPojazdu <= 0);
	rejestr.erase(rejestr.begin() + nrPojazdu - 1);
	std::cout << "Poprawnie usunieto pojazd nr " << nrPojazdu << std::endl;
	system("pause");

}
*/


void Auto::przepisz() {		//przepisuje dane do konsoli
	cout << "---------------------------" << endl;
	cout << "Marka: " << marka << endl;
	cout << "Model: " << model << endl;
	cout << "Silnik: " << silnik << endl;
	cout << "Rocznik: " << rocznik << endl;
	cout << "Pojemnoœæ: " << pojemnosc << endl;
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
		cout << "To nie jest prawid³owa data" << endl;
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	} //zabezpieczenie przed nieprawid³owym rokiem

	while ((cout << "Podaj pojemnoœæ [ccm]:" << endl)
		&& (!(cin >> pojemnosc) || pojemnosc < 1 || pojemnosc > 20000)) {
		cout << "To nie jest prawid³owa pojemnoœæ" << endl;
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	} //zabezpieczenie przed nieprawid³ow¹ pojemnoœci¹

	while ((cout << "Podaj moc [KM]:" << endl)
		&& (!(cin >> moc) || moc < 1 || moc > 2000)) {
		cout << "To nie jest prawid³owa moc" << endl;
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	} //zabezpieczenie przed nieprawid³ow¹ moc¹

	while ((cout << "Podaj przebieg [km]:" << endl)
		&& (!(cin >> przebieg) || przebieg < 0 || przebieg > 3000000)) {
		cout << "To nie jest prawid³owy przebieg" << endl;
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	} //zabezpieczenie przed nieprawid³owym przebiegiem

	cout << "Podaj typ skrzyni biegów: [manual / automat]" << endl;
	cin >> biegi;

}

//void Auto::sortowanie() {
//QuickSort
			/*
			sort(b, b + 8);

			cout << endl << "Tablica a posortowana rosn¹co:" << endl;
			for (int i = 0; i < 8; i++) cout << b[i] << endl;

			sort(b, b + 8, greater < int >());

			cout << endl << "Tablica a posortowana malej¹co:" << endl;
			for (int i = 0; i < 8; i++) cout << b[i] << endl;

			cout << "Nacisnij 0 aby wróciæ" << endl;
			cin >> id;
			if (id == 0) {
				cout << endl << endl << endl;
				break;
			}
		}
			*/

//konstruktor [zawsze]
//domniemamy
Auto::Auto() {}

//Auto(string marka, string model, string silnik, int rocznik, int pojemnosc, int moc, int przebieg, string biegi)
	//{
	//    this->marka = marka;
	//    this->model = model;
	//    this->silnik = silnik;
	//    this->rocznik = rocznik;         //int
	//    this->pojemnosc = pojemnosc;     //int
	//    this->moc = moc;                 //int
	//    this->przebieg = przebieg;       //int
	//    this->biegi = biegi;
	//}


//destruktor
/*
Auto::~Auto() {
	cout << "Czy ja mam co sprz¹taæ?" << endl;;
}
*/

//void pow_sto_km() { if (moc >= 100) cout << ; }
