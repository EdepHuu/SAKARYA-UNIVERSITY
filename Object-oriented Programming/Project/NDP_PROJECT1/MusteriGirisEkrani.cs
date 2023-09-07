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
    public partial class MusteriGirisEkrani : Form
    {
        public MusteriGirisEkrani()
        {
            InitializeComponent();
        }

        private void lblsoyad_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblad_Click(object sender, EventArgs e)
        {

        }

        private void MusteriGirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnAlısveris_Click(object sender, EventArgs e)
        {
            Musteri_icin_Form musteriform = new Musteri_icin_Form();

            FileStream fs1 = new FileStream(@"Musteri_Adi.txt", FileMode.Open);
            StreamReader okuu1 = new StreamReader(fs1);
            StreamWriter yaz1 = new StreamWriter(fs1);
            okuu1.ReadToEnd();
            yaz1.Write(txtAd.Text + Environment.NewLine + "-------------------------" + Environment.NewLine + okuu1.ReadToEnd());
            yaz1.Close();
            okuu1.Close();
            fs1.Close();

            FileStream fs2 = new FileStream(@"Musteri_Soyadi.txt", FileMode.Open);
            StreamReader okuu2 = new StreamReader(fs2);
            StreamWriter yaz2 = new StreamWriter(fs2);
            okuu2.ReadToEnd();
            yaz2.Write(txtSoyAd.Text + Environment.NewLine  + "-------------------------" + Environment.NewLine + okuu2.ReadToEnd());
            yaz2.Close();
            okuu2.Close();
            fs2.Close();

            StreamReader oku1 = new StreamReader(@"Erkek_Ts_Stok.txt");
            musteriform.lbl_Erkek_Ts_Stok.Text = oku1.ReadLine();
            oku1.Close();
            StreamReader oku2 = new StreamReader(@"Erkek_P_Stok.txt");
            musteriform.lbl_Erkek_P_Stok.Text = oku2.ReadLine();
            oku2.Close();
            StreamReader oku3 = new StreamReader(@"Erkek_STs_Stok.txt");
            musteriform.lbl_Erkek_STs_Stok.Text = oku3.ReadLine();
            oku3.Close();
            StreamReader oku4 = new StreamReader(@"Kadin_Ts_Stok.txt");
            musteriform.lbl_Kadin_Ts_Stok.Text = oku4.ReadLine();
            oku4.Close();
            StreamReader oku5 = new StreamReader(@"Kadin_P_Stok.txt");
            musteriform.lbl_Kadin_P_Stok.Text = oku5.ReadLine();
            oku5.Close();
            StreamReader oku6 = new StreamReader(@"Kadin_STs_Stok.txt");
            musteriform.lbl_Kadin_STs_Stok.Text = oku6.ReadLine();
            oku6.Close();
            StreamReader oku7 = new StreamReader(@"Cocuk_Ts_Stok.txt");
            musteriform.lbl_Cocuk_Ts_Stok.Text = oku7.ReadLine();
            oku7.Close();
            StreamReader oku8 = new StreamReader(@"Cocuk_P_Stok.txt");
            musteriform.lbl_Cocuk_P_Stok.Text = oku8.ReadLine();
            oku8.Close();
            StreamReader oku9 = new StreamReader(@"Cocuk_STs_Stok.txt");
            musteriform.lbl_Cocuk_STs_Stok.Text = oku9.ReadLine();
            oku9.Close();
            musteriform.Show();
        }
    }
}
