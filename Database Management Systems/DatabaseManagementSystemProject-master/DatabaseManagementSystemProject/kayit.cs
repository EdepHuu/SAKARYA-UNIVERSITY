using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementSystemProject
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }


        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=DbComputerFactoryManagementSystem;user ID=postgres;password=Edephuuu4949");


        private void kayitol_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand varMi = new NpgsqlCommand("Select COUNT(kullaniciadi) from public.giris WHERE kullaniciadi='" + kadi.Text + "'", baglan);
            int sonuc = Convert.ToInt32(varMi.ExecuteScalar());
            

            if (sonuc != 1)
            {


                NpgsqlCommand ekle = new NpgsqlCommand("insert into public.giris (kullaniciadi,sifre) values (@p1,@p2)", baglan);

                ekle.Parameters.AddWithValue("@p1", kadi.Text);
                ekle.Parameters.AddWithValue("@p2", sifre.Text);
                ekle.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı");
                this.Hide();


            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı zaten var");
            }
            baglan.Close();

        }

        private void kayit_Load(object sender, EventArgs e)
        {
            if(kadi.Text == "" && sifre.Text == "")
            {
                kayitol.Enabled = false;
            }
           
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            if (kadi.Text != "" && sifre.Text != "")
            {
                kayitol.Enabled = true;
            }
        }
    }
}
