using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementSystemProject
{
    public partial class bilgisayar : Form
    {
        public bilgisayar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=DbComputerFactoryManagementSystem;user ID=postgres;password=Edephuuu4949");
        string pc = "public.Bilgisayar".ToLower();
        
        
        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();

                NpgsqlCommand ekleme = new NpgsqlCommand("insert into public.bilgisayar (bilgisayarid,anakart,ram1,ram2,islemci,monitorpanel,ekrankarti,klavye,hdd,ssd) values (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9) ", baglan);
                ekleme.Parameters.AddWithValue("@p0", Convert.ToInt32(id.Text));
                ekleme.Parameters.AddWithValue("@p1", anakart.Text);
                ekleme.Parameters.AddWithValue("@p2", ram1.Text);
                if (ram2.Text == null || ram2.Text == "") { ekleme.Parameters.AddWithValue("@p3", DBNull.Value); }
                else { ekleme.Parameters.AddWithValue("@p3", ram2.Text); }
                ekleme.Parameters.AddWithValue("@p4", islemci.Text);
                ekleme.Parameters.AddWithValue("@p5", monitor.Text);
                ekleme.Parameters.AddWithValue("@p6", ekrankarti.Text);
                ekleme.Parameters.AddWithValue("@p7", klavye.Text);
                ekleme.Parameters.AddWithValue("@p8", hdd.Text);
                if (ssd.Text == null || ssd.Text == "") { ekleme.Parameters.AddWithValue("@p9", DBNull.Value); }
                else { ekleme.Parameters.AddWithValue("@p9", ssd.Text); }

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
            }
            catch (Exception ex)
            {
                baglan.Close();
                MessageBox.Show("FABRİKADA GİRDİĞİNİZ BİLGİSAYAR PARÇALARI BULUNMAMAKTADIR!! ---> ERROR: " + ex.Message);
            }
        }

        private void listele_Click(object sender, EventArgs e)
        {
            string pc = "public.Bilgisayar".ToLower();
            string sorgu = "select * from "+ pc;
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu,baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void bilgisayar_Load(object sender, EventArgs e)
        {
            if (ekrankarti.Text == "" && islemci.Text == "" && ram1.Text == "" && anakart.Text == "" && monitor.Text == "" && klavye.Text == "" && hdd.Text == "") 
            {
                ekle.Enabled = false;
            }
            if(id.Text == "")
            {
                sil.Enabled = false;
                
            }
            if (id.Text == "")
            {
                
                guncelle.Enabled = false;
            }
        }

        private void anakart_TextChanged(object sender, EventArgs e)
        {
            if (ekrankarti.Text != "" && islemci.Text != "" && ram1.Text != "" && anakart.Text != "" && monitor.Text != "" && klavye.Text != "" && hdd.Text != "")
            {
                ekle.Enabled = true;

            }
            if (id.Text != "" && anakart.Text != "" && islemci.Text != "" && ekrankarti.Text != "" && ram1.Text != "")
            {

                guncelle.Enabled = true;
            }
        }

        private void islemci_TextChanged(object sender, EventArgs e)
        {
            if (ekrankarti.Text != "" && islemci.Text != "" && ram1.Text != "" && anakart.Text != "" && monitor.Text != "" && klavye.Text != "" && hdd.Text != "")
            {
                ekle.Enabled = true;
            }
            if (id.Text != "" && anakart.Text != "" && islemci.Text != "" && ekrankarti.Text != "" && ram1.Text != "")
            {
               
                guncelle.Enabled = true;
            }
        }

        private void ekrankarti_TextChanged(object sender, EventArgs e)
        {
            if (ekrankarti.Text != "" && islemci.Text != "" && ram1.Text != "" && anakart.Text != "" && monitor.Text != "" && klavye.Text != "" && hdd.Text != "")
            {
                ekle.Enabled = true;
            }
            if (id.Text != "" && anakart.Text != "" && islemci.Text != "" && ekrankarti.Text != "" && ram1.Text != "")
            {

                guncelle.Enabled = true;
            }
        }

        private void ram1_TextChanged(object sender, EventArgs e)
        {
            if (ekrankarti.Text != "" && islemci.Text != "" && ram1.Text != "" && anakart.Text != "" && monitor.Text != "" && klavye.Text != "" && hdd.Text != "")
            {
                ekle.Enabled = true;
            }
            if (id.Text != "" && anakart.Text != "" && islemci.Text != "" && ekrankarti.Text != "" && ram1.Text != "")
            {

                guncelle.Enabled = true;
            }
        }

        private void hdd_TextChanged(object sender, EventArgs e)
        {
            if (ekrankarti.Text != "" && islemci.Text != "" && ram1.Text != "" && anakart.Text != "" && monitor.Text != "" && klavye.Text != "" && hdd.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void monitor_TextChanged(object sender, EventArgs e)
        {
            if (ekrankarti.Text != "" && islemci.Text != "" && ram1.Text != "" && anakart.Text != "" && monitor.Text != "" && klavye.Text != "" && hdd.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void klavye_TextChanged(object sender, EventArgs e)
        {
            if (ekrankarti.Text != "" && islemci.Text != "" && ram1.Text != "" && anakart.Text != "" && monitor.Text != "" && klavye.Text != "" && hdd.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from public.Bilgisayar where bilgisayarid=@p1",baglan);
            sil.Parameters.AddWithValue("@p1",int.Parse(id.Text));
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            NpgsqlCommand guncel = new NpgsqlCommand("update bilgisayar set ekrankarti = @p1, islemci =@p2 ,anakart =@p3 ,ram1 = @p4 where bilgisayarid = @p5",baglan);
            guncel.Parameters.AddWithValue("@p1", ekrankarti.Text);
            guncel.Parameters.AddWithValue("@p2", islemci.Text);
            guncel.Parameters.AddWithValue("@p3", anakart.Text);
            guncel.Parameters.AddWithValue("@p4", ram1.Text);
            guncel.Parameters.AddWithValue("@p5", int.Parse(id.Text));
            guncel.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            guncelle.Enabled = false;
        }

        private void ara_TextChanged(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            

            if (comboBox1.Text== "Anakart")
            {
                string sorgu = "select * from public.bilgisayar where anakart like '%" + ara.Text + "%' ";
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);

                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text== "İşlemci")
            {
                string sorgu = "select * from public.bilgisayar where islemci like '%" + ara.Text + "%' ";
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);

                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text== "Ekran Kartı")
            {
                string sorgu = "select * from public.bilgisayar where ekrankarti like '%" + ara.Text + "%' ";
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);

                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Ram")
            {
                string sorgu = "select * from public.bilgisayar where ram1 like '%" + ara.Text + "%' ";
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);

                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "SSD")
            {
                string sorgu = "select * from public.bilgisayar where ssd like '%" + ara.Text + "%' ";
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);

                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "HDD")
            {
                string sorgu = "select * from public.bilgisayar where hdd like '%" + ara.Text + "%' ";
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);

                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Monitör")
            {
                string sorgu = "select * from public.bilgisayar where monitorpanel like '%" + ara.Text + "%' ";
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);

                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Klavye")
            {
                string sorgu = "select * from public.bilgisayar where klavye like '%" + ara.Text + "%' ";
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);

                data.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                sil.Enabled = true;
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ara.Text = "";
        }
    }
}
