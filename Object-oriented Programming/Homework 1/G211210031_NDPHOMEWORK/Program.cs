/****************************************************************************
**					      SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1.Odev
**				ÖĞRENCİ ADI............:Metehan Dundar  
**				ÖĞRENCİ NUMARASI.......:G211210031
**              DERSİN ALINDIĞI GRUP...:2. Ogretim B Grubu
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NDP_Homework1
{
    class Program
    {
        public static class SifreGuvenlik
        {

            public static int toplamBuyukHarfSayisi;
            public static int toplamKucukHarfSayisi;
            public static int toplamRakamSayisi;
            public static int toplamSembolSayisi;
            public static int toplamKarakterSayisi;
            public static int toplamBoslukSayisi;
            public static void BuyukHarfSayisi(string sifre)
            {
                string liste1 = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZQWX"; // Buyuk harfleri tanimliyoruz.

                for (int i = 0; i < sifre.Length; i++)     // Sifre uzunlugu kadar donen bir for dongusu acip sifre icinde kac tane buyuk harf var hesapliyoruz.
                {
                    if (liste1.Contains(sifre[i]))
                    {
                        toplamBuyukHarfSayisi++;
                    }
                }
                Console.WriteLine("Sifredeki toplam Buyuk Harf Sayisi: " + toplamBuyukHarfSayisi);
            }


            public static void KucukHarfSayisi(string sifre)
            {
                string liste2 = "abcçdefgğhiıjklmnoöprsştuüvyzqwx";  // Kucuk harfleri tanimliyoruz.

                for (int i = 0; i < sifre.Length; i++)     // Sifre uzunlugu kadar donen bir for dongusu acip sifre icinde kac tane kucuk harf var hesapliyoruz.
                {
                    if (liste2.Contains(sifre[i]))
                    {
                        toplamKucukHarfSayisi++;
                    }
                }
                Console.WriteLine("Sifredeki toplam Kucuk Harf Sayisi: " + toplamKucukHarfSayisi);
            }

            public static void RakamSayisi(string sifre)
            {

                string liste3 = "0123456789";                        // Rakamlari tanimliyoruz.

                for (int i = 0; i < sifre.Length; i++)     // Sifre uzunlugu kadar donen bir for dongusu acip sifre icinde kac tane rakam var hesapliyoruz.
                {
                    if (liste3.Contains(sifre[i]))
                    {
                        toplamRakamSayisi++;
                    }
                }
                Console.WriteLine("Sifredeki toplam Rakam Sayisi: " + toplamRakamSayisi);
            }

            public static void SembolSayisi(string sifre)
            {
                string liste4 = "!'^+%&/()=?-*><#$½{[]}|;,.";        // Sembolleri tanimliyoruz.

                for (int i = 0; i < sifre.Length; i++)     // Sifre uzunlugu kadar donen bir for dongusu acip sifre icinde kac tane sembol var hesapliyoruz.
                {
                    if (liste4.Contains(sifre[i]))
                    {
                        toplamSembolSayisi++;
                    }
                }
                Console.WriteLine("Sifredeki toplam Sembol Sayisi: " + toplamSembolSayisi);
            }

            public static void KarakterSayisi(string sifre)
            {
                string liste5 = "!'^+%&/()=?-*><#$½{[]}|;,.0123456789abcçdefgğhiıjklmnoöprsştuüvyzqwxABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZQWX";

                for (int i = 0; i < sifre.Length; i++)     // Sifre uzunlugu kadar donen bir for dongusu acip sifre icinde kac tane Karakter var hesapliyoruz.
                {
                    if (liste5.Contains(sifre[i]))
                    {
                        toplamKarakterSayisi++;
                    }
                }
                Console.WriteLine("Sifredeki toplam karakter Sayisi: " + toplamKarakterSayisi);
            }

            public static void BoslukSayisi(string sifre)
            {
                char[] sifreArray = sifre.ToCharArray();   // String ToCharArray yontemi ile string ifadesi karakterlerine ayrilarak geriye dizi olarak doner.
                foreach (var item in sifreArray)           // Foreach dongusu sayesinde sifre icinde geziyoruz.
                {
                    if (item == (char)32)
                    {
                        toplamBoslukSayisi++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            while (true) // Sifre olustuktan sonra yeni bir sifre denemek icin while dongusu actim.
            {
                Console.WriteLine("Sifrenizi Giriniz:");
                string sifre = Console.ReadLine();  // Kullanicidan sifreyi aldim
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Girilen Sifre: " + sifre);
                Console.WriteLine("--------------------------------------------");
                // Bu kisimda Metotlardan karakter sayilarini ayri ayri aliyoruz.
                SifreGuvenlik.KarakterSayisi(sifre);
                SifreGuvenlik.BuyukHarfSayisi(sifre);
                SifreGuvenlik.KucukHarfSayisi(sifre);
                SifreGuvenlik.RakamSayisi(sifre);
                SifreGuvenlik.SembolSayisi(sifre);
                SifreGuvenlik.BoslukSayisi(sifre);
                if (SifreGuvenlik.toplamKarakterSayisi < 9)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sifre en az 9 karakterden olusmak zorundadir.");
                    Console.WriteLine("Gecersiz Sifre!! Programdan cikis yapiliyor...");
                    return;
                }
                if (SifreGuvenlik.toplamBuyukHarfSayisi == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lutfen sifrenizde en az 1 tane buyuk harf kullaniniz.");
                    Console.WriteLine("Gecersiz Sifre!! Programdan cikis yapiliyor...");
                    return;
                }
                if (SifreGuvenlik.toplamKucukHarfSayisi == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lutfen sifrenizde en az 1 tane kucuk harf kullaniniz.");
                    Console.WriteLine("Gecersiz Sifre!! Programdan cikis yapiliyor...");
                    return;
                }
                if (SifreGuvenlik.toplamRakamSayisi == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lutfen sifrenizde en az 1 tane rakam kullaniniz.");
                    Console.WriteLine("Gecersiz Sifre!! Programdan cikis yapiliyor...");
                    return;
                }
                if (SifreGuvenlik.toplamSembolSayisi == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lutfen sifrenizde en az 1 tane sembol kullaniniz.");
                    Console.WriteLine("Gecersiz Sifre!! Programdan cikis yapiliyor...");
                    return;
                }
                if (SifreGuvenlik.toplamBoslukSayisi > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lutfen sifrenizde bosluk kullanmayiniz.");
                    Console.WriteLine("Gecersiz Sifre!! Programdan cikis yapiliyor...");
                    return;
                }
                PuanHesaplama();  // Puan hesabi burda yapiliyor
                static void PuanHesaplama()
                {
                    int SifrePuani = 0;

                    int BuyukHarfPuani = 0;
                    if (SifreGuvenlik.toplamBuyukHarfSayisi == 1)
                    {
                        BuyukHarfPuani = 10;
                    }
                    else
                    {
                        BuyukHarfPuani = 20;
                    }

                    int KucukHarfPuani = 0;
                    if (SifreGuvenlik.toplamKucukHarfSayisi == 1)
                    {
                        KucukHarfPuani = 10;
                    }
                    else
                    {
                        KucukHarfPuani = 20;
                    }

                    int RakamPuani = 0;
                    if (SifreGuvenlik.toplamRakamSayisi == 1)
                    {
                        RakamPuani = 10;
                    }
                    else
                    {
                        RakamPuani = 20;
                    }

                    int SembolPuani = 0;
                    if (SifreGuvenlik.toplamSembolSayisi > 0)
                    {
                        SembolPuani = (SifreGuvenlik.toplamSembolSayisi * 10);
                    }
                    SifrePuani = BuyukHarfPuani + KucukHarfPuani + RakamPuani + SembolPuani;
                    Console.Write("Sifre Guvenlik Puani: ");
                    if (SifreGuvenlik.toplamKarakterSayisi == 9)    // Karakter Sayisi 9 a esitse +10 puan ilave ediyoruz.
                    {
                        SifrePuani += 10;

                    }
                    Console.Write(SifrePuani + " ");  // Puani ve sifre gecerliligini yazdiriyoruz.
                    if (SifrePuani < 70) Console.WriteLine("Sifre Kabul edilemez.");
                    if (SifrePuani >= 70 && SifrePuani <= 90) Console.WriteLine("Sifre Kabul edilir.");
                    if (SifrePuani > 90) Console.WriteLine("Sifre kabul edilir ve guclu.");

                }
            }
        }

    }
}