﻿/****************************************************************************
**					           SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				          BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				            PROGRAMLAMAYA GİRİŞİ DERSİ
**
**
**				ÖĞRENCİ ADI: Metehan DÜNDAR
**				ÖĞRENCİ NUMARASI: G211210031
**				DERS GRUBU: A
****************************************************************************/
#include <string>
#include <iostream>
#include <locale.h>
#include <ctime>
#include <stdlib.h>

using namespace std;

void run3harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[4];
	string randomşehir[3];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++) /*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 3; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 3; İndis++) {/*İndisler.*/
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[3] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 3 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "3 Harfli Şehir Bulunamadı." << endl;
	}
}

void run4harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[5];
	string randomşehir[4];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 4; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 4; İndis++)/*İndisler.*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[4] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 4 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "4 Harfli Şehir Bulunamadı." << endl;
	}
}

void run5harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[6];
	string randomşehir[5];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 5; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 5; İndis++)/*İndisler.*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[5] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 5 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "5 Harfli Şehir Bulunamadı." << endl;
	}
}

void run6harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[7];
	string randomşehir[6];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 6; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 6; İndis++)/*İndisler.*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[6] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 6 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "6 Harfli Şehir Bulunamadı." << endl;
	}
}

void run7harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[8];
	string randomşehir[7];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 7; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 7; İndis++)/*İndisler.*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[7] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 7 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "7 Harfli Şehir Bulunamadı." << endl;
	}
}

void run8harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[9];
	string randomşehir[8];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 8; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 8; İndis++)/*İndisler.*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[8] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 8 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "8 Harfli Şehir Bulunamadı." << endl;
	}
}

void run9harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[10];
	string randomşehir[9];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 9; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{

			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 9; İndis++)/*İndisler.*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[9] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır..*/
			{
				cout << "Bulunan 9 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "9 Harfli Şehir Bulunamadı." << endl;
	}
}

void run10harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[11];
	string randomşehir[10];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 10; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için */
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 10; İndis++)/*İndisler*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[10] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 10 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "10 Harfli Şehir Bulunamadı." << endl;
	}
}
void run11harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[12];
	string randomşehir[11];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 11; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için */
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 11; İndis++)/*İndisler*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[11] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 11 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "11 Harfli Şehir Bulunamadı." << endl;
	}
}
void run12harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[13];
	string randomşehir[12];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 12; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 12; İndis++)/*İndisler.*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[12] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 12 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "12 Harfli Şehir Bulunamadı." << endl;
	}
}
void run13harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[14];
	string randomşehir[13];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 13; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 13; İndis++)/*İndisler.*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[12] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 13 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "13 Harfli Şehir Bulunamadı." << endl;
	}
}
void run14harfli(string* Şehirler)
{
	srand(time(NULL));

	int Şehirdenemesi = 0;
	char Yeni_şehir[15];
	string randomşehir[14];

	for (int Deneme_Sayısı = 0; Deneme_Sayısı < 100000; Deneme_Sayısı++)/*100.000 deneme için oluşturulan döngü.*/
	{
		for (int Rastgele_Alınan_Şehir = 0; Rastgele_Alınan_Şehir < 14; Rastgele_Alınan_Şehir++)/*Rastgele 3 il seçmek için.*/
		{
			randomşehir[Rastgele_Alınan_Şehir] = Şehirler[rand() % 81];
			//cout << randomil[Rastgele_Alınan_Şehir] << endl;
		}

		for (int İndis = 0; İndis < 14; İndis++)/*İndisler*/
		{
			//	cout << randomil[Rastgele_Alınan_Şehir][0] << endl;
			Yeni_şehir[İndis] = randomşehir[İndis][0];
		}
		Yeni_şehir[14] = '\0';
		for (int Oluşan_İndisler = 0; Oluşan_İndisler < 81; Oluşan_İndisler++)/*Rastgele seçilen şehirlerin indislerinden oluşan kelimeler.*/
		{
			if (Şehirler[Oluşan_İndisler] == Yeni_şehir)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olursa döngüden çıkar ve yeni şehri yazdırır.*/
			{
				cout << "Bulunan 14 Harfli Şehir: " << Yeni_şehir << endl;
				return;
			}
		}
	}
	if (Şehirdenemesi == 0)/*Rastgele seçilen şehirlerin indislerinden oluşan kelime, bir şehir olmazsa döngüden çıkar ve bulunamadı yazdırır.*/
	{
		cout << "14 Harfli Şehir Bulunamadı." << endl;
	}
}
int main()
{
	setlocale(LC_ALL, "turkish");

	string Şehirler[81] = { "adana", "adıyaman", "afyonkarahisar", "ağrı", "amasya", "ankara", "antalya",
		"artvin", "aydın","balıkesir", "bilecik", "bingöl", "bitlis", "bolu", "burdur", "bursa",
		"çanakkale", "çankırı","çorum", "denizli", "diyarbakır", "edirne", "elazığ", "erzincan",
		"erzurum", "eskişehir", "gaziantep","giresun", "gümüşhane", "hakkari", "hatay", "ısparta",
		"mersin", "istanbul", "izmir", "kars", "kastamonu", "kayseri", "kırklareli", "kırşehir",
		"kocaeli", "konya", "kütahya", "malatya", "manisa", "kahramanmaraş", "mardin", "muğla",
		"muş", "nevşehir", "niğde", "ordu", "rize", "sakarya", "samsun", "siirt", "sinop", "sivas",
		"tekirdağ", "tokat", "trabzon", "tunceli", "şanlıurfa", "uşak", "van", "yozgat", "zonguldak",
		"aksaray", "bayburt", "karaman", "kırıkkale", "batman", "şırnak", "bartın", "ardahan",
		"ığdır", "yalova", "karabük", "kilis", "osmaniye", "düzce" };

	int EnKısaŞehir = Şehirler[0].length();

	int EnUzunŞehir = Şehirler[0].length();

	for (int Şehirseçme = 0; Şehirseçme < 81; Şehirseçme++) //En kısa ve en uzun Şehiri Buldurmak için.
	{
		if (Şehirler[EnKısaŞehir].length() > Şehirler[Şehirseçme].length()) //En az karakterli(en kısa) şehri buldurmak için.
		{
			EnKısaŞehir = Şehirseçme;
		}
		if (Şehirler[EnUzunŞehir].length() < Şehirler[Şehirseçme].length()) //En faza karakterli(en uzun) şehri buldurmak için.
		{
			EnUzunŞehir = Şehirseçme;
		}
	}
	cout << "En kısa şehir: " << Şehirler[EnKısaŞehir] << "." << endl;
	cout << "En uzun şehir: " << Şehirler[EnUzunŞehir] << "." << endl;
	cout << endl;

	run3harfli(Şehirler);
	run4harfli(Şehirler);
	run5harfli(Şehirler);
	run6harfli(Şehirler);
	run7harfli(Şehirler);
	run8harfli(Şehirler);
	run9harfli(Şehirler);
	run10harfli(Şehirler);
	run11harfli(Şehirler);
	run12harfli(Şehirler);
	run13harfli(Şehirler);
	run14harfli(Şehirler);
}