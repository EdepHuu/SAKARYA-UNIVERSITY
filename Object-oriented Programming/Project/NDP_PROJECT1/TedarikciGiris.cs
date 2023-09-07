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
    public partial class TedarikciGiris : Form
    {
        public TedarikciGiris()
        {
            InitializeComponent();
        }

        private void btnileri_Click(object sender, EventArgs e)
        {
            
            FileStream fs1 = new FileStream(@"Firma_Adi.txt", FileMode.Open);
            StreamWriter yaz1 = new StreamWriter(fs1);
            yaz1.WriteLine(txtFirmaAd.Text);
            yaz1.Close();
            fs1.Close();

            FileStream fs2 = new FileStream(@"Firma_No.txt", FileMode.Open);
            StreamWriter yaz2 = new StreamWriter(fs2);
            yaz2.WriteLine(txtFirmaNo.Text);
            yaz2.Close();
            fs2.Close();

            TedarikciForm tedarikciform = new TedarikciForm();

            StreamReader oku1 = new StreamReader(@"Erkek_Ts_DepoStok.txt");
            tedarikciform.lbl_Erkek_Ts_Stok.Text = oku1.ReadLine();
            oku1.Close();
            StreamReader oku2 = new StreamReader(@"Erkek_P_DepoStok.txt");
            tedarikciform.lbl_Erkek_P_Stok.Text = oku2.ReadLine();
            oku2.Close();
            StreamReader oku3 = new StreamReader(@"Erkek_STs_DepoStok.txt");
            tedarikciform.lbl_Erkek_STs_Stok.Text = oku3.ReadLine();
            oku3.Close();
            StreamReader oku4 = new StreamReader(@"Kadin_Ts_DepoStok.txt");
            tedarikciform.lbl_Kadin_Ts_Stok.Text = oku4.ReadLine();
            oku4.Close();
            StreamReader oku5 = new StreamReader(@"Kadin_P_DepoStok.txt");
            tedarikciform.lbl_Kadin_P_Stok.Text = oku5.ReadLine();
            oku5.Close();
            StreamReader oku6 = new StreamReader(@"Kadin_STs_DepoStok.txt");
            tedarikciform.lbl_Kadin_STs_Stok.Text = oku6.ReadLine();
            oku6.Close();
            StreamReader oku7 = new StreamReader(@"Cocuk_Ts_DepoStok.txt");
            tedarikciform.lbl_Cocuk_Ts_Stok.Text = oku7.ReadLine();
            oku7.Close();
            StreamReader oku8 = new StreamReader(@"Cocuk_P_DepoStok.txt");
            tedarikciform.lbl_Cocuk_P_Stok.Text = oku8.ReadLine();
            oku8.Close();
            StreamReader oku9 = new StreamReader(@"Cocuk_STs_DepoStok.txt");
            tedarikciform.lbl_Cocuk_STs_Stok.Text = oku9.ReadLine();
            oku9.Close();

            tedarikciform.ShowDialog();
        }
    }
}
