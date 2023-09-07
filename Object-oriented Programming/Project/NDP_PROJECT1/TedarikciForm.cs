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
    public partial class TedarikciForm : Form
    {
        public TedarikciForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepodakiStokForm depoo = new DepodakiStokForm();
            DepodakiStokForm depodakistok1 = new DepodakiStokForm();
            FileStream fs1 = new FileStream(@"Erkek_Ts_DepoStok.txt", FileMode.Open);
            StreamReader oku1 = new StreamReader(fs1);
            depodakistok1.txtR_Erkek_Ts_stok.Text = oku1.ReadLine();
            oku1.Close();
            fs1.Close();
            FileStream fs2 = new FileStream(@"Erkek_P_DepoStok.txt", FileMode.Open);
            StreamReader oku2 = new StreamReader(fs2);
            depodakistok1.txtR_Erkek_P_stok.Text = oku2.ReadLine();
            oku2.Close();
            fs2.Close();
            FileStream fs3 = new FileStream(@"Erkek_STs_DepoStok.txt", FileMode.Open);
            StreamReader oku3 = new StreamReader(fs3);
            depodakistok1.txtR_Erkek_STs_stok.Text = oku3.ReadLine();
            oku3.Close();
            fs3.Close();
            FileStream fs4 = new FileStream(@"Kadin_Ts_DepoStok.txt", FileMode.Open);
            StreamReader oku4 = new StreamReader(fs4);
            depodakistok1.txtR_Kadin_Ts_stok.Text = oku4.ReadLine();
            oku4.Close();
            fs4.Close();
            FileStream fs5 = new FileStream(@"Kadin_P_DepoStok.txt", FileMode.Open);
            StreamReader oku5 = new StreamReader(fs5);
            depodakistok1.txtR_Kadin_P_stok.Text = oku5.ReadLine();
            oku5.Close();
            fs5.Close();
            FileStream fs6 = new FileStream(@"Kadin_STs_DepoStok.txt", FileMode.Open);
            StreamReader oku6 = new StreamReader(fs6);
            depodakistok1.txtR_Kadin_STs_stok.Text = oku6.ReadLine();
            oku6.Close();
            fs6.Close();
            FileStream fs7 = new FileStream(@"Cocuk_Ts_DepoStok.txt", FileMode.Open);
            StreamReader oku7 = new StreamReader(fs7);
            depodakistok1.txtR_Cocuk_Ts_stok.Text = oku7.ReadLine();
            oku7.Close();
            fs7.Close();
            FileStream fs8 = new FileStream(@"Cocuk_P_DepoStok.txt", FileMode.Open);
            StreamReader oku8 = new StreamReader(fs8);
            depodakistok1.txtR_Cocuk_P_stok.Text = oku8.ReadLine();
            oku8.Close();
            fs8.Close();
            FileStream fs9 = new FileStream(@"Cocuk_STs_DepoStok.txt", FileMode.Open);
            StreamReader oku9 = new StreamReader(fs9);
            depodakistok1.txtR_Cocuk_STs_stok.Text = oku9.ReadLine();
            oku9.Close();
            fs9.Close();

            string Erkek_Ts_Siparissayisi = (txt_Erkek_Ts_Siparis.Text);
            string Erkek_P_Siparissayisi = (txt_Erkek_P_Siparis.Text);
            string Erkek_STs_Siparissayisi = (txt_Erkek_STs_Siparis.Text);
            string Kadin_Ts_Siparissayisi = (txt_Kadin_Ts_Siparis.Text);
            string Kadin_P_Siparissayisi = (txt_Kadin_P_Siparis.Text);
            string Kadin_STs_Siparissayisi = (txt_Kadin_STs_Siparis.Text);
            string Cocuk_Ts_Siparissayisi = (txt_Cocuk_Ts_Siparis.Text);
            string Cocuk_P_Siparissayisi = (txt_Cocuk_P_Siparis.Text);
            string Cocuk_STs_Siparissayisi = (txt_Cocuk_STs_Siparis.Text);

            int YeniStok1 = Convert.ToInt32(depodakistok1.txtR_Erkek_Ts_stok.Text);
            int YeniStok2 = Convert.ToInt32(depodakistok1.txtR_Erkek_P_stok.Text);
            int YeniStok3 = Convert.ToInt32(depodakistok1.txtR_Erkek_STs_stok.Text);
            int YeniStok4 = Convert.ToInt32(depodakistok1.txtR_Kadin_Ts_stok.Text);
            int YeniStok5 = Convert.ToInt32(depodakistok1.txtR_Kadin_P_stok.Text);
            int YeniStok6 = Convert.ToInt32(depodakistok1.txtR_Kadin_STs_stok.Text);
            int YeniStok7 = Convert.ToInt32(depodakistok1.txtR_Cocuk_Ts_stok.Text);
            int YeniStok8 = Convert.ToInt32(depodakistok1.txtR_Cocuk_P_stok.Text);
            int YeniStok9 = Convert.ToInt32(depodakistok1.txtR_Cocuk_STs_stok.Text);

            YeniStok1 += Convert.ToInt32(Erkek_Ts_Siparissayisi);
            YeniStok2 += Convert.ToInt32(Erkek_P_Siparissayisi);
            YeniStok3 += Convert.ToInt32(Erkek_STs_Siparissayisi);
            YeniStok4 += Convert.ToInt32(Kadin_Ts_Siparissayisi);
            YeniStok5 += Convert.ToInt32(Kadin_P_Siparissayisi);
            YeniStok6 += Convert.ToInt32(Kadin_STs_Siparissayisi);
            YeniStok7 += Convert.ToInt32(Cocuk_Ts_Siparissayisi);
            YeniStok8 += Convert.ToInt32(Cocuk_P_Siparissayisi);
            YeniStok9 += Convert.ToInt32(Cocuk_STs_Siparissayisi);

            FileStream fss1 = new FileStream(@"Erkek_Ts_DepoStok.txt", FileMode.Open);
            StreamWriter yaz1 = new StreamWriter(fss1);
            yaz1.WriteLine(YeniStok1);
            yaz1.Close();
            fss1.Close();

            FileStream fss2 = new FileStream(@"Erkek_P_DepoStok.txt", FileMode.Open);
            StreamWriter yaz2 = new StreamWriter(fss2);
            yaz2.WriteLine(YeniStok2);
            yaz2.Close();
            fss2.Close();

            FileStream fss3 = new FileStream(@"Erkek_STs_DepoStok.txt", FileMode.Open);
            StreamWriter yaz3 = new StreamWriter(fss3);
            yaz3.WriteLine(YeniStok3);
            yaz3.Close();
            fss3.Close();

            FileStream fss4 = new FileStream(@"Kadin_Ts_DepoStok.txt", FileMode.Open);
            StreamWriter yaz4 = new StreamWriter(fss4);
            yaz4.WriteLine(YeniStok4);
            yaz4.Close();
            fss4.Close();

            FileStream fss5 = new FileStream(@"Kadin_P_DepoStok.txt", FileMode.Open);
            StreamWriter yaz5 = new StreamWriter(fss5);
            yaz5.WriteLine(YeniStok5);
            yaz5.Close();
            fss5.Close();

            FileStream fss6 = new FileStream(@"Kadin_STs_DepoStok.txt", FileMode.Open);
            StreamWriter yaz6 = new StreamWriter(fss6);
            yaz6.WriteLine(YeniStok6);
            yaz6.Close();
            fss6.Close();

            FileStream fss7 = new FileStream(@"Cocuk_Ts_DepoStok.txt", FileMode.Open);
            StreamWriter yaz7 = new StreamWriter(fss7);
            yaz7.WriteLine(YeniStok7);
            yaz7.Close();
            fss7.Close();

            FileStream fss8 = new FileStream(@"Cocuk_P_DepoStok.txt", FileMode.Open);
            StreamWriter yaz8 = new StreamWriter(fss8);
            yaz8.WriteLine(YeniStok8);
            yaz8.Close();
            fss8.Close();

            FileStream fss9 = new FileStream(@"Cocuk_STs_DepoStok.txt", FileMode.Open);
            StreamWriter yaz9 = new StreamWriter(fss9);
            yaz9.WriteLine(YeniStok9);
            yaz9.Close();
            fss9.Close();

            MessageBox.Show("Siparisiniz alindi ve stok Eklendi:");

            this.Close();
        }
    }
}
