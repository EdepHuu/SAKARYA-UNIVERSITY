/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          PROGRAMLAMAYA GİRİŞİ DERSİ
**
**				ÖDEV NUMARASI…...:
**				ÖĞRENCİ ADI...............: Metehan Dündar
**				ÖĞRENCİ NUMARASI.: G211210031
**				DERS GRUBU…………: A
****************************************************************************/

#define _CRT_SECURE_NO_WARNINGS // Hızlı bir düzeltme veya test yapmak için, sadece #include'den önce dosyanın üstüne #define _CRT_SECURE_NO_WARNINGS eklemeyi kullanışlı buluyorum.
// Kütüphaneleri çağırdım.
#include <cstdlib>
#include <fstream>
#include <iostream> 
#include <string>
#include <stdlib.h>
#include <ctime>
#include <locale.h>
#include <math.h>
#include <conio.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Turkish");
	string Ürün_Kodu;
	string Sorgu_Ürün_Kodu;
	string Sorgu_Ürün_Koduu;
	string Ürün_Adı;
	string Üreticisi;
	string Temin_Süresi;
	string Üretim_Tarihi_Yıl;
	double Fiyat;
	double Fiyat2;
	string Kdv_Oranı;
	unsigned int Stok_Adedi;
	unsigned int Yeni_Stok_Adedi;
	string Firma_No;
	string Sorgu_Firma_No;
	string Firma_Adı;
	string Firma_Telefon;
	string Firma_Sorumlusu;
	string Müşteri_Kategorisi;
	string Adres;
	string Sipariş_Numarası;
	string Sorgu_Sipariş_Numarası;
	string Sipariş_Tarihi;
	double Sipariş_Adedi;
	double Sipariş_Tutarı;
	string Sipariş_Listesi_Dosyası;
	string Siparişi_Alan;

	char cevap = 'e';
	int secim;
	int secim2;
	int secim3;
	int secim4;

	do //Sadece ekranda verilen seçeneklerden herhangi biri seçilsin diye do while döngüsü kullandım.
	{
		cout << endl;
		cout << "    ~~~~~~~~~~HOŞGELDİNİZ~~~~~~~~~~" << endl << endl;
		cout << " İşlem yapmak istediğinz Dosyayı seçin. " << endl; //Ana Menü.
		cout << endl;
		cout << "1) ÜRÜN " << endl;
		cout << "2) MÜŞTERİ " << endl;
		cout << "3) SİPARİŞ " << endl;
		cout << endl;
		cin >> secim;
		cout << endl;

	} while (secim != 1 && secim != 2 && secim != 3);

	if (secim == 1) // Seçenek 1 ise if bloğuna girmesini sağladım.
	{
		do //Sadece ekranda verilen seçeneklerden herhangi biri seçilsin diye do while döngüsü kullandım.
		{
			cout << "Yapmak istediğiniz işlemi seçin." << endl << endl;
			cout << "1-) Ürün Ekleme" << endl;
			cout << "2-) Ürün Arama" << endl;
			cout << "3-) Ürün Listeleme" << endl;
			cout << "4-) Ürün Düzeltme" << endl;
			cout << "5-) Ürün Silme" << endl;
			cout << endl;
			cin >> secim2;
			cout << endl;
		} while (secim2 != 1 && secim2 != 2 && secim2 != 3 && secim2 != 4 && secim2 != 5);

		if (secim2 == 1) // Seçilen seçenek 1 ise if bloğuna girmesini sağladım.
		{
			ofstream Ürün_bilgileri_yaz; // Dosya çıkışı yapmak için gerekli kod.
			Ürün_bilgileri_yaz.open("urun.txt", ios::app); // urun.txt dosyasını açtım.
			do //Sadece ekranda verilen seçeneklerden herhangi biri seçilsin diye do while döngüsü kullandım.
			{
				cout << " Eklenecek olan ürünün bilgilerini giriniz." << endl; // Ürün bilgilerini aldım.
				cout << "\n Ürün Kodu         :"; cin >> Ürün_Kodu;
				cout << "\n Ürün Adı          :"; cin >> Ürün_Adı;
				cout << "\n Üretici           :"; cin >> Üreticisi;
				cout << "\n Temin Süresi(Gün) :"; cin >> Temin_Süresi;
				cout << "\n Üretim Tarihi(Yıl):"; cin >> Üretim_Tarihi_Yıl;
				cout << "\n Fiyat/genel(TL)   :"; cin >> Fiyat;
				cout << "\n Fiyat/ozel(TL)    :"; cin >> Fiyat2;
				cout << "\n Kdv Oranı(%)      :"; cin >> Kdv_Oranı;
				cout << "\n Stok Adedi        :"; cin >> Stok_Adedi;

				Ürün_bilgileri_yaz << endl << Ürün_Kodu << " " << Ürün_Adı << " " << Üreticisi << " " << Temin_Süresi << " " << Üretim_Tarihi_Yıl << " " << Fiyat << " " << Fiyat2 << " " << Kdv_Oranı << " " << Stok_Adedi; // Degerleri urun.txt dosyasına yazdırdım.
				cout << "\n baska kayit yapacak misin?(e/h) "; cin >> cevap;
			} while (!(cevap == 'h'));

			Ürün_bilgileri_yaz.close(); // Dosyayı kapadım.
			cout << endl << "ÜRÜN KAYIT İŞLEMİNİZ TAMAMLANMIŞTIR..." << endl;
			return main(); // programı main fonksiyonuna döndürdüm (en başa).


		}
		if (secim2 == 2) // Seçilen seçenek 2 ise if bloğuna girmesini sağladım.
		{
			system("cls");
			bool Kontrol = 0; // bool tanımladım ve 0 a eşitledim.
			cout << "              **ÜRÜN ARAMA**" << endl << endl;
			cout << "Aramak istediğiniz ürünün kodunu giriniz." << endl;
			cin >> Sorgu_Ürün_Kodu;
			ifstream Ürün_bilgileri_oku("urun.txt"); // urun.txt dosyasını okudum.

			while (!(Ürün_bilgileri_oku.eof()))  // urun.txt dosyasını baştan sona okuttum.
			{
				Ürün_bilgileri_oku >> Ürün_Kodu >> Ürün_Adı >> Üreticisi >> Temin_Süresi >> Üretim_Tarihi_Yıl >> Fiyat >> Fiyat2 >> Kdv_Oranı >> Stok_Adedi; // urun.txt dosyasına yazılan degerleri okuttum.

				if (Sorgu_Ürün_Kodu == Ürün_Kodu) // Sorgu ürün kodu , dosyada yazılan ürün kodu ile eşleşirse if bloğuna girmesini sağladım.
				{
					cout << endl;
					cout << "**ARAMAK İSTEDİĞİNİZ ÜRÜN BİLGİLERİ**" << endl;  // Aranan ürün bilgilerini ekrana bastırdım.
					cout << "\n Ürün Kodu         :"; cout << Ürün_Kodu;
					cout << "\n Ürün Adı          :"; cout << Ürün_Adı;
					cout << "\n Üretici           :"; cout << Üreticisi;
					cout << "\n Temin Süresi(Gün) :"; cout << Temin_Süresi;
					cout << "\n Üretim Tarihi(Yıl):"; cout << Üretim_Tarihi_Yıl;
					cout << "\n Fiyat/genel(TL)   :"; cout << Fiyat;
					cout << "\n Fiyat/ozel(TL)    :"; cout << Fiyat2;
					cout << "\n Kdv Oranı(%)      :"; cout << Kdv_Oranı;
					cout << "\n Stok Adedi        :"; cout << Stok_Adedi << endl;
					Kontrol = 1; // if bloğuna girip başarıyla tamamlamadan önce 1 e eşitledim, sondaki if bloğuna girmesin diye.
					break;
				}
			}	Ürün_bilgileri_oku.close(); // Dosyayı kapadım.
			if (Kontrol == 0)  // Sorgu ürün kodu , ürün kodunu tutmazsa cout ile bulunmadı yazdırmak için if bloğu açtım.
			{
				cout << "Girdiğiniz Koda ait bir ürün bulunamamıştır" << endl;
			}
			return main(); // programı main fonksiyonuna döndürdüm (en başa).
		}
		if (secim2 == 3) // Seçilen seçenek 3 ise if bloğuna girmesini sağladım.
		{
			system("cls");
			ifstream Ürün_bilgileri_oku("urun.txt"); // urun.txt dosyasını okudum.

			while (!(Ürün_bilgileri_oku.eof())) // urun.txt dosyasını baştan sona okuttum.

			{
				Ürün_bilgileri_oku >> Ürün_Kodu >> Ürün_Adı >> Üreticisi >> Temin_Süresi >> Üretim_Tarihi_Yıl >> Fiyat >> Fiyat2 >> Kdv_Oranı >> Stok_Adedi; // urun.txt dosyasına yazılan degerleri okuttum.
				cout << endl;
				cout << "**ÜRÜN LİSTESİ**" << endl;
				cout << "\n Ürün Kodu         :"; cout << Ürün_Kodu;  // Listelenmek istenen ürünlerin bilgilerini ekrana bastırdım.
				cout << "\n Ürün Adı          :"; cout << Ürün_Adı;
				cout << "\n Üretici           :"; cout << Üreticisi;
				cout << "\n Temin Süresi(Gün) :"; cout << Temin_Süresi;
				cout << "\n Üretim Tarihi(Yıl):"; cout << Üretim_Tarihi_Yıl;
				cout << "\n Fiyat/genel(TL)   :"; cout << Fiyat;
				cout << "\n Fiyat/ozel(TL)    :"; cout << Fiyat2;
				cout << "\n Kdv Oranı(%)      :"; cout << Kdv_Oranı;
				cout << "\n Stok Adedi        :"; cout << Stok_Adedi << endl;

			}Ürün_bilgileri_oku.close(); // Dosyayı kapadım.
			return main(); // programı main fonksiyonuna döndürdüm (en başa).
		}
		if (secim2 == 4) // Seçilen seçenek 4 ise if bloğuna girmesini sağladım.
		{
			string Sorgu_Ürün_Kodu;
			system("cls");

			cout << "              **ÜRÜN DÜZENLEME**" << endl << endl;

			ifstream Ürün_bilgileri_oku("urun.txt"); // urun.txt dosyasını okudum.
			ofstream Ürün_bilgileri_yaz("arkaplan.tmp"); // Arkaplanda bilgileri yazdırmak için geçici birdosya açtım.

			cout << "Düzenlemek istediğiniz ürünün kodunu giriniz." << endl;
			cin >> Sorgu_Ürün_Kodu;
			int kontrol = 0;
			while (!(Ürün_bilgileri_oku.eof())) // urun.txt dosyasını baştan sona okuttum.
			{
				Ürün_bilgileri_oku >> Ürün_Kodu >> Ürün_Adı >> Üreticisi >> Temin_Süresi >> Üretim_Tarihi_Yıl >> Fiyat >> Fiyat2 >> Kdv_Oranı >> Stok_Adedi; // urun.txt dosyasına yazılan degerleri okuttum.

				if (Sorgu_Ürün_Kodu == Ürün_Kodu) // Sorgu ürün kodu , dosyada yazılan ürün kodu ile eşleşirse if bloğuna girmesini sağladım.
				{
					cout << "**ÜRÜN DÜZENLENMEDEN ÖNCEKİ HALİ**" << endl << endl; // Ürünün bilgilerinin güncellenmeden önceki halini ekrana bastırdım.
					cout << "\n Ürün Kodu          :"; cout << Ürün_Kodu;
					cout << "\n Ürün Adı           :"; cout << Ürün_Adı;
					cout << "\n Üretici            :"; cout << Üreticisi;
					cout << "\n Temin Süresi(Gün)  :"; cout << Temin_Süresi;
					cout << "\n Üretim Tarihi(Y1ıl):"; cout << Üretim_Tarihi_Yıl;
					cout << "\n Fiyat/genel(TL)    :"; cout << Fiyat;
					cout << "\n Fiyat/ozel(TL)     :"; cout << Fiyat2;
					cout << "\n Kdv Oranı(%)       :"; cout << Kdv_Oranı;
					cout << "\n Stok Adedi         :"; cout << Stok_Adedi << endl << endl;
					cout << "**ÜRÜN DÜZENLEME EKRANI**" << endl;
					cout << "\n Ürün Kodu         :"; cin >> Ürün_Kodu; // Ürünün güncel bilgilerini aldım.
					cout << "\n Ürün Adı          :"; cin >> Ürün_Adı;
					cout << "\n Üretici           :"; cin >> Üreticisi;
					cout << "\n Temin Süresi(Gün) :"; cin >> Temin_Süresi;
					cout << "\n Üretim Tarihi(Yıl):"; cin >> Üretim_Tarihi_Yıl;
					cout << "\n Fiyat/genel(TL)   :"; cin >> Fiyat;
					cout << "\n Fiyat/ozel(TL)    :"; cin >> Fiyat2;
					cout << "\n Kdv Oranı(%)      :"; cin >> Kdv_Oranı;
					cout << "\n Stok Adedi        :"; cin >> Stok_Adedi;
					cout << "ÜRÜN DÜZENLEME İŞLEMİNİZ GERÇEKLEŞMİŞTİR..." << endl;

					Ürün_bilgileri_yaz << endl << Ürün_Kodu << " " << Ürün_Adı << " " << Üreticisi << " " << Temin_Süresi << " " << Üretim_Tarihi_Yıl << " " << Fiyat << " " << Fiyat2 << " " << Kdv_Oranı << " " << Stok_Adedi; // Degerleri urun.txt dosyasına yazdırdım.

					kontrol = 1;
				}
				else
				{
					Ürün_bilgileri_yaz << endl << Ürün_Kodu << " " << Ürün_Adı << " " << Üreticisi << " " << Temin_Süresi << " " << Üretim_Tarihi_Yıl << " " << Fiyat << " " << Fiyat2 << " " << Kdv_Oranı << " " << Stok_Adedi; // Degerleri urun.txt dosyasına yazdırdım.

				}


			}
			if (kontrol == 0)
			{
				cout << "Girdiğiniz koda ait ürün bulunmamaktadir." << endl;
			}
			Ürün_bilgileri_yaz.close(); // Dosyayı kapadım.
			Ürün_bilgileri_oku.close(); // Dosyayı kapadım.
			remove("urun.txt");  // urun.txt dosyasını sildim.
			rename("arkaplan.tmp", "urun.txt"); // arkaplanda olan degerleri yazığım geçici dosyanın adnı değiştim.

		}
		if (secim2 == 5) // Sseçilen seçenek 5 ise if bloğuna girmesini sağladım.
		{
			string Silinecek_Ürün_Kodu;
			system("cls");
			int kontrol = 0;
			cout << endl;
			cout << "              **ÜRÜN SİLME**" << endl << endl;

			ifstream Ürün_bilgileri_oku("urun.txt"); // urun.txt dosyasını okudum.
			ofstream Ürün_bilgileri_yaz("arkaplan.tmp"); // Arkaplanda bilgileri yazdırmak için geçici birdosya açtım.

			cout << "Silmek istediğiniz ürünün kodunu giriniz." << endl;
			cin >> Silinecek_Ürün_Kodu;
			while (!(Ürün_bilgileri_oku.eof())) // urun.txt dosyasını baştan sona okuttum.
			{
				Ürün_bilgileri_oku >> Ürün_Kodu >> Ürün_Adı >> Üreticisi >> Temin_Süresi >> Üretim_Tarihi_Yıl >> Fiyat >> Fiyat2 >> Kdv_Oranı >> Stok_Adedi; // urun.txt dosyasına yazılan degerleri okuttum.

				if (Silinecek_Ürün_Kodu == Ürün_Kodu) // Sorgu ürün kodu , dosyada yazılan ürün kodu ile eşleşirse if bloğuna girmesini sağladım.
				{
					cout << endl;
					cout << "**SİLİNECEK ÜRÜN BİLGİLERİ**" << endl;  // Silinecek ürün bilgilerini ekrana bastırdım.
					cout << "\n Ürün Kodu          :"; cout << Ürün_Kodu;
					cout << "\n Ürün Adı           :"; cout << Ürün_Adı;
					cout << "\n Üretici            :"; cout << Üreticisi;
					cout << "\n Temin Süresi(Gün)  :"; cout << Temin_Süresi;
					cout << "\n Üretim Tarihi(Y1ıl):"; cout << Üretim_Tarihi_Yıl;
					cout << "\n Fiyat/genel(TL)    :"; cout << Fiyat;
					cout << "\n Fiyat/ozel(TL)     :"; cout << Fiyat2;
					cout << "\n Kdv Oranı(%)       :"; cout << Kdv_Oranı;
					cout << "\n Stok Adedi         :"; cout << Stok_Adedi << endl << endl;
					cout << "ÜRÜN SİLME İŞLEMİNİZ GERÇEKLEŞMİŞTİR..." << endl;
					kontrol = 1;

				}
				else
				{
					Ürün_bilgileri_yaz << endl << Ürün_Kodu << " " << Ürün_Adı << " " << Üreticisi << " " << Temin_Süresi << " " << Üretim_Tarihi_Yıl << " " << Fiyat << " " << Fiyat2 << " " << Kdv_Oranı << " " << Stok_Adedi; // Degerleri urun.txt dosyasına yazdırdım.
				}
			}
			if (kontrol == 0)
			{
				cout << "Girdiğiniz koda ait ürün bulunmamaktadir." << endl;
			}

			Ürün_bilgileri_yaz.close(); // Dosyayı kapadım.
			Ürün_bilgileri_oku.close(); // Dosyayı kapadım.
			remove("urun.txt"); // urun.txt dosyasını sildim.
			rename("arkaplan.tmp", "urun.txt"); // arkaplanda olan degerleri yazığım geçici dosyanın adnı değiştim.

		}
	}
	if (secim == 2) // Seçenek 1 ise if bloğuna girmesini sağladım.
	{
		do //Sadece ekranda verilen seçeneklerden herhangi biri seçilsin diye do while döngüsü kullandım.
		{
			cout << "Yapmak istediğiniz işlemi seçin." << endl << endl;
			cout << "1-) Müşteri Ekleme" << endl;
			cout << "2-) Müşteri Arama" << endl;
			cout << "3-) Müşteri Listeleme" << endl;
			cout << "4-) Müşteri Düzeltme" << endl;
			cout << "5-) Müşteri Silme" << endl;
			cout << endl;
			cin >> secim3;
			cout << endl;
		} while (secim3 != 1 && secim3 != 2 && secim3 != 3 && secim3 != 4 && secim3 != 5);
		if (secim3 == 1) // Seçenek 1 ise if bloğuna girmesini sağladım.
		{
			ofstream Müşteri_bilgileri_yaz; // Dosya çıkışı yapmak için gerekli kod.
			Müşteri_bilgileri_yaz.open("cari.txt", ios::app); // cari.txt dosyasını açtım.
			do//Sadece ekranda verilen seçeneklerden herhangi biri seçilsin diye do while döngüsü kullandım.
			{
				cout << " Kaydedilcek müşteri bilgilerini giriniz." << endl; // Müşteri bilgilerini aldım.
				cout << "\n Firma No          :"; cin >> Firma_No;
				cout << "\n Firma Adı         :"; cin >> Firma_Adı;
				cout << "\n Firma Telefon     :"; cin >> Firma_Telefon;
				cout << "\n Firma Sorumlusu   :"; cin >> Firma_Sorumlusu;
				cout << "\n Müşteri Kategorisi(ozel/genel):"; cin >> Müşteri_Kategorisi;
				cout << "\n Adres             :"; cin >> Adres;

				Müşteri_bilgileri_yaz << endl << Firma_No << " " << Firma_Adı << " " << Firma_Telefon << " " << Firma_Sorumlusu << " " << Müşteri_Kategorisi << " " << Adres; // Degerleri cari.txt dosyasına yazdırdım.

				cout << "\n baska kayit yapacak misin?(e/h) "; cin >> cevap;
			} while (!(cevap == 'h'));
			Müşteri_bilgileri_yaz.close(); // Dosyayı kapadım.
			cout << endl << "MÜŞTERİ KAYIT İŞLEMİNİZ TAMAMLANMIŞTIR..." << endl;
			return main(); // programı main fonksiyonuna döndürdüm (en başa).

		}
		if (secim3 == 2) // Seçenek 2 ise if bloğuna girmesini sağladım.
		{
			system("cls");
			bool kontrol = 0;
			cout << "              **MÜŞTERİ ARAMA**" << endl << endl;
			cout << "Aramak istediğiniz Firma numarasını giriniz." << endl;
			cin >> Sorgu_Firma_No;
			ifstream Müşteri_bilgileri_oku("cari.txt"); // cari.txt dosyasını okudum.

			while (!(Müşteri_bilgileri_oku.eof()))  // cari.txt dosyasını baştan sona okuttum.
			{
				Müşteri_bilgileri_oku >> Firma_No >> Firma_Adı >> Firma_Telefon >> Firma_Sorumlusu >> Müşteri_Kategorisi >> Adres; // cari.txt dosyasına yazılan degerleri okuttum.

				if (Sorgu_Firma_No == Firma_No) // Sorgu firma no , dosyada yazılan firma no ile eşleşirse if bloğuna girmesini sağladım.
				{
					cout << endl;
					cout << "**ARAMAK İSTEDİĞİNİZ MÜŞTERİ BİLGİLERİ**" << endl; // Müşteri bilgilerini ekrana bastırdım.
					cout << "\n Firma Numarası    :"; cout << Firma_No;
					cout << "\n Firma Adı         :"; cout << Firma_Adı;
					cout << "\n Firma Telefonu    :"; cout << Firma_Telefon;
					cout << "\n Firma Sorumlusu   :"; cout << Firma_Sorumlusu;
					cout << "\n Müşteri Kategorisi:"; cout << Müşteri_Kategorisi;
					cout << "\n Adres             :"; cout << Adres << endl;
					kontrol = 1;
					break;
				}
			}Müşteri_bilgileri_oku.close(); // Dosyayı kapadım.
			if (kontrol == 0)
			{
				cout << "Girdiğiniz numaraya ait bir firma bulunamamıştır." << endl;
			}
			return main(); // programı main fonksiyonuna döndürdüm (en başa).
		}
		if (secim3 == 3) // Seçenek 3 ise if bloğuna girmesini sağladım.
		{
			system("cls");
			ifstream Müşteri_bilgileri_oku("cari.txt");  // cari.txt dosyasını okudum.

			while (!(Müşteri_bilgileri_oku.eof()))  // cari.txt dosyasını baştan sona okuttum.

			{
				Müşteri_bilgileri_oku >> Firma_No >> Firma_Adı >> Firma_Telefon >> Firma_Sorumlusu >> Müşteri_Kategorisi >> Adres; // cari.txt dosyasına yazılan degerleri okuttum.
				cout << endl;
				cout << "**MÜŞTERİ BİLGİLERİ**" << endl;
				cout << "\n Firma Numarası    :"; cout << Firma_No;
				cout << "\n Firma Adı         :"; cout << Firma_Adı;
				cout << "\n Firma Telefonu    :"; cout << Firma_Telefon;
				cout << "\n Firma Sorumlusu   :"; cout << Firma_Sorumlusu;
				cout << "\n Müşteri Kategorisi:"; cout << Müşteri_Kategorisi;
				cout << "\n Adres             :"; cout << Adres << endl;

			}Müşteri_bilgileri_oku.close(); // Dosyayı kapadım.
			return main(); // programı main fonksiyonuna döndürdüm (en başa).
		}
		if (secim3 == 4) // Seçenek 4 ise if bloğuna girmesini sağladım.
		{
			string Sorgu_Firma_No;
			system("cls");

			cout << "              **MÜŞTERİ DÜZENLEME**" << endl << endl;

			ifstream Müşteri_bilgileri_oku("cari.txt"); // cari.txt dosyasını okudum.
			ofstream Müşteri_bilgileri_yaz("arkaplan.tmp"); // Arkaplanda bilgileri yazdırmak için geçici birdosya açtım.

			cout << "Düzenlemek istediğiniz müşteri firma numarasını giriniz." << endl;
			cin >> Sorgu_Firma_No;
			int kontrol0 = 0;
			while (!(Müşteri_bilgileri_oku.eof()))  // cari.txt dosyasını baştan sona okuttum.
			{
				Müşteri_bilgileri_oku >> Firma_No >> Firma_Adı >> Firma_Telefon >> Firma_Sorumlusu >> Müşteri_Kategorisi >> Adres; // cari.txt dosyasına yazılan degerleri okuttum.

				if (Sorgu_Firma_No == Firma_No)  // Sorgu firma no , dosyada yazılan firma no ile eşleşirse if bloğuna girmesini sağladım.
				{
					cout << endl;
					cout << "**MÜŞTERİ BİLGİLERİNİN DÜZENLENMEDEN ÖNCEKİ HALİ**" << endl; // Müşteri bilgilerinin güncellenmeden önceki halini ekrana bastırdım.
					cout << "\n Firma Numarası    :"; cout << Firma_No;
					cout << "\n Firma Adı         :"; cout << Firma_Adı;
					cout << "\n Firma Telefonu    :"; cout << Firma_Telefon;
					cout << "\n Firma Sorumlusu   :"; cout << Firma_Sorumlusu;
					cout << "\n Müşteri Kategorisi:"; cout << Müşteri_Kategorisi;
					cout << "\n Adres             :"; cout << Adres << endl;
					cout << endl;
					cout << "**MÜŞTERİ DÜZZENLEME EKRANI**" << endl;   // Müşteri bilgilerinin güncellemek için güncel bilgileri aldım.
					cout << "\n Firma No          :"; cin >> Firma_No;
					cout << "\n Firma Adı         :"; cin >> Firma_Adı;
					cout << "\n Firma Telefon     :"; cin >> Firma_Telefon;
					cout << "\n Firma Sorumlusu   :"; cin >> Firma_Sorumlusu;
					cout << "\n Müşteri Kategorisi(ozel/genel):"; cin >> Müşteri_Kategorisi;
					cout << "\n Adres             :"; cin >> Adres;
					cout << endl;
					cout << "MÜŞTERİ DÜZENLEME İŞLEMİNİZ GERÇEKLEŞMİŞTİR..." << endl;

					Müşteri_bilgileri_yaz << endl << Firma_No << " " << Firma_Adı << " " << Firma_Telefon << " " << Firma_Sorumlusu << " " << Müşteri_Kategorisi << " " << Adres; // Degerleri cari.txt dosyasına yazdırdım.

					kontrol0 = 1;
				}
				else
				{
					Müşteri_bilgileri_yaz << endl << Firma_No << " " << Firma_Adı << " " << Firma_Telefon << " " << Firma_Sorumlusu << " " << Müşteri_Kategorisi << " " << Adres; // Degerleri cari.txt dosyasına yazdırdım.

				}


			}
			if (kontrol0 == 0)
			{
				cout << "Böyle bir müşteri bulunmamaktadir." << endl;
			}
			Müşteri_bilgileri_yaz.close(); // Dosyayı kapadım.
			Müşteri_bilgileri_oku.close(); // Dosyayı kapadım.
			remove("cari.txt"); // cari.txt dosyasını sildim.
			rename("arkaplan.tmp", "cari.txt");// arkaplanda olan degerleri yazığım geçici dosyanın adını değiştim.
			return main(); // programı main fonksiyonuna döndürdüm (en başa).

		}
		if (secim3 == 5) // Seçenek 5 ise if bloğuna girmesini sağladım.
		{
			string Silinecek_Firma_No;
			int kontrol = 0;
			system("cls");

			cout << "              **MÜŞTERİ SİLME**" << endl << endl;

			ifstream Müşteri_bilgileri_oku("cari.txt"); // cari.txt dosyasını okudum.
			ofstream Müşteri_bilgileri_yaz("arkaplan.tmp");

			cout << "Silmek istediğiniz Müşterinin Firma numarasını giriniz." << endl;
			cin >> Silinecek_Firma_No;
			while (!(Müşteri_bilgileri_oku.eof())) // cari.txt dosyasını baştan sona okuttum.
			{
				Müşteri_bilgileri_oku >> Firma_No >> Firma_Adı >> Firma_Telefon >> Firma_Sorumlusu >> Müşteri_Kategorisi >> Adres; // cari.txt dosyasına yazılan degerleri okuttum.

				if (Silinecek_Firma_No == Firma_No) // Sorgu firma no , dosyada yazılan firma no ile eşleşirse if bloğuna girmesini sağladım.
				{
					cout << "**SİLİNECEK MÜŞTERİ BİLGİLERİ**" << endl << endl;  // Silinecek müşteri bilgilerini ekrana bastırdım.
					cout << "\n Firma Numarası    :"; cout << Firma_No;
					cout << "\n Firma Adı         :"; cout << Firma_Adı;
					cout << "\n Firma Telefonu    :"; cout << Firma_Telefon;
					cout << "\n Firma Sorumlusu   :"; cout << Firma_Sorumlusu;
					cout << "\n Müşteri Kategorisi:"; cout << Müşteri_Kategorisi;
					cout << "\n Adres             :"; cout << Adres << endl;
					cout << "MÜŞTERİ SİLME İŞLEMİNİZ GERÇEKLEŞMİŞTİR..." << endl;
					kontrol = 1;
				}
				else
				{

					Müşteri_bilgileri_yaz << endl << Firma_No << " " << Firma_Adı << " " << Firma_Telefon << " " << Firma_Sorumlusu << " " << Müşteri_Kategorisi << " " << Adres; // Degerleri cari.txt dosyasına yazdırdım.

				}
			}
			if (kontrol == 0)
			{
				cout << "Girdiğiniz Firma Numarasında müşteri bulunmamaktadır." << endl;
			}

			Müşteri_bilgileri_yaz.close(); // Dosyayı kapadım.
			Müşteri_bilgileri_oku.close(); // Dosyayı kapadım.
			remove("cari.txt"); // cari.txt dosyasını sildim.
			rename("arkaplan.tmp", "cari.txt"); // arkaplanda olan degerleri yazığım geçici dosyanın adını değiştim.

		}
	}
	if (secim == 3)
	{
		do //Sadece ekranda verilen seçeneklerden herhangi biri seçilsin diye do while döngüsü kullandım.
		{
			cout << "Yapmak istediğiniz işlemi seçin." << endl << endl;
			cout << "1-) Sipariş Oluştur" << endl;
			cout << "2-) Sipariş Arama" << endl;
			cout << "3-) Sipariş Silme" << endl;
			cout << "4-) Sipariş Düzeltme" << endl;
			cout << "5-) Sipariş Raporlama" << endl;
			cout << endl;
			cin >> secim4;
			cout << endl;
		} while (secim4 != 1 && secim4 != 2 && secim4 != 3 && secim4 != 4 && secim4 != 5);

		if (secim4 == 1) // Seçilen seçenek 1 ise if bloğuna girmesini sağladım.
		{
			bool Kontrol1 = 0;
			bool Kontrol2 = 0;
			string Sorgu_Firma_No;
			string Sorgu_Ürün_Kodu;
			ofstream Sipariş_bilgileri_yaz; // Dosya çıkışı yapmak için gerekli kod.
			ifstream Ürün_bilgileri_oku("urun.txt");  // urun.txt dosyasını okuttum.
			ifstream Müşteri_bilgileri_oku("cari.txt");  // cari.txt dosyasını okuttum.
			cout << "Lütfen siparişi verecek Firmanın numarasını giriniz." << endl;
			cin >> Sorgu_Firma_No;
			while (!(Müşteri_bilgileri_oku.eof())) // cari.txt dosyasını baştan sona taradım.
			{
				Müşteri_bilgileri_oku >> Firma_No >> Firma_Adı >> Firma_Telefon >> Firma_Sorumlusu >> Müşteri_Kategorisi >> Adres; // cari.txt dosyasına yazılan degerleri okuttum.

				if (Sorgu_Firma_No == Firma_No) // Sorgu firma no , dosyada yazılan firma no ile eşleşirse if bloğuna girmesini sağladım.
				{
					Kontrol2 = 1;
					cout << "Sipariş verilecek ürünün kodunu giriniz." << endl;
					cin >> Sorgu_Ürün_Kodu;
					while (!(Ürün_bilgileri_oku.eof())) // urun.txt dosyasını baştan sona taradım.
					{
						Ürün_bilgileri_oku >> Ürün_Kodu >> Ürün_Adı >> Üreticisi >> Temin_Süresi >> Üretim_Tarihi_Yıl >> Fiyat >> Fiyat2 >> Kdv_Oranı >> Stok_Adedi; // urun.txt dosyasına yazılan degerleri okuttum.


						if (Sorgu_Ürün_Kodu == Ürün_Kodu && Müşteri_Kategorisi == "genel") // Sorgu ürün kodu , dosyada yazılan ürün kodu ile eşleşirse osyada yazılan ürün kodu ile eşleşirse ve müşteri genel bir müşteri ise ona göre fiyat versin diye if bloğuna girmesini sağladım.
						{
							cout << endl;
							cout << "**SİPARİŞ VERMEK İSTEDİĞİNİZ ÜRÜNÜN BİLGİLERİ**" << endl;  // Sipariş verilmek istenen ürünün bilgilerini ekrana bastırdım.
							cout << "\n Ürün Kodu         :"; cout << Ürün_Kodu;
							cout << "\n Ürün Adı          :"; cout << Ürün_Adı;
							cout << "\n Üretici           :"; cout << Üreticisi;
							cout << "\n Temin Süresi(Gün) :"; cout << Temin_Süresi;
							cout << "\n Üretim Tarihi(Yıl):"; cout << Üretim_Tarihi_Yıl;
							cout << "\n Fiyat(TL)         :"; cout << Fiyat;
							cout << "\n Kdv Oranı(%)      :"; cout << Kdv_Oranı;
							cout << "\n Stok Adedi        :"; cout << Stok_Adedi << endl;
							cout << endl;
							Sipariş_bilgileri_yaz.open("sipariş.txt", ios::app); // sipariş.txt dosyasını açtım.
							cout << "Siparişi veren Firmanın Numarası ve Adı: " << Firma_No << " ve " << Firma_Adı << "." << endl;  //
							cout << "Sipariş bilgilerini tamamlayınız." << endl;  // Sipariş bilgilerini aldım.
							cout << "\n Sipariş Numarası       :"; cin >> Sipariş_Numarası;
							cout << "\n Sipariş Tarihi         :"; cin >> Sipariş_Tarihi;
							cout << "\n Sipariş Adedi          :"; cin >> Sipariş_Adedi;
							Sipariş_Tutarı = Sipariş_Adedi * Fiyat;
							cout << "\n Sipariş Tutarı         :"; cout << Sipariş_Tutarı;
							cout << endl;
							cout << "\n Siparişi Alan          :"; cin >> Siparişi_Alan;
							Kontrol1 = 1;
							cout << endl << "SİPARİŞ OLUŞTURMA İŞLEMİNİZ TAMAMLANMIŞTIR..." << endl << endl;
							break;
						}
						if (Sorgu_Ürün_Kodu == Ürün_Kodu && Müşteri_Kategorisi == "ozel") // Sorgu ürün kodu , dosyada yazılan ürün kodu ile eşleşirse ve müşteri özel bir müşteri ise ona göre fiyat versin diye if bloğuna girmesini sağladım.
						{
							cout << endl;
							cout << "**SİPARİŞ VERMEK İSTEDİĞİNİZ ÜRÜNÜN BİLGİLERİ**" << endl;  // Sipariş verilmek istenen ürünün bilgilerini ekrana bastırdım.
							cout << "\n Ürün Kodu         :"; cout << Ürün_Kodu;
							cout << "\n Ürün Adı          :"; cout << Ürün_Adı;
							cout << "\n Üretici           :"; cout << Üreticisi;
							cout << "\n Temin Süresi(Gün) :"; cout << Temin_Süresi;
							cout << "\n Üretim Tarihi(Yıl):"; cout << Üretim_Tarihi_Yıl;
							cout << "\n Fiyat(TL)         :"; cout << Fiyat2;
							cout << "\n Kdv Oranı(%)      :"; cout << Kdv_Oranı;
							cout << "\n Stok Adedi        :"; cout << Stok_Adedi << endl;
							cout << endl;
							Sipariş_bilgileri_yaz.open("sipariş.txt", ios::app); // sipariş.txt dosyasını açtım.
							cout << "Siparişi veren Firmanın Numarası ve Adı: " << Firma_No << " ve " << Firma_Adı << "." << endl;  //
							cout << "Sipariş bilgilerini tamamlayınız." << endl;  // Sipariş bilgilerini aldım.
							cout << "\n Sipariş Numarası       :"; cin >> Sipariş_Numarası;
							cout << "\n Sipariş Tarihi         :"; cin >> Sipariş_Tarihi;
							cout << "\n Sipariş Adedi          :"; cin >> Sipariş_Adedi;
							Sipariş_Tutarı = Sipariş_Adedi * Fiyat2;
							cout << "\n Sipariş Tutarı         :"; cout << Sipariş_Tutarı;
							cout << endl;
							cout << "\n Siparişi Alan          :"; cin >> Siparişi_Alan;
							Kontrol1 = 1;
							cout << endl << "SİPARİŞ OLUŞTURMA İŞLEMİNİZ TAMAMLANMIŞTIR..." << endl << endl;
							break;
						}
					}
					
				}
			}
			if (Kontrol1 == 0)
			{
					cout << "Girdiğiniz koda ait ürün bulunamamıştır." << endl;
					return main();
			}
			if (Kontrol2 == 0)
			{
				cout << "Girdiğiniz numaraya ait Müşteri olan bir Firma bulunamamıştır." << endl << endl;;
				return main(); // programı main fonksiyonuna döndürdüm (en başa).
			}

			Sipariş_bilgileri_yaz << endl << Sipariş_Numarası << " " << Ürün_Adı << " " << Ürün_Kodu << " " << Sipariş_Adedi << " " << Sipariş_Tarihi << " " << Sorgu_Firma_No << " " << Sipariş_Tutarı << " " << Siparişi_Alan;
			Sipariş_bilgileri_yaz.close(); // Dosyayı kapadım.
		}


		if (secim4 == 2) //  Seçilen seçenek 2 ise if bloğuna girmesini sağladım.
		{
			system("cls");

			bool Kontrol = 0;
			cout << "              **SİPARİŞ ARAMA**" << endl << endl;
			cout << "Aramak istediğiniz siparişin numarasını giriniz." << endl;
			cin >> Sorgu_Sipariş_Numarası;

			ifstream Sipariş_bilgileri_oku("sipariş.txt"); // sipariş.txt dosyasını okudum.
			ifstream Ürün_bilgileri_oku("urun.txt"); // urun.txt dosyasını okudum.
			ifstream Müşteri_bilgileri_oku("cari.txt"); // cari.txt dosyasını okudum.

			while (!(Sipariş_bilgileri_oku.eof())) // sipariş.txt dosyasını baştan sona taradım.
			{
				Sipariş_bilgileri_oku >> Sipariş_Numarası >> Ürün_Adı >> Ürün_Kodu >> Sipariş_Adedi >> Sipariş_Tarihi >> Firma_No >> Sipariş_Tutarı >> Siparişi_Alan; // sipariş.txt dosyasına yazılan degerleri okuttum.

				if (Sorgu_Sipariş_Numarası == Sipariş_Numarası) // Sorgu sipariş numarası , dosyada yazılan sipariş numarası ile eşleşirse if bloğuna girmesini sağladım.
				{
					cout << endl;
					cout << "**ARAMAK İSTEDİĞİNİZ SİPARİŞ BİLGİLERİ**" << endl; // Aramak istenen sipariş bilgilerini ekrana bastırdım.
					cout << "\n Sipariş Numarası          :"; cout << Sipariş_Numarası;
					cout << "\n Ürün Adı                  :"; cout << Ürün_Adı;
					cout << "\n Ürün Kodu                 :"; cout << Ürün_Kodu;
					cout << "\n Sipariş Adedi             :"; cout << Sipariş_Adedi;
					cout << "\n Sipariş Tarihi            :"; cout << Sipariş_Tarihi;
					cout << "\n Sipariş Veren Firmanın No :"; cout << Firma_No;
					cout << "\n Sipariş Tutarı            :"; cout << Sipariş_Tutarı;
					cout << "\n Siparişi Alan             :"; cout << Siparişi_Alan << endl;
					Kontrol = 1;
					break;
				}
			}
			Sipariş_bilgileri_oku.close(); // Dosyayı kapadım.
			Ürün_bilgileri_oku.close(); // Dosyayı kapadım.
			Müşteri_bilgileri_oku.close(); // Dosyayı kapadım.
			if (Kontrol == 0)
			{
				cout << "Girdiğiniz Numaraya ait bir sipariş bulunamamıştır" << endl;
			}
			return main(); // programı main fonksiyonuna döndürdüm (en başa).
		}
		if (secim4 == 3) // Seçilen seçenek 3 ise if bloğuna girmesini sağladım.
		{
			string Silinecek_Sipariş_Numarası;
			system("cls");
			int kontrol = 0;
			cout << endl;
			cout << "              **SİPARİŞ SİLME**" << endl << endl;

			ifstream Ürün_bilgileri_oku("urun.txt"); // urun.txt dosyasını okudum.
			ifstream Müşteri_bilgileri_oku("cari.txt"); // cari.txt dosyasını okudum.
			ifstream Sipariş_bilgileri_oku("sipariş.txt"); // sipariş.txt dosyasını okudum.
			ofstream Sipariş_bilgileri_yaz("arkaplan.tmp"); // Arkaplanda bilgileri yazdırmak için geçici birdosya açtım.

			cout << "Silmek istediğiniz siparişin numarasını giriniz." << endl;
			cin >> Silinecek_Sipariş_Numarası;

			while (!(Sipariş_bilgileri_oku.eof())) // sipariş.txt dosyasını baştan sona taradım.
			{
				Sipariş_bilgileri_oku >> Sipariş_Numarası >> Ürün_Adı >> Ürün_Kodu >> Sipariş_Adedi >> Sipariş_Tarihi >> Firma_No >> Sipariş_Tutarı >> Siparişi_Alan; // sipariş.txt dosyasına yazılan degerleri okuttum.

				if (Silinecek_Sipariş_Numarası == Sipariş_Numarası) // Sorgu sipariş numarası , dosyada yazılan sipariş numarası ile eşleşirse if bloğuna girmesini sağladım.
				{
					cout << endl;
					cout << "**SİLİNECEK SİPARİŞ BİLGİLERİ**" << endl;  // silinecek siparişin bilgilerini ekrana bastırdım.
					cout << "\n Sipariş Numarası          :"; cout << Sipariş_Numarası;
					cout << "\n Ürün Adı                  :"; cout << Ürün_Adı;
					cout << "\n Ürün Kodu                 :"; cout << Ürün_Kodu;
					cout << "\n Sipariş Tarihi            :"; cout << Sipariş_Tarihi;
					cout << "\n Sipariş Adedi             :"; cout << Sipariş_Adedi;
					cout << "\n Sipariş Veren Firmanın No :"; cout << Firma_No;
					cout << "\n Sipariş Tutarı            :"; cout << Sipariş_Tutarı;
					cout << "\n Siparişi Alan             :"; cout << Siparişi_Alan << endl << endl;
					cout << "SİPARİŞ SİLME İŞLEMİNİZ GERÇEKLEŞMİŞTİR..." << endl;
					kontrol = 1;

				}
				else
				{
					Sipariş_bilgileri_yaz << endl << Sipariş_Numarası << " " << Ürün_Adı << " " << Ürün_Kodu << " " << Sipariş_Adedi << " " << Sipariş_Tarihi << " " << Firma_No << " " << Sipariş_Tutarı << " " << Siparişi_Alan; // Degerleri sipariş.txt dosyasına yazdırdım.

				}
			}
			Sipariş_bilgileri_yaz.close(); // Dosyayı kapadım.
			Sipariş_bilgileri_oku.close(); // Dosyayı kapadım.
			remove("sipariş.txt");
			rename("arkaplan.tmp", "sipariş.txt");
			if (kontrol == 0)
			{
				cout << "Girdiğiniz numaraya ait sipariş bulunamamıştır." << endl;
			}
			return main(); // programı main fonksiyonuna döndürdüm (en başa).
		}

		if (secim4 == 4)  // Seçilen seçenek 4 ise if bloğuna girmesini sağladım.
		{
			string Sorgu_Sipariş_Numarası;
			system("cls");

			cout << "              **SİPARİŞ DÜZENLEME**" << endl << endl;

			ifstream Ürün_bilgileri_oku("urun.txt");  // urun.txt dosyasını okudum.
			ifstream Müşteri_bilgileri_oku("cari.txt");  // cari.txt dosyasını okudum.
			ifstream Sipariş_bilgileri_oku("sipariş.txt");  // sipariş.txt dosyasını okudum.
			ofstream Sipariş_bilgileri_yaz("arkaplan.tmp"); // Arkaplanda bilgileri yazdırmak için geçici birdosya açtım.

			cout << "Düzenlemek istediğiniz siparişin numarasını giriniz." << endl;
			cin >> Sorgu_Sipariş_Numarası;
			int gcc = 0;

			while (!(Sipariş_bilgileri_oku.eof()))  // sipariş.txt dosyasını baştan sona taradım.
			{
				Sipariş_bilgileri_oku >> Sipariş_Numarası >> Ürün_Adı >> Ürün_Kodu >> Sipariş_Adedi >> Sipariş_Tarihi >> Firma_No >> Sipariş_Tutarı >> Siparişi_Alan; // sipariş.txt dosyasına yazılan degerleri okuttum.

				if (Sorgu_Sipariş_Numarası == Sipariş_Numarası) // Sorgu sipariş numarası , dosyada yazılan sipariş numarası ile eşleşirse if bloğuna girmesini sağladım.
				{
					cout << "**SİPARİŞİN DÜZENLENMEDEN ÖNCEKİ HALİ**" << endl << endl; // siparişin düzenlenmeden önceki halini ekrana bastırdım. 
					cout << "\n Sipariş Numarası          :"; cout << Sipariş_Numarası;
					cout << "\n Ürün Adı                  :"; cout << Ürün_Adı;
					cout << "\n Ürün Kodu                 :"; cout << Ürün_Kodu;
					cout << "\n Sipariş Adedi             :"; cout << Sipariş_Adedi;
					cout << "\n Sipariş Tarihi            :"; cout << Sipariş_Tarihi;
					cout << "\n Sipariş Veren Firmanın No :"; cout << Firma_No;
					cout << "\n Sipariş Tutarı(TL)        :"; cout << Sipariş_Tutarı;
					cout << "\n Siparişi Alan             :"; cout << Siparişi_Alan << endl << endl;
					cout << "**SİPARİŞ DÜZENLEME EKRANI**" << endl; // sipariş bilgilerini düzenlemek için veri girişi aldım.
					cout << "\n Sipariş Numarası          :"; cin >> Sipariş_Numarası;
					cout << "\n Ürün Adı                  :"; cin >> Ürün_Adı;
					cout << "\n Ürün Kodu                 :"; cin >> Ürün_Kodu;
					cout << "\n Sipariş Adedi             :"; cin >> Sipariş_Adedi;
					cout << "\n Sipariş Tarihi            :"; cin >> Sipariş_Tarihi;
					cout << "\n Sipariş Veren Firmanın No :"; cin >> Firma_No;
					cout << "\n Sipariş Tutarı(TL)        :"; cin >> Sipariş_Tutarı;
					cout << "\n Siparişi Alan             :"; cin >> Siparişi_Alan;
					cout << endl;
					cout << "ÜRÜN DÜZENLEME İŞLEMİNİZ GERÇEKLEŞMİŞTİR..." << endl;

					Sipariş_bilgileri_yaz << endl << Sipariş_Numarası << " " << Ürün_Adı << " " << Ürün_Kodu << " " << Sipariş_Adedi << " " << Sipariş_Tarihi << " " << Firma_No << " " << Sipariş_Tutarı << " " << Siparişi_Alan; // Degerleri sipariş.txt dosyasına yazdırdım.

					gcc = 1;
				}
				else
				{
					Sipariş_bilgileri_yaz << endl << Sipariş_Numarası << " " << Ürün_Adı << " " << Ürün_Kodu << " " << Sipariş_Adedi << " " << Sipariş_Tarihi << " " << Firma_No << " " << Sipariş_Tutarı << " " << Siparişi_Alan; // Degerleri sipariş.txt dosyasına yazdırdım.

				}
			}
			if (gcc == 0)
			{
				cout << "Boyle bir sipariş bulunmamaktadir." << endl;
			}
			Sipariş_bilgileri_yaz.close(); // Dosyayı kapadım.
			Sipariş_bilgileri_oku.close(); // Dosyayı kapadım.
			remove("sipariş.txt");
			rename("arkaplan.tmp", "sipariş.txt");
			return main(); // programı main fonksiyonuna döndürdüm (en başa).
		}

		if (secim4 == 5)  // Seçilen seçenek 5 ise if bloğuna girmesini sağladım.
		{
			system("cls");
			ifstream Sipariş_bilgileri_oku("sipariş.txt");  // sipariş.txt dosyasını okudum.

			while (!(Sipariş_bilgileri_oku.eof()))  // sipariş.txt dosyasını baştan sona taradım.

			{
				Sipariş_bilgileri_oku >> Sipariş_Numarası >> Ürün_Adı >> Ürün_Kodu >> Sipariş_Adedi >> Sipariş_Tarihi >> Firma_No >> Sipariş_Tutarı >> Siparişi_Alan; // sipariş.txt dosyasına yazılan degerleri okuttum.

				cout << endl;
				cout << "**SİPARİŞ LİSTESİ**" << endl;  // siparişlerin listesini ekrana bastırdım.
				cout << "\n Sipariş Numarası          :"; cout << Sipariş_Numarası;
				cout << "\n Ürün Adı                  :"; cout << Ürün_Adı;
				cout << "\n Ürün Kodu                 :"; cout << Ürün_Kodu;
				cout << "\n Sipariş Tarihi            :"; cout << Sipariş_Tarihi;
				cout << "\n Sipariş Adedi             :"; cout << Sipariş_Adedi;
				cout << "\n Sipariş Veren Firmanın No :"; cout << Firma_No;
				cout << "\n Sipariş Tutarı(TL)        :"; cout << Sipariş_Tutarı;
				cout << "\n Siparişi Alan             :"; cout << Siparişi_Alan << endl << endl;

			}Sipariş_bilgileri_oku.close(); // Dosyayı kapadım.
			return main(); // programı main fonksiyonuna döndürdüm (en başa).
		}
	}
}