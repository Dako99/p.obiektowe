#include <cstdlib> //exit
#include <vector>
#include <algorithm> //quicksort
#include <functional> //quicksort
#include "auta0.h"

using namespace std;



int main() {
	setlocale(LC_ALL, "polish");  //Visual Studio

	string marka;
	string model;
	string silnik;
	int rocznik;			//int
	int pojemnosc;			//int
	int moc;				//int
	int przebieg;			//int
	string biegi;

	//Auto* samochody = new Auto();

	Auto a[30];				//tablica obiektów
	//Auto b[8] = { 11, 2, 29, 7, 1, 22, 16, 4 };

	bool wczytaj();			//wczytuje dane z pliku
	void zapisz();			//zapisuje dane do pliku
	void przepisz();		//przepisuje dane do konsoli
	void dodaj_auto();		//dodawanie nowego auta


	bool z = true;
	vector <Auto> d;


	for (;;)
	{
		cout << "MENU GŁÓWNE" << endl;
		cout << "1. Dodaj nowe auto" << endl;
		cout << "2. Przeglądaj cały katalog" << endl;
		cout << "3. Szukaj auta po ID" << endl;
		cout << "4. //Usuwanie aut" << endl;
		cout << "5. /Sorotowanie" << endl;
		cout << "  " << endl;


		cout << "9. Koniec programu  " << endl;
		cout << "0. Back" << endl << endl;

		int wybor;

		while ((cout << "go to:" << endl)
			&& (!(cin >> wybor) || wybor < 0 || wybor > 10)) {
			cout << "Nie ma takiej opcji w menu!" << endl;
			cin.clear();
			cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		} //zabezpieczenie przed nieprawidłowym wyborem

		switch (wybor) {
		case 1:
		{
			Auto samochody;
			cout << endl << endl << endl; //system("cls");

			int n;
			while ((cout << "Ile samochodow chcesz dodac" << endl)
				&& (!(cin >> n) || n < 0 || n > 100)) {
				cout << "Nieprawidłowa liczba" << endl;
				cin.clear();
				cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			} //zabezpieczenie przed nieprawidłową ilością

			for (int i = 1; i <= n; i++) {
				samochody.dodaj_auto();
				samochody.zapisz();
				samochody.przepisz();
			}

			system("PAUSE");
			cout << endl << endl << endl; //system("cls");
			break;
		}

		case 2:
			//...
			cout << endl << endl << endl; //system("cls");

			/*
			while (z) {
				for (int i = 0; i <= 15; i++) { //do duzej zmiany
					a[i].nr_auta = i + 1;
					a[i].wczytaj();
					a[i].przepisz();
					Auto temp;
					z = temp.wczytaj();
					if (z)d.push_back(temp);
				}
			}
			*/

			for (int i = 0; i <= 13; i++) { //do zmiany
				a[i].nr_auta = i + 1;
				a[i].wczytaj();
				a[i].przepisz();
			}
			int i;

			cout << "Nacisnij 0 aby wrócić" << endl;
			cin >> i;
			if (i == 0) {
				cout << endl << endl << endl;
				break;
			}

		case 3:{
			cout << endl << endl << endl; //system("cls");
			int id;
			while (1)
			{
				cout << "Podaj ID samochodu" << endl;
				cout << "Nacisnij 0 aby wrócić" << endl;
				cin >> id;
				if (id == 0) {
					cout << endl << endl << endl;
					break;
				}
				a[id].nr_auta = id;
				a[id].wczytaj();
				a[id].przepisz();
				cout << endl;
			}
		}
		case 4:
			cout << endl << endl << endl; //system("cls");
			//read
			//move to temp
			//remove
			//move temp to org

			break;

		case 5: {
			cout << "Wybór parametru do posortowania" << endl;
			cout << "1. Marka" << endl;
			cout << "2. Model" << endl;
			cout << "3. Silnik" << endl;
			cout << "4. Rocznik" << endl;
			cout << "5. Pojemność" << endl;
			cout << "6. Moc" << endl;
			cout << "7. Przebieg" << endl;
			cout << "8. Typ skrzyni biegów" << endl;
			cout << "  " << endl;

			int wybor1;

			while ((cout << "go to:" << endl)
				&& (!(cin >> wybor1) || wybor1 < 0 || wybor1 > 10)) {
				cout << "Nie ma takiej opcji w menu!" << endl;
				cin.clear();
				cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			} //zabezpieczenie przed nieprawidłowym wyborem

			switch (wybor1) {
			case '1':
				//sort(rejestr.begin(), rejestr.end(), Pojazd::poMarce);
				cout << "Posortowano" << endl;
				break;
			case '2':
				//sort(rejestr.begin(), rejestr.end(), Pojazd::poModelu);
				cout << "Posortowano" << endl;
				break;
			case '3':
				//sort(rejestr.begin(), rejestr.end(), Pojazd::poRoczniku);
				cout << "Posortowano" << endl;
				break;
			case '4':
				//sort(rejestr.begin(), rejestr.end(), Pojazd::poPojemnosci);
				cout << "Posortowano" << endl;
				break;
			case '5':
				//sort(rejestr.begin(), rejestr.end(), Pojazd::poPrzebiegu);
				cout << "Posortowano" << endl;
				break;
			case '6':
				//sort(rejestr.begin(), rejestr.end(), Pojazd::poSkrzyni);
				cout << "Posortowano" << endl;
				break;

			default:
				cout << endl << endl << endl; //system("cls");
				cout << "Nieprawidlowo wybrano parametr" << endl;
			}
			cout << endl << endl << endl; //system("cls");
			break;
		}

		case 9:
			exit(0);
			break;
		case 0:
			cout << endl << endl << endl; //system("cls");
			main();
			break;

		default:
			cout << endl << endl << endl; //system("cls");
			cout << "Nie ma takiej opcji w menu!" << endl;

		}

	}

	return 0;
}

// z zajeć

/* int main1() {
	int a = 3;
	cout << "Hello" << "!" << "\n";
	cout << a;
	int zmienna;
	cin >> zmienna;
	cout << zmienna <<"\n";
	system("pause"); //sys czeka na nacisniecie klawisza

}*/


/* void witaj() {
	cout << "Witaj świecie" << endl; //ś = \230
}
int suma(int a, int b) {
	return a + b;
}
int main2() {
	setlocale(LC_ALL, "polish");
	witaj();
	cout << endl;
	cout << suma(4, 3);
}*/


/*
//Podejście proceduralne

int a = 3;
struct punkt_1 { //auto
	int x; //<zmienne aut
	int y; //<
};
// dodać licznik by dodać do tablicy lub przed przed przypisaniem sprawdzić wielość tab
//tab [10]
void wyswietl(struct punkt_1 p) {
	cout << "Punkt to: " << "x=" << p.x << " y=" << p.y << endl;
}

int main() {
	punkt_1 b;
	b.x = 1;
	b.y = 2;
	punkt_1 c = { 0,0 };
	cout << a << b.x << b.y << endl;
	cout << c.x << c.y << endl;
	wyswietl(b);
	punkt_1 spis[100];
}
*/

/*
//Podejście obiektowe
int a = 3;
//[class nazwa {public:... ,private:... ,protected:...};]
class punkt_2 {
public:
	int x, y;

	void dodaj() {
		cin >> x >> y; //metoda wewnątrz ciała danej klasy
	}
	void wyswietl() {
		cout << x << y;
	}
};

	int main() {
		punkt_2 a;
		a.x = 1; //<wywali bo domyślnie sa prywatne
		a.y = 2; //<
		a.dodaj();
		a.wyswietl();
		punkt_2 tab[100];
	}
	*/

	/* //Konstruktor
	class punkt_2 {
		int x, y;
	public:
		/*punkt_2() {			  //(I)
			x = 0;
			y = 0;
		}

		punkt_2() : x(2),y(2){} //(II) lista inicjacyjna

		punkt_2(int wsp_x, int wsp_y): x(wsp_x), y(wsp_y){} //(III)
		// punkt operator + (punkt_2 a , punkt_2 b)
		// {return punkt(a.x + b.x, a.y + b.x);}
		// return zapis, odczyt
		//~punkt_2() {}; //dekonstruktor

		void wyswietl() {
			cout << x << y;
		}
	};

		int main() {
			punkt_2 a(2,2);
			a.wyswietl();
			punkt_2 b(8,8);
			b.wyswietl();
			~punkt_2() {}; //dekonstruktor
		}
		*/

		/*//#include <vector>
		int main() {
			...
			vector <punkt2> spis;
			spis.push_back(a);
			spis[0].wyswietl();
		}punkt.2 c = a + b;
		}
		*/

		/* //Przeciążenie
		punkt_2 operator + (punkt_2a, punkt_2b) {
			return punkt_2(a.x + a.x, a.y + b.y)
		}
		*/

		/* dane
		void zapisz(string dane) {
			fstream plik;
			plik.open("baza.txt, fstream::out");
				plik << dane;
			plik.close();
			}
		string odczyt() { //proceduralnie
			fstream plik;
			plik.open("baza.txt")(fstream::in);
				if (plik.isopen()!=false) {
					string dane;
					plik >> dane;
				}
			plik.close();
			return dane;
		}
		*/
