
namespace NDP_PROJECT1
{
    partial class MagazaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStok = new System.Windows.Forms.Button();
            this.lblBaslik1 = new System.Windows.Forms.Label();
            this.lblSecim = new System.Windows.Forms.Label();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnTedarikci = new System.Windows.Forms.Button();
            this.btnGg = new System.Windows.Forms.Button();
            this.lblMusteriBaslik = new System.Windows.Forms.Label();
            this.btnMusteriyim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStok.Location = new System.Drawing.Point(95, 200);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(185, 77);
            this.btnStok.TabIndex = 0;
            this.btnStok.Text = "STOK";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBaslik1
            // 
            this.lblBaslik1.AutoSize = true;
            this.lblBaslik1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBaslik1.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBaslik1.Location = new System.Drawing.Point(187, 40);
            this.lblBaslik1.Name = "lblBaslik1";
            this.lblBaslik1.Size = new System.Drawing.Size(650, 50);
            this.lblBaslik1.TabIndex = 2;
            this.lblBaslik1.Text = "Magaza Uygulamasina Hosgeldiniz!";
            this.lblBaslik1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBaslik1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSecim
            // 
            this.lblSecim.AutoSize = true;
            this.lblSecim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSecim.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSecim.Location = new System.Drawing.Point(198, 102);
            this.lblSecim.Name = "lblSecim";
            this.lblSecim.Size = new System.Drawing.Size(628, 50);
            this.lblSecim.TabIndex = 3;
            this.lblSecim.Text = "Yapmak Istediginiz islemi seciniz...";
            this.lblSecim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMusteri.Location = new System.Drawing.Point(318, 200);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(185, 77);
            this.btnMusteri.TabIndex = 4;
            this.btnMusteri.Text = "MUSTERI";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnTedarikci
            // 
            this.btnTedarikci.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTedarikci.Location = new System.Drawing.Point(546, 200);
            this.btnTedarikci.Name = "btnTedarikci";
            this.btnTedarikci.Size = new System.Drawing.Size(185, 77);
            this.btnTedarikci.TabIndex = 5;
            this.btnTedarikci.Text = "TEDARIKCI";
            this.btnTedarikci.UseVisualStyleBackColor = true;
            this.btnTedarikci.Click += new System.EventHandler(this.btnTedarikci_Click);
            // 
            // btnGg
            // 
            this.btnGg.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGg.Location = new System.Drawing.Point(768, 200);
            this.btnGg.Name = "btnGg";
            this.btnGg.Size = new System.Drawing.Size(185, 77);
            this.btnGg.TabIndex = 6;
            this.btnGg.Text = "TEDARIKCI LISTESI";
            this.btnGg.UseVisualStyleBackColor = true;
            this.btnGg.Click += new System.EventHandler(this.btnGg_Click);
            // 
            // lblMusteriBaslik
            // 
            this.lblMusteriBaslik.AutoSize = true;
            this.lblMusteriBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMusteriBaslik.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMusteriBaslik.Location = new System.Drawing.Point(10, 320);
            this.lblMusteriBaslik.Name = "lblMusteriBaslik";
            this.lblMusteriBaslik.Size = new System.Drawing.Size(1012, 50);
            this.lblMusteriBaslik.TabIndex = 8;
            this.lblMusteriBaslik.Text = "Musteriyseniz Asagıdaki Musteriyim Butonuna Tıklayiniz";
            this.lblMusteriBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMusteriyim
            // 
            this.btnMusteriyim.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnMusteriyim.Location = new System.Drawing.Point(331, 388);
            this.btnMusteriyim.Name = "btnMusteriyim";
            this.btnMusteriyim.Size = new System.Drawing.Size(379, 138);
            this.btnMusteriyim.TabIndex = 9;
            this.btnMusteriyim.Text = "MUSTERİYİM";
            this.btnMusteriyim.UseVisualStyleBackColor = true;
            this.btnMusteriyim.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MagazaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.btnMusteriyim);
            this.Controls.Add(this.lblMusteriBaslik);
            this.Controls.Add(this.btnGg);
            this.Controls.Add(this.btnTedarikci);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.lblSecim);
            this.Controls.Add(this.lblBaslik1);
            this.Controls.Add(this.btnStok);
            this.Name = "MagazaForm";
            this.Text = "Magaza Uygulamasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnStok;
        public System.Windows.Forms.Label lblBaslik1;
        public System.Windows.Forms.Label lblSecim;
        public System.Windows.Forms.Button btnMusteri;
        public System.Windows.Forms.Button btnTedarikci;
        public System.Windows.Forms.Button btnGg;
        public System.Windows.Forms.Label lblMusteriBaslik;
        private System.Windows.Forms.Button btnMusteriyim;
    }
}

