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
    public partial class Ekrankarti : Form
    {
        public Ekrankarti()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=DbComputerFactoryManagementSystem;user ID=postgres;password=Edephuuu4949");
        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.ekrankarti ";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekekle_Click(object sender, EventArgs e)
        {

            baglan.Open();
            NpgsqlCommand varMi = new NpgsqlCommand("Select COUNT(ekrankartiurunkodu) from public.ekrankarti WHERE ekrankartiurunkodu='" + ekranid.Text + "'", baglan);
            int sonuc = Convert.ToInt32(varMi.ExecuteScalar());
            if (sonuc != 1)
            {
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into public.ekrankarti (ekrankartiurunkodu,marka,bellekkapasitesi,uretici,gputuru) values (@p1,@p2,@p3,@p4,@p5) ", baglan);
                ekleme.Parameters.AddWithValue("@p1", ekranid.Text);
                ekleme.Parameters.AddWithValue("@p2", marka.Text);
                ekleme.Parameters.AddWithValue("@p3", int.Parse(bellek.Text));
                ekleme.Parameters.AddWithValue("@p4", uretici.Text);
                ekleme.Parameters.AddWithValue("@p5", tur.Text);
                

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
                ekranid.Text = "";

            }
            else
            {
                MessageBox.Show("Bu Ekran Kartı Ürün Kodu zaten var");
            }
            baglan.Close();

        }

        private void eksil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from public.ekrankarti where ekrankartiurunkodu=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", ekranid.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ekranid.Text = "";
        }

        private void Ekrankarti_Load(object sender, EventArgs e)
        {
            if (ekranid.Text == "" && marka.Text == "" && bellek.Text == "" && uretici.Text == "" && tur.Text == "" )
            {
                ekekle.Enabled = false;
            }
            if (ekranid.Text == "")
            {
                eksil.Enabled = false;
            }
        }

        private void ekranid_TextChanged(object sender, EventArgs e)
        {
            if (ekranid.Text != "" && marka.Text != "" && bellek.Text != "" && uretici.Text != "" && tur.Text != "")
            {
                ekekle.Enabled = true;
            }
            if (ekranid.Text != "")
            {
                eksil.Enabled = true;
            }
        }

        private void bellek_TextChanged(object sender, EventArgs e)
        {
            if (ekranid.Text != "" && marka.Text != "" && bellek.Text != "" && uretici.Text != "" && tur.Text != "")
            {
                ekekle.Enabled = true;
            }
        }

        private void marka_TextChanged(object sender, EventArgs e)
        {
            if (ekranid.Text != "" && marka.Text != "" && bellek.Text != "" && uretici.Text != "" && tur.Text != "")
            {
                ekekle.Enabled = true;
            }
        }

        private void uretici_TextChanged(object sender, EventArgs e)
        {
            if (ekranid.Text != "" && marka.Text != "" && bellek.Text != "" && uretici.Text != "" && tur.Text != "")
            {
                ekekle.Enabled = true;
            }
        }

        private void tur_TextChanged(object sender, EventArgs e)
        {
            if (ekranid.Text != "" && marka.Text != "" && bellek.Text != "" && uretici.Text != "" && tur.Text != "")
            {
                ekekle.Enabled = true;
            }
        }
    }
}
