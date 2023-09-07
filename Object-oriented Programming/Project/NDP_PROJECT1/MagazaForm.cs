/****************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:PROJE   
**				ÖĞRENCİ ADI............:METEHAN DÜNDAR  
**				ÖĞRENCİ NUMARASI.......:G211210031
**                         DERSİN ALINDIĞI GRUP...:2-B
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace NDP_PROJECT1
{
    public partial class MagazaForm : Form
    {
        public MagazaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokForm stok1 = new StokForm();
            stok1.ShowDialog();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusteriForm musteri1 = new MusteriForm();
            RafdakiStokForm rafdakistokk = new RafdakiStokForm();

            {
                StreamReader oku1 = new StreamReader(@"Musteri_Adi.txt");
                musteri1.txtMusteriAd_M.Text = oku1.ReadToEnd();
                musteri1.txtMusteriAd_M.Text = musteri1.txtMusteriAd_M.Text + Environment.NewLine;
                oku1.Close();

                StreamReader oku2 = new StreamReader(@"Musteri_Soyadi.txt");
                musteri1.txtMusteriSoyad_M.Text = oku2.ReadToEnd();
                musteri1.txtMusteriSoyad_M.Text = musteri1.txtMusteriSoyad_M.Text + Environment.NewLine;
                oku2.Close();

                
                StreamReader oku3 = new StreamReader(@"Erkek_Ts_Stok.txt");
                int KontrolErkek_Ts_Sayisi = Convert.ToInt32(oku3.ReadLine());
                if (KontrolErkek_Ts_Sayisi == 100) oku3.Close();
                else
                {
                    musteri1.txtMusteriAlinanUrun_M.Text = musteri1.txtMusteriAlinanUrun_M.Text + "Erkek T-Shirts" + Environment.NewLine;
                    musteri1.txtMusteriAdet_M.Text = musteri1.txtMusteriAdet_M.Text + Convert.ToString(100 - KontrolErkek_Ts_Sayisi) + Environment.NewLine;
                    oku3.Close();
                }

                StreamReader oku4 = new StreamReader(@"Erkek_P_Stok.txt");
                int KontrolErkek_P_Sayisi = Convert.ToInt32(oku4.ReadToEnd());
                if (KontrolErkek_P_Sayisi == 150) oku4.Close();
                else
                {
                    musteri1.txtMusteriAlinanUrun_M.Text = musteri1.txtMusteriAlinanUrun_M.Text + "Erkek Pantolon" + Environment.NewLine;
                    musteri1.txtMusteriAdet_M.Text = musteri1.txtMusteriAdet_M.Text + Convert.ToString(150 - KontrolErkek_P_Sayisi) + Environment.NewLine;
                    oku4.Close();
                }

                StreamReader oku5 = new StreamReader(@"Erkek_STs_Stok.txt");
                int KontrolErkek_STs_Sayisi = Convert.ToInt32(oku5.ReadLine());
                if (KontrolErkek_STs_Sayisi == 200) oku5.Close();
                else
                {
                    musteri1.txtMusteriAlinanUrun_M.Text = musteri1.txtMusteriAlinanUrun_M.Text + "Erkek Sweatshirts" + Environment.NewLine;
                    musteri1.txtMusteriAdet_M.Text = musteri1.txtMusteriAdet_M.Text + Convert.ToString(200 - KontrolErkek_STs_Sayisi) + Environment.NewLine;
                    oku5.Close();
                }

                StreamReader oku6 = new StreamReader(@"Kadin_Ts_Stok.txt");
                int KontrolKadin_Ts_Sayisi = Convert.ToInt32(oku6.ReadLine());
                if (KontrolKadin_Ts_Sayisi == 250) oku6.Close();
                else
                {
                    musteri1.txtMusteriAlinanUrun_M.Text = musteri1.txtMusteriAlinanUrun_M.Text + "Kadin T-Shirts" + Environment.NewLine;
                    musteri1.txtMusteriAdet_M.Text = musteri1.txtMusteriAdet_M.Text + Convert.ToString(250 - KontrolKadin_Ts_Sayisi) + Environment.NewLine;
                    oku6.Close();
                }

                StreamReader oku7 = new StreamReader(@"Kadin_P_Stok.txt");
                int KontrolKadin_P_Sayisi = Convert.ToInt32(oku7.ReadLine());
                if (KontrolKadin_P_Sayisi == 300) oku7.Close();
                else
                {
                    musteri1.txtMusteriAlinanUrun_M.Text = musteri1.txtMusteriAlinanUrun_M.Text + "Kadin Pantolon" + Environment.NewLine;
                    musteri1.txtMusteriAdet_M.Text = musteri1.txtMusteriAdet_M.Text + Convert.ToString(300 - KontrolKadin_P_Sayisi) + Environment.NewLine;
                    oku7.Close();
                }

                StreamReader oku8 = new StreamReader(@"Kadin_STs_Stok.txt");
                int KontrolKadin_STs_Sayisi = Convert.ToInt32(oku8.ReadLine());
                if (KontrolKadin_STs_Sayisi == 350) oku8.Close();
                else
                {
                    musteri1.txtMusteriAlinanUrun_M.Text = musteri1.txtMusteriAlinanUrun_M.Text + "Kadin Sweatshirts" + Environment.NewLine;
                    musteri1.txtMusteriAdet_M.Text = musteri1.txtMusteriAdet_M.Text + Convert.ToString(350 - KontrolKadin_STs_Sayisi) + Environment.NewLine;
                    oku8.Close();
                }

                StreamReader oku9 = new StreamReader(@"Cocuk_Ts_Stok.txt");
                int KontrolCocuk_Ts_Sayisi = Convert.ToInt32(oku9.ReadLine());
                if (KontrolCocuk_Ts_Sayisi == 400) oku9.Close();
                else
                {
                    musteri1.txtMusteriAlinanUrun_M.Text = musteri1.txtMusteriAlinanUrun_M.Text + "Cocuk T-Shirts" + Environment.NewLine;
                    musteri1.txtMusteriAdet_M.Text = musteri1.txtMusteriAdet_M.Text + Convert.ToString(400 - KontrolCocuk_Ts_Sayisi) + Environment.NewLine;
                    oku9.Close();
                }

                StreamReader oku10 = new StreamReader(@"Cocuk_P_Stok.txt");
                int KontrolCocuk_P_Sayisi = Convert.ToInt32(oku10.ReadLine());
                if (KontrolCocuk_P_Sayisi == 450) oku10.Close();
                else
                {
                    musteri1.txtMusteriAlinanUrun_M.Text = musteri1.txtMusteriAlinanUrun_M.Text + "Cocuk Pantolon" + Environment.NewLine;
                    musteri1.txtMusteriAdet_M.Text = musteri1.txtMusteriAdet_M.Text + Convert.ToString(450 - KontrolCocuk_P_Sayisi) + Environment.NewLine;
                    oku10.Close();
                }

                StreamReader oku11 = new StreamReader(@"Cocuk_STs_Stok.txt");
                int KontrolCocuk_STs_Sayisi = Convert.ToInt32(oku11.ReadLine());
                if (KontrolCocuk_STs_Sayisi == 500) oku11.Close();
                else
                {
                    musteri1.txtMusteriAlinanUrun_M.Text = musteri1.txtMusteriAlinanUrun_M.Text + "Cocuk Sweatshirts" + Environment.NewLine;
                    musteri1.txtMusteriAdet_M.Text = musteri1.txtMusteriAdet_M.Text + Convert.ToString(500 - KontrolCocuk_STs_Sayisi) + Environment.NewLine;
                    oku11.Close();
                }
                musteri1.txtMusteriAlinanUrun_M.Text += "-------------------------";
                musteri1.txtMusteriAdet_M.Text += "-------------------------";
                oku1.Close();
                oku2.Close();
                oku3.Close();
                oku4.Close();
                oku5.Close();
                oku6.Close();
                oku7.Close();
                oku8.Close();
                oku9.Close();
                oku10.Close();
                oku11.Close();
                
            }
            musteri1.ShowDialog();
        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            TedarikciGiris tedarikcigiris = new TedarikciGiris();
            tedarikcigiris.ShowDialog();

        }

        private void btnGg_Click(object sender, EventArgs e)
        {
            TedarikçiListesiForm tedarikçiListesi1 = new TedarikçiListesiForm();
            DepodakiStokForm depodakistokk = new DepodakiStokForm();

            {
                StreamReader oku1 = new StreamReader(@"Firma_Adi.txt");
                tedarikçiListesi1.txtFirmaAdı.Text = oku1.ReadToEnd();
                tedarikçiListesi1.txtFirmaAdı.Text = tedarikçiListesi1.txtFirmaAdı.Text + Environment.NewLine;
                oku1.Close();

                StreamReader oku2 = new StreamReader(@"Firma_No.txt");
                tedarikçiListesi1.txtFirmaNo.Text = oku2.ReadToEnd();
                tedarikçiListesi1.txtFirmaNo.Text = tedarikçiListesi1.txtFirmaNo.Text + Environment.NewLine;
                oku2.Close();

                StreamReader oku3 = new StreamReader(@"Erkek_Ts_DepoStok.txt");
                int KontrolErkek_Ts_Sayisi = Convert.ToInt32(oku3.ReadLine());
                if (KontrolErkek_Ts_Sayisi == 500) oku3.Close();
                else
                {
                    tedarikçiListesi1.txtSiparisalinanUrun.Text = tedarikçiListesi1.txtSiparisalinanUrun.Text + "Erkek T-Shirts" + Environment.NewLine;
                    tedarikçiListesi1.txtSiparisurunSayisi.Text = tedarikçiListesi1.txtSiparisurunSayisi.Text + Convert.ToString(KontrolErkek_Ts_Sayisi - 500) + Environment.NewLine;
                    oku3.Close();
                }

                StreamReader oku4 = new StreamReader(@"Erkek_P_DepoStok.txt");
                int KontrolErkek_P_Sayisi = Convert.ToInt32(oku4.ReadToEnd());
                if (KontrolErkek_P_Sayisi == 500) oku4.Close();
                else
                {
                    tedarikçiListesi1.txtSiparisalinanUrun.Text = tedarikçiListesi1.txtSiparisalinanUrun.Text + "Erkek Pantolon" + Environment.NewLine;
                    tedarikçiListesi1.txtSiparisurunSayisi.Text = tedarikçiListesi1.txtSiparisurunSayisi.Text + Convert.ToString(KontrolErkek_P_Sayisi - 500) + Environment.NewLine;
                    oku4.Close();
                }

                StreamReader oku5 = new StreamReader(@"Erkek_STs_DepoStok.txt");
                int KontrolErkek_STs_Sayisi = Convert.ToInt32(oku5.ReadLine());
                if (KontrolErkek_STs_Sayisi == 500) oku5.Close();
                else
                {
                    tedarikçiListesi1.txtSiparisalinanUrun.Text = tedarikçiListesi1.txtSiparisalinanUrun.Text + "Erkek Sweatshirts" + Environment.NewLine;
                    tedarikçiListesi1.txtSiparisurunSayisi.Text = tedarikçiListesi1.txtSiparisurunSayisi.Text + Convert.ToString(KontrolErkek_STs_Sayisi - 500) + Environment.NewLine;
                    oku5.Close();
                }

                StreamReader oku6 = new StreamReader(@"Kadin_Ts_DepoStok.txt");
                int KontrolKadin_Ts_Sayisi = Convert.ToInt32(oku6.ReadLine());
                if (KontrolKadin_Ts_Sayisi == 500) oku6.Close();
                else
                {
                    tedarikçiListesi1.txtSiparisalinanUrun.Text = tedarikçiListesi1.txtSiparisalinanUrun.Text + "Kadin T-Shirts" + Environment.NewLine;
                    tedarikçiListesi1.txtSiparisurunSayisi.Text = tedarikçiListesi1.txtSiparisurunSayisi.Text + Convert.ToString(KontrolKadin_Ts_Sayisi - 500) + Environment.NewLine;
                    oku6.Close();
                }

                StreamReader oku7 = new StreamReader(@"Kadin_P_DepoStok.txt");
                int KontrolKadin_P_Sayisi = Convert.ToInt32(oku7.ReadLine());
                if (KontrolKadin_P_Sayisi == 500) oku7.Close();
                else
                {
                    tedarikçiListesi1.txtSiparisalinanUrun.Text = tedarikçiListesi1.txtSiparisalinanUrun.Text + "Kadin Pantolon" + Environment.NewLine;
                    tedarikçiListesi1.txtSiparisurunSayisi.Text = tedarikçiListesi1.txtSiparisurunSayisi.Text + Convert.ToString(KontrolKadin_P_Sayisi - 500) + Environment.NewLine;
                    oku7.Close();
                }

                StreamReader oku8 = new StreamReader(@"Kadin_STs_DepoStok.txt");
                int KontrolKadin_STs_Sayisi = Convert.ToInt32(oku8.ReadLine());
                if (KontrolKadin_STs_Sayisi == 500) oku8.Close();
                else
                {
                    tedarikçiListesi1.txtSiparisalinanUrun.Text = tedarikçiListesi1.txtSiparisalinanUrun.Text + "Kadin Sweatshirts" + Environment.NewLine;
                    tedarikçiListesi1.txtSiparisurunSayisi.Text = tedarikçiListesi1.txtSiparisurunSayisi.Text + Convert.ToString(KontrolKadin_STs_Sayisi - 500) + Environment.NewLine;
                    oku8.Close();
                }

                StreamReader oku9 = new StreamReader(@"Cocuk_Ts_DepoStok.txt");
                int KontrolCocuk_Ts_Sayisi = Convert.ToInt32(oku9.ReadLine());
                if (KontrolCocuk_Ts_Sayisi == 500) oku9.Close();
                else
                {
                    tedarikçiListesi1.txtSiparisalinanUrun.Text = tedarikçiListesi1.txtSiparisalinanUrun.Text + "Cocuk T-Shirts" + Environment.NewLine;
                    tedarikçiListesi1.txtSiparisurunSayisi.Text = tedarikçiListesi1.txtSiparisurunSayisi.Text + Convert.ToString(KontrolCocuk_Ts_Sayisi - 500) + Environment.NewLine;
                    oku9.Close();
                }

                StreamReader oku10 = new StreamReader(@"Cocuk_P_DepoStok.txt");
                int KontrolCocuk_P_Sayisi = Convert.ToInt32(oku10.ReadLine());
                if (KontrolCocuk_P_Sayisi == 500) oku10.Close();
                else
                {
                    tedarikçiListesi1.txtSiparisalinanUrun.Text = tedarikçiListesi1.txtSiparisalinanUrun.Text + "Cocuk Pantolon" + Environment.NewLine;
                    tedarikçiListesi1.txtSiparisurunSayisi.Text = tedarikçiListesi1.txtSiparisurunSayisi.Text + Convert.ToString(KontrolCocuk_P_Sayisi - 500) + Environment.NewLine;
                    oku10.Close();
                }

                StreamReader oku11 = new StreamReader(@"Cocuk_STs_DepoStok.txt");
                int KontrolCocuk_STs_Sayisi = Convert.ToInt32(oku11.ReadLine());
                if (KontrolCocuk_STs_Sayisi == 500) oku11.Close();
                else
                {
                    tedarikçiListesi1.txtSiparisalinanUrun.Text = tedarikçiListesi1.txtSiparisalinanUrun.Text + "Cocuk Sweatshirts" + Environment.NewLine;
                    tedarikçiListesi1.txtSiparisurunSayisi.Text = tedarikçiListesi1.txtSiparisurunSayisi.Text + Convert.ToString(KontrolCocuk_STs_Sayisi - 500) + Environment.NewLine;
                    oku11.Close();
                }

                tedarikçiListesi1.txtSiparisalinanUrun.Text += "-------------------------";
                tedarikçiListesi1.txtSiparisurunSayisi.Text += "-------------------------";
                oku1.Close();
                oku2.Close();
                oku3.Close();
                oku4.Close();
                oku5.Close();
                oku6.Close();
                oku7.Close();
                oku8.Close();
                oku9.Close();
                oku10.Close();
                oku11.Close();
            }

            tedarikçiListesi1.ShowDialog();

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MusteriGirisEkrani musterigirisform = new MusteriGirisEkrani();
            musterigirisform.Show();

            

        }
    }
}
