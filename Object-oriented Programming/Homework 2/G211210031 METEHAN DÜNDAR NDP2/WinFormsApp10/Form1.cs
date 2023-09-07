/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2021-2022 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:2
** ÖĞRENCİ ADI............:METEHAN DÜNDAR
** ÖĞRENCİ NUMARASI.......:G211210031
** DERSİN ALINDIĞI GRUP...:2-B
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

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.AcceptButton = btnHesapla;  // Form uzerinde entera basinca btnHesapla butonu calissin diye yazdigmiz kod.
            InitializeComponent();
        }

        // Bu kisimda textbox buton ve labellerimizi olusturuyoruz.
        Button btnHesapla = new Button();
        Button textboxtemizle = new Button();
        Label lblsayi = new Label();
        Label lblYazi = new Label();
        TextBox txtSayi = new TextBox();
        Label lblYazilisi = new Label();

        public void BtnHesapla_Click(object sender, EventArgs e)
        {
            // bu kisimda textboxda ondalik kismi nokta ile yazilirsa yeni bir string tanimlayip onun uzerinden virgule ceviriyoruz
            string sayii = txtSayi.Text.ToString();
            sayii = sayii.Replace('.', ',');
            // bu kisimda da lblYazilisi kisminda sayinin yazilisini gormek icin aldigimiz sayii degerini yaziyacevir fonksiyonuna gönderiyoruz.
            lblYazilisi.Text = yaziyaCevir(Convert.ToDecimal(sayii));
        }
        
        private void Textboxtemizle_Click(object sender, EventArgs e)
        {
            txtSayi.Clear();  // textbox temizle butonuna basildiginda textbox temizleniyor.
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Bu kisimda textbox buton ve labellarimizin; buyukluk, formdaki yeri, rengi vb. gibi ozelliklerini ayarliyoruz.
            this.BackColor = Color.Black;

            btnHesapla.Font = new Font(Font, FontStyle.Bold);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Text = "HESAPLA";
            btnHesapla.Size = new Size(114, 58);
            btnHesapla.Location = new Point(171, 292);
            btnHesapla.BackColor = Color.White;
            this.Controls.Add(btnHesapla);
            btnHesapla.Click += BtnHesapla_Click;  // btnhesapla metodunu acmak icin.
            
            textboxtemizle.Font = new Font(Font, FontStyle.Bold);
            textboxtemizle.Name = "textboxTemizle";
            textboxtemizle.Text = "TEXTBOX TEMİZLE";
            textboxtemizle.Size = new Size(100, 40);
            textboxtemizle.Location = new Point(430, 47);
            textboxtemizle.BackColor = Color.White;
            this.Controls.Add(textboxtemizle);    
            textboxtemizle.Click += Textboxtemizle_Click;  // textbox temizle metodunu acmak icin.

            lblsayi.Font = new Font(lblsayi.Font, lblsayi.Font.Style ^ FontStyle.Bold);
            lblsayi.Name = "lblSayi";
            lblsayi.Text = "Sayi";
            lblsayi.Size = new Size(87, 53);
            lblsayi.Location = new Point(75, 47);        
            lblsayi.BackColor = Color.Coral;
            this.Controls.Add(lblsayi);
            lblsayi.TextAlign = ContentAlignment.MiddleCenter;


            lblYazi.Font = new Font(lblYazi.Font, lblYazi.Font.Style ^ FontStyle.Bold);
            lblYazi.Name = "lblYazi";
            lblYazi.Text = "Yazi";
            lblYazi.Size = new Size(87, 53);
            lblYazi.Location = new Point(75, 171);         
            lblYazi.BackColor = Color.Coral;
            this.Controls.Add(lblYazi);
            lblYazi.TextAlign = ContentAlignment.MiddleCenter;


            txtSayi.Name = "txtSayi";
            txtSayi.Text = "";
            txtSayi.Size = new Size(126, 43);
            txtSayi.Location = new Point(295, 47);
            txtSayi.BackColor = Color.Coral;
            txtSayi.KeyPress += TxtSayi_KeyPress;  // txtbox keypress metdounu acmak icin.
            this.Controls.Add(txtSayi);

      
            lblYazilisi.Font = new Font(lblYazilisi.Font, lblYazilisi.Font.Style ^ FontStyle.Bold);
            lblYazilisi.Name = "lblYazilisi";
            _ = lblYazilisi.Text;
            lblYazilisi.Size = new Size(150, 53);
            lblYazilisi.Location = new Point(295, 171);
            this.Controls.Add(lblYazilisi);
            lblYazilisi.BackColor = Color.Coral;
            lblYazilisi.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void TxtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // textboxa nokta virgul ve rakam disinda karakter girisi yapilmamini sagliyoruz.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';


            // textboxa 5 basamak sayi, 1 basamak nokta veya virgul, 2 basamak virgulden sonraki kisim icin max karakter girisini sinirlandiriyoruz.
            if(txtSayi.Text.Length > 7)
            {
                MessageBox.Show("Maksimim karakteri astiniz!");
                Close();
            }
        }
        private string yaziyaCevir(decimal tutar)
        {
            // labela yazdirma islemleri yapiliyor.
            string sTutar = tutar.ToString("F2");
            string lira = sTutar.Substring(0, sTutar.IndexOf(',')); // girdigimiz tutarin lira kismini aliyoruz.
            int liraBasSayisi = Convert.ToInt32(lira);
            int liraBasSayisi2 = 0;
            // lira kismi max 5 basamak olacak bu yüzden burda for dongusu acip lira kisminin kac basamak oldugunu kontrol ediyoruz.
            while (liraBasSayisi > 0)
            {
                liraBasSayisi /= 10;
                liraBasSayisi2++;
            }
            // lira kisminin (virgul veya noktadan onceki kisim) basamak sayisi 5 den fazla olursa messagebox ile uyari veriyoruz.
            if (liraBasSayisi2 > 5)
            {
                MessageBox.Show("Lira kismi max 5 basamakli olabilir.");
                Close();
            }

            // virgulden sonraki kismi kurus olarak aliyoruz.
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);

            string yazi = "";


            string[] birler = { "", " BİR", " İKİ", " ÜÇ", " DÖRT", " BEŞ", " ALTI", " YEDİ", " SEKİZ", " DOKUZ" };
            string[] onlar = { "", " ON", " YİRMİ", " OTUZ", " KIRK", " ELLİ", " ALTMIŞ", " YETMİŞ", " SEKSEN", " DOKSAN" };
            string[] binler = { " KATRİLYON", " TRİLYON", " MİLYAR", " MİLYON", " BİN", "" };

            int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. 


            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + " YÜZ"; //yüzler                

                if (grupDegeri == " BİR YÜZ") //bir yüz kismi düzeltiliyor.
                    grupDegeri = " YÜZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "") //binler
                    grupDegeri += binler[i / 3];

                if (grupDegeri == " BİR BİN") //bir bin kismi düzeltiliyor.
                    grupDegeri = " BİN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " KURUŞ.";
            else
                yazi += "SIFIR KURUŞ.";

            return yazi;
        }
    }
}
