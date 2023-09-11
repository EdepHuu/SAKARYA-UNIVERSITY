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
    public partial class SSD : Form
    {
        public SSD()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=DbComputerFactoryManagementSystem;user ID=postgres;password=Edephuuu4949");
        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.ssd ";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand varMi = new NpgsqlCommand("Select COUNT(ssdurunkodu) from public.ssd WHERE ssdurunkodu='" + ssdid.Text + "'", baglan);
            int sonuc = Convert.ToInt32(varMi.ExecuteScalar());
            if (sonuc != 1)
            {
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into public.ssd (ssdurunkodu,kapasite,okumahizi,yazmahizi,marka) values (@p1,@p2,@p3,@p4,@p5) ", baglan);
                ekleme.Parameters.AddWithValue("@p1", ssdid.Text);
                ekleme.Parameters.AddWithValue("@p2", int.Parse(kapasite.Text));
                ekleme.Parameters.AddWithValue("@p3", int.Parse(okuma.Text));
                ekleme.Parameters.AddWithValue("@p4", int.Parse(yazma.Text));
                ekleme.Parameters.AddWithValue("@p5", marka.Text);
                


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
                ssdid.Text = "";

            }
            else
            {
                MessageBox.Show("Bu SSD Ürün Kodu zaten var");
            }
            baglan.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from public.ssd where ssdurunkodu=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", ssdid.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ssdid.Text = "";
        }

        private void SSD_Load(object sender, EventArgs e)
        {
            ekle.Enabled = false;
            sil.Enabled = false;
        }

        private void ssdid_TextChanged(object sender, EventArgs e)
        {
            if (ssdid.Text != "" && marka.Text != "" && kapasite.Text != "" && okuma.Text != "" && yazma.Text != "" )
            {
                ekle.Enabled = true;
            }
            if (ssdid.Text != "")
            {
                sil.Enabled = true;
            }
        }

        private void kapasite_TextChanged(object sender, EventArgs e)
        {
            if (ssdid.Text != "" && marka.Text != "" && kapasite.Text != "" && okuma.Text != "" && yazma.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void yazma_TextChanged(object sender, EventArgs e)
        {
            if (ssdid.Text != "" && marka.Text != "" && kapasite.Text != "" && okuma.Text != "" && yazma.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void okuma_TextChanged(object sender, EventArgs e)
        {
            if (ssdid.Text != "" && marka.Text != "" && kapasite.Text != "" && okuma.Text != "" && yazma.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void marka_TextChanged(object sender, EventArgs e)
        {
            if (ssdid.Text != "" && marka.Text != "" && kapasite.Text != "" && okuma.Text != "" && yazma.Text != "")
            {
                ekle.Enabled = true;
            }
        }
    }
}
