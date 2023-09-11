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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void FormGoster(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent=this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void bilgisayar_Click(object sender, EventArgs e)
        {
            bilgisayar blg = new bilgisayar();
            
            FormGoster(blg);
            
        }

        private void anakart_Click(object sender, EventArgs e)
        {
            Anakart anakartt = new Anakart();
            FormGoster(anakartt);
        }

        private void islemci_Click(object sender, EventArgs e)
        {
            Islemci islemcii = new Islemci();
            FormGoster(islemcii);
        }

        private void ekrankarti_Click(object sender, EventArgs e)
        {
            Ekrankarti ekrankartii = new Ekrankarti();
            FormGoster(ekrankartii);
        }

        private void ram_Click(object sender, EventArgs e)
        {
            Ram ramm = new Ram();
            FormGoster(ramm);
        }

        private void ssd_Click(object sender, EventArgs e)
        {
            SSD ssdd = new SSD();
            FormGoster(ssdd);
        }

        private void hdd_Click(object sender, EventArgs e)
        {
            HDD hddd = new HDD();
            FormGoster(hddd);
        }

        private void monitor_Click(object sender, EventArgs e)
        {
            Monitor monitorr = new Monitor();
            FormGoster(monitorr);
        }

        private void klavye_Click(object sender, EventArgs e)
        {
            Klavye klavye = new Klavye();
            FormGoster(klavye);

        }

        private void cikisg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
