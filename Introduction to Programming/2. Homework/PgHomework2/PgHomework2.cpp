/**************************
**	SAKARYA UNIVERSITY
**	BILGISAYAR MUHENDISLIGI BOLUMU
**	PROGRAMLAMAYA GIRIS
**
**	ÖĞRENCİ ADI......: METEHAN DÜNDAR	
**	ÖĞRENCİ NUMARASI.: G211210031	
**	DERS GRUBU…………………: A
**************************/

#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <Windows.h>

using namespace std;

HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE); // Renklerin ekranda gozukmesi icin gerekli fonksiyon.

enum RENKLER // Renk kodlari
{
	LIGHTBLUE = 9,
	LIGHTGREEN = 10,
	LIGHTCYAN = 11,
	LIGHTRED = 12,
	LIGHTMAGENTA = 13,
	YELLOW = 14,
};

class Karakter {
public:
	int renk;
	char harf;

	Karakter() { // Karakter sinifindan olusturulan kurucu fonksiyon.
	}
};

class Katar {
public:
	Katar() { // Katar sinifindan olusturulan kurucu fonksiyon.
		Karaktersayisi = 0;
	}

	void karakterEkle() {
		if (Karaktersayisi < 50) {
			RENKLER renk = RENKLER((rand() % 6) + 9); // Renklerin rastgele secilmesi saglandi.
			karakterler[Karaktersayisi] = Karakter();
			karakterler[Karaktersayisi].renk = renk;
			karakterler[Karaktersayisi].harf = (rand() % 25) + 65; // Karakterlerin rastgele secilmesi saglandi.
			Karaktersayisi++;
		}
		else {
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 12); // Ekleme yapilmaz yazisinin kirmizi gozukmesi icin gerekli.
			cout << "Ekleme Yapilamaz" << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7);  // Yazilari tekrardan default renk(beyaz) yapmak için gerekli.
		}
	}
	void KarakterCikar() {
		if (Karaktersayisi <= 0) {
			cout << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 12);  // Cikarma yapilmaz yazisinin kirmizi gozukmesi icin gerekli.
			cout << "Cikarma Yapilamaz" << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7);   // Yazilari tekrardan default renk(beyaz) yapmak için gerekli.
		}
		else {
			karakterler[--Karaktersayisi] = karakterler[50]; // Çikarilan Karakterin degeri dizideki bos bir karakterin degerine atandi (sifira).
		}
	}

	void HucreYazdir() { 
		int karaktersayisi = 0;
		if (Karaktersayisi <= 0) { // En basta bos kutu yazdirmamizi saglayan kosul. 
			cout << endl << "Karakter Sayisi: 0" << endl;
			cout << SOLUSTKOSE << DUZCIZGI << DUZCIZGI << SAGUSTKOSE << endl;
			cout << DIKEYCIZGI << " " << " " << DIKEYCIZGI << endl;
			cout << SOLALTKOSE << DUZCIZGI << DUZCIZGI << SAGALTKOSE << endl;
		}
		else if (Karaktersayisi < 51) { 
			cout << SOLUSTKOSE;
			// Cizgilerin olusturulmasi karakter sayisina baglı oldugu icin for dongusu kullanildi.
			for (int i = 0; i < Karaktersayisi; i++) {
				cout << DUZCIZGI << DUZCIZGI << DUZCIZGI << ASAGIAYRAC;
			}
			
			cout << endl;

			for (int i = 0; i < Karaktersayisi; i++) {
				cout << DIKEYCIZGI << " ";
				SetConsoleTextAttribute(hConsole, karakterler[i].renk);
				cout << karakterler[i].harf << " ";
				SetConsoleTextAttribute(hConsole, 15);
			}

			cout << DIKEYCIZGI << endl << SOLALTKOSE;

			for (int i = 0; i < Karaktersayisi; i++) {
				cout << DUZCIZGI << DUZCIZGI << DUZCIZGI << YUKARIAYRAC;
			}
		}
		else {
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 12); // Cikarma yapilmaz yazisinin kirmizi gozukmesi icin gerekli.
			cout << "Ekleme Yapilamaz" << endl;
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7);  // Yazilari tekrardan default renk(beyaz) yapmak için gerekli.
		}
	}

private:                      // Gerekli karakter kodlari.
	int Karaktersayisi=0;     
	char DUZCIZGI = 205;
	char SOLUSTKOSE = 201;
	char SAGUSTKOSE = 187;
	char DIKEYCIZGI = 186;
	char ASAGIAYRAC = 203;
	char SOLALTKOSE = 200;
	char SAGALTKOSE = 188;
	char YUKARIAYRAC = 202;
	Karakter karakterler[50]; // 50 elemanlı bir karakterler dizisi olusturuldu.
};

int main()

{
	int Secim;

	srand(time(NULL));
	Katar* dizi = new Katar(); // Katar sinifindan adres tutan dizi nesnesi olusturuldu (pointer).

	// Ana menü
	for (int Karaktersayisi = 0; Karaktersayisi <= 50; Karaktersayisi++) { // Karakter sayisi tanimlandi ve ekrana bastirmak icin donguye alindi.
		while (Karaktersayisi <= 50) { 
			cout << "Islem seciniz." << endl;
			cout << "1-Karakter Ekle\n2-Karakter Cikar\n3-Programdan Cikis\nSecim :";
			cin >> Secim;

			switch (Secim) {
			case 1:
				cout << "Onceki Durum:" << "-" << " Karakter Sayisi: " << Karaktersayisi << endl;
				dizi->HucreYazdir();
				cout << endl;
				dizi->karakterEkle();
				cout << endl;
				if (Karaktersayisi < 50) { // Karaktersayisini durumun yaninda gösterirken sadece 50 ye kadar arttirmak icin if blogu acildi.
					Karaktersayisi++;
				}
				cout << "Sonraki Durum:" << "-" << " Karakter Sayisi: " << Karaktersayisi << endl;
				dizi->HucreYazdir();
				cout << endl << endl;
				break;
			case 2:
				cout << "Onceki Durum:" << "-" << " Karakter Sayisi: " << Karaktersayisi << endl;
				dizi->HucreYazdir();
				cout << endl;
				dizi->KarakterCikar();
				cout << endl;
				if (Karaktersayisi > 0) { // Karaktersayisini durumun yaninda gösterirken sadece 0 a kadar azaltmak icin if blogu acildi.
					Karaktersayisi--;
				}
				cout << "Sonraki Durum:" << "-" << " Karakter Sayisi:" << Karaktersayisi << endl;
				dizi->HucreYazdir();
				cout << endl << endl;
				break;
			case 3:
				delete dizi;
				return 0;
			default:
				SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 12);
				cout << endl << "Lutfen Menudeki seceneklerden birini seciniz." << endl << endl;
				SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 7);
				break;
				Karaktersayisi++;
			}
		}
	}
	return 0;
}