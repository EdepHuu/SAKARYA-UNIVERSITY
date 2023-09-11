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
    public partial class Klavye : Form
    {
        public Klavye()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=DbComputerFactoryManagementSystem;user ID=postgres;password=Edephuuu4949");
        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.klavye ";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand varMi = new NpgsqlCommand("Select COUNT(klavyeurunkodu) from public.klavye WHERE klavyeurunkodu='" + klavyeid.Text + "'", baglan);
            int sonuc = Convert.ToInt32(varMi.ExecuteScalar());
            if (sonuc != 1)
            {
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into public.monitor (klavyeurunkodu,klavyeturu,klavyetipi,tussayisi) values (@p1,@p2,@p3,@p4) ", baglan);
                ekleme.Parameters.AddWithValue("@p1", klavyeid.Text);
                ekleme.Parameters.AddWithValue("@p2", tur.Text);
                ekleme.Parameters.AddWithValue("@p3", tip.Text);
                ekleme.Parameters.AddWithValue("@p4", int.Parse(tus.Text));



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
                klavyeid.Text = "";

            }
            else
            {
                MessageBox.Show("Bu Klavye Ürün Kodu zaten var");
            }
            baglan.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from public.klavye where klavyeurunkodu=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", klavyeid.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            klavyeid.Text = "";
        }

        private void Klavye_Load(object sender, EventArgs e)
        {
            ekle.Enabled = false;
            sil.Enabled = false;
        }

        private void klavyeid_TextChanged(object sender, EventArgs e)
        {
            if (klavyeid.Text != "" && tip.Text != "" && tur.Text != "" && tus.Text != "")
            {
                ekle.Enabled = true;
            }
            if (klavyeid.Text != "")
            {
                sil.Enabled = true;
            }
        }

        private void tip_TextChanged(object sender, EventArgs e)
        {
            if (klavyeid.Text != "" && tip.Text != "" && tur.Text != "" && tus.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void tur_TextChanged(object sender, EventArgs e)
        {
            if (klavyeid.Text != "" && tip.Text != "" && tur.Text != "" && tus.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void tuş_TextChanged(object sender, EventArgs e)
        {
            if (klavyeid.Text != "" && tip.Text != "" && tur.Text != "" && tus.Text != "")
            {
                ekle.Enabled = true;
            }
        }
    }
}
