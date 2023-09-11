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
    public partial class Ram : Form
    {
        public Ram()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=DbComputerFactoryManagementSystem;user ID=postgres;password=Edephuuu4949");

        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.ram ";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand varMi = new NpgsqlCommand("Select COUNT(ramurunkodu) from public.ram WHERE ramurunkodu='" + ramid.Text + "'", baglan);
            int sonuc = Convert.ToInt32(varMi.ExecuteScalar());
            if (sonuc != 1)
            {
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into public.ram (ramurunkodu,cldegeri,frekans,kapasite,marka) values (@p1,@p2,@p3,@p4,@p5) ", baglan);
                ekleme.Parameters.AddWithValue("@p1", ramid.Text);
                ekleme.Parameters.AddWithValue("@p2", int.Parse(cl.Text));
                ekleme.Parameters.AddWithValue("@p3", int.Parse(frekans.Text));
                ekleme.Parameters.AddWithValue("@p4", int.Parse(kapasite.Text));
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
                ramid.Text = "";

            }
            else
            {
                MessageBox.Show("Bu Ram Ürün Kodu zaten var");
            }
            baglan.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from public.ram where ramurunkodu=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", ramid.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ramid.Text = "";
        }

        private void Ram_Load(object sender, EventArgs e)
        {
            ekle.Enabled = false;
            sil.Enabled = false;
        }

        private void ramid_TextChanged(object sender, EventArgs e)
        {
            if (ramid.Text != "" && marka.Text != "" && cl.Text != "" && frekans.Text != "" && kapasite.Text != "")
            {
                ekle.Enabled = true;
            }
            if (ramid.Text != "")
            {
                sil.Enabled = true;
            }
        }

        private void cl_TextChanged(object sender, EventArgs e)
        {
            if (ramid.Text != "" && marka.Text != "" && cl.Text != "" && frekans.Text != "" && kapasite.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void frekans_TextChanged(object sender, EventArgs e)
        {
            if (ramid.Text != "" && marka.Text != "" && cl.Text != "" && frekans.Text != "" && kapasite.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void kapasite_TextChanged(object sender, EventArgs e)
        {
            if (ramid.Text != "" && marka.Text != "" && cl.Text != "" && frekans.Text != "" && kapasite.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void marka_TextChanged(object sender, EventArgs e)
        {
            if (ramid.Text != "" && marka.Text != "" && cl.Text != "" && frekans.Text != "" && kapasite.Text != "")
            {
                ekle.Enabled = true;
            }
        }
    }
}
