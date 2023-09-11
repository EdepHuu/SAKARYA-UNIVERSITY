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
    public partial class HDD : Form
    {
        public HDD()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=DbComputerFactoryManagementSystem;user ID=postgres;password=Edephuuu4949");

        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.hdd ";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand varMi = new NpgsqlCommand("Select COUNT(hddurunkodu) from public.hdd WHERE hddurunkodu='" + hddid.Text + "'", baglan);
            int sonuc = Convert.ToInt32(varMi.ExecuteScalar());
            if (sonuc != 1)
            {
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into public.hdd (hddurunkodu,kapasite,boyutinch,marka) values (@p1,@p2,@p3,@p4) ", baglan);
                ekleme.Parameters.AddWithValue("@p1", hddid.Text);
                ekleme.Parameters.AddWithValue("@p2", int.Parse(kapasite.Text));
                ekleme.Parameters.AddWithValue("@p3", int.Parse(boyut.Text));
                ekleme.Parameters.AddWithValue("@p4", marka.Text);



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
                hddid.Text = "";

            }
            else
            {
                MessageBox.Show("Bu HDD Ürün Kodu zaten var");
            }
            baglan.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from public.hdd where hddurunkodu=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", hddid.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            hddid.Text = "";
        }

        private void HDD_Load(object sender, EventArgs e)
        {
            ekle.Enabled = false;
            sil.Enabled = false;

        }

        private void hddid_TextChanged(object sender, EventArgs e)
        {
            if (hddid.Text != "" && marka.Text != "" && kapasite.Text != "" && boyut.Text != "")
            {
                ekle.Enabled = true;
            }
            if (hddid.Text != "")
            {
                sil.Enabled = true;
            }
        }

        private void kapasite_TextChanged(object sender, EventArgs e)
        {
            if (hddid.Text != "" && marka.Text != "" && kapasite.Text != "" && boyut.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void boyut_TextChanged(object sender, EventArgs e)
        {
            if (hddid.Text != "" && marka.Text != "" && kapasite.Text != "" && boyut.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void marka_TextChanged(object sender, EventArgs e)
        {
            if (hddid.Text != "" && marka.Text != "" && kapasite.Text != "" && boyut.Text != "")
            {
                ekle.Enabled = true;
            }
        }
    }
}
