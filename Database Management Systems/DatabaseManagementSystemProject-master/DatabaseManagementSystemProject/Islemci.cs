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
    public partial class Islemci : Form
    {
        public Islemci()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=DbComputerFactoryManagementSystem;user ID=postgres;password=Edephuuu4949");
        private void ekekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand varMi = new NpgsqlCommand("Select COUNT(islemciurunkodu) from public.islemci WHERE islemciurunkodu='" + islemciid.Text + "'", baglan);
            int sonuc = Convert.ToInt32(varMi.ExecuteScalar());
            if (sonuc != 1)
            {
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into public.islemci (islemciurunkodu,cekirdeksayisi,onbellekkapasitesi,modelturu,marka,model) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglan);
                ekleme.Parameters.AddWithValue("@p1", islemciid.Text);
                ekleme.Parameters.AddWithValue("@p2", int.Parse(cekirdek.Text));
                ekleme.Parameters.AddWithValue("@p3", int.Parse(bellek.Text));
                ekleme.Parameters.AddWithValue("@p4", tur.Text);
                ekleme.Parameters.AddWithValue("@p5", marka.Text);
                ekleme.Parameters.AddWithValue("@p6", model.Text);


                ekleme.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Eklendi.");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                islemciid.Text = "";

            }
            else
            {
                MessageBox.Show("Bu İşlemci Ürün Kodu zaten var");
            }
            baglan.Close();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.islemci ";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void eksil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from public.islemci where islemciurunkodu=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", islemciid.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            islemciid.Text = "";
        }

        private void Islemci_Load(object sender, EventArgs e)
        {
            if (islemciid.Text == "" && marka.Text == "" && bellek.Text == "" && model.Text == "" && tur.Text == "" && cekirdek.Text == "")
            {
                ekle.Enabled = false;
            }
            if (islemciid.Text == "")
            {
                sil.Enabled = false;
            }
        }

        private void islemciid_TextChanged(object sender, EventArgs e)
        {
            if (islemciid.Text != "" && marka.Text != "" && bellek.Text != "" && model.Text != "" && tur.Text != ""&& cekirdek.Text!="")
            {
                ekle.Enabled = true;
            }
            if (islemciid.Text != "")
            {
                sil.Enabled = true;
            }
        }

        private void cekirdek_TextChanged(object sender, EventArgs e)
        {
            if (islemciid.Text != "" && marka.Text != "" && bellek.Text != "" && model.Text != "" && tur.Text != "" && cekirdek.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void tur_TextChanged(object sender, EventArgs e)
        {
            if (islemciid.Text != "" && marka.Text != "" && bellek.Text != "" && model.Text != "" && tur.Text != "" && cekirdek.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void bellek_TextChanged(object sender, EventArgs e)
        {
            if (islemciid.Text != "" && marka.Text != "" && bellek.Text != "" && model.Text != "" && tur.Text != "" && cekirdek.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void marka_TextChanged(object sender, EventArgs e)
        {
            if (islemciid.Text != "" && marka.Text != "" && bellek.Text != "" && model.Text != "" && tur.Text != "" && cekirdek.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void model_TextChanged(object sender, EventArgs e)
        {
            if (islemciid.Text != "" && marka.Text != "" && bellek.Text != "" && model.Text != "" && tur.Text != "" && cekirdek.Text != "")
            {
                ekle.Enabled = true;
            }
        }
    }
}
