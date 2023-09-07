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
    public partial class StokForm : Form
    {
        public StokForm()
        {
            InitializeComponent();
        }

        

        private void lblBaslik2_Click(object sender, EventArgs e)
        {

        }

        private void StokForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStokRaf_Click_1(object sender, EventArgs e)
        {
            RafdakiStokForm rafdakistok1 = new RafdakiStokForm();
            
            FileStream fs1 = new FileStream(@"Erkek_Ts_Stok.txt", FileMode.Open);
            StreamReader oku1 = new StreamReader(fs1);
            rafdakistok1.txt_Erkek_Ts_stok.Text = oku1.ReadLine();
            oku1.Close();
            FileStream fs2 = new FileStream(@"Erkek_P_Stok.txt", FileMode.Open);
            StreamReader oku2 = new StreamReader(fs2);
            rafdakistok1.txt_Erkek_P_stok.Text = oku2.ReadLine();
            oku2.Close();
            FileStream fs3 = new FileStream(@"Erkek_STs_Stok.txt", FileMode.Open);
            StreamReader oku3 = new StreamReader(fs3);
            rafdakistok1.txt_Erkek_STs_stok.Text = oku3.ReadLine();
            oku3.Close();
            FileStream fs4 = new FileStream(@"Kadin_Ts_Stok.txt", FileMode.Open);
            StreamReader oku4 = new StreamReader(fs4);
            rafdakistok1.txt_Kadin_Ts_stok.Text = oku4.ReadLine();
            oku4.Close();
            FileStream fs5 = new FileStream(@"Kadin_P_Stok.txt", FileMode.Open);
            StreamReader oku5 = new StreamReader(fs5);
            rafdakistok1.txt_Kadin_P_stok.Text = oku5.ReadLine();
            oku5.Close();
            FileStream fs6 = new FileStream(@"Kadin_STs_Stok.txt", FileMode.Open);
            StreamReader oku6 = new StreamReader(fs6);
            rafdakistok1.txt_Kadin_STs_stok.Text = oku6.ReadLine();
            oku6.Close();
            FileStream fs7 = new FileStream(@"Cocuk_Ts_Stok.txt", FileMode.Open);
            StreamReader oku7 = new StreamReader(fs7);
            rafdakistok1.txt_Cocuk_Ts_stok.Text = oku7.ReadLine();
            oku7.Close();
            FileStream fs8 = new FileStream(@"Cocuk_P_Stok.txt", FileMode.Open);
            StreamReader oku8 = new StreamReader(fs8);
            rafdakistok1.txt_Cocuk_P_stok.Text = oku8.ReadLine();
            oku8.Close();
            FileStream fs9 = new FileStream(@"Cocuk_STs_Stok.txt", FileMode.Open);
            StreamReader oku9 = new StreamReader(fs9);
            rafdakistok1.txt_Cocuk_STs_stok.Text = oku9.ReadLine();
            oku9.Close();

            rafdakistok1.Show();

        }

        private void btnStokDepo_Click(object sender, EventArgs e)
        {
            DepodakiStokForm depodakistok1 = new DepodakiStokForm();
            

            FileStream fs1 = new FileStream(@"Erkek_Ts_DepoStok.txt", FileMode.Open);
            StreamReader oku1 = new StreamReader(fs1);
            depodakistok1.txtR_Erkek_Ts_stok.Text = oku1.ReadLine();
            oku1.Close();
            FileStream fs2 = new FileStream(@"Erkek_P_DepoStok.txt", FileMode.Open);
            StreamReader oku2 = new StreamReader(fs2);
            depodakistok1.txtR_Erkek_P_stok.Text = oku2.ReadLine();
            oku2.Close();
            FileStream fs3 = new FileStream(@"Erkek_STs_DepoStok.txt", FileMode.Open);
            StreamReader oku3 = new StreamReader(fs3);
            depodakistok1.txtR_Erkek_STs_stok.Text = oku3.ReadLine();
            oku3.Close();
            FileStream fs4 = new FileStream(@"Kadin_Ts_DepoStok.txt", FileMode.Open);
            StreamReader oku4 = new StreamReader(fs4);
            depodakistok1.txtR_Kadin_Ts_stok.Text = oku4.ReadLine();
            oku4.Close();
            FileStream fs5 = new FileStream(@"Kadin_P_DepoStok.txt", FileMode.Open);
            StreamReader oku5 = new StreamReader(fs5);
            depodakistok1.txtR_Kadin_P_stok.Text = oku5.ReadLine();
            oku5.Close();
            FileStream fs6 = new FileStream(@"Kadin_STs_DepoStok.txt", FileMode.Open);
            StreamReader oku6 = new StreamReader(fs6);
            depodakistok1.txtR_Kadin_STs_stok.Text = oku6.ReadLine();
            oku6.Close();
            FileStream fs7 = new FileStream(@"Cocuk_Ts_DepoStok.txt", FileMode.Open);
            StreamReader oku7 = new StreamReader(fs7);
            depodakistok1.txtR_Cocuk_Ts_stok.Text = oku7.ReadLine();
            oku7.Close();
            FileStream fs8 = new FileStream(@"Cocuk_P_DepoStok.txt", FileMode.Open);
            StreamReader oku8 = new StreamReader(fs8);
            depodakistok1.txtR_Cocuk_P_stok.Text = oku8.ReadLine();
            oku8.Close();
            FileStream fs9 = new FileStream(@"Cocuk_STs_DepoStok.txt", FileMode.Open);
            StreamReader oku9 = new StreamReader(fs9);
            depodakistok1.txtR_Cocuk_STs_stok.Text = oku9.ReadLine();
            oku9.Close();

            depodakistok1.ShowDialog();
        }
    }
}
