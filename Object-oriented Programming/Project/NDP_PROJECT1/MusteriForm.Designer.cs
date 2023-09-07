
namespace NDP_PROJECT1
{
    partial class MusteriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslik3 = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblaldigiurun = new System.Windows.Forms.Label();
            this.lblAlinanUrunAdedi = new System.Windows.Forms.Label();
            this.txtMusteriAd_M = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad_M = new System.Windows.Forms.TextBox();
            this.txtMusteriAlinanUrun_M = new System.Windows.Forms.TextBox();
            this.txtMusteriAdet_M = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBaslik3
            // 
            this.lblBaslik3.AutoSize = true;
            this.lblBaslik3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBaslik3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik3.Location = new System.Drawing.Point(204, 35);
            this.lblBaslik3.Name = "lblBaslik3";
            this.lblBaslik3.Size = new System.Drawing.Size(606, 50);
            this.lblBaslik3.TabIndex = 0;
            this.lblBaslik3.Text = "MUSTERI KISMINA HOSGELDINIZ";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMusteriAd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMusteriAd.ForeColor = System.Drawing.Color.White;
            this.lblMusteriAd.Location = new System.Drawing.Point(110, 121);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(133, 31);
            this.lblMusteriAd.TabIndex = 1;
            this.lblMusteriAd.Text = "Musteri Adi";
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMusteriSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMusteriSoyad.ForeColor = System.Drawing.Color.White;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(312, 121);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(168, 31);
            this.lblMusteriSoyad.TabIndex = 2;
            this.lblMusteriSoyad.Text = "Musteri Soyadi";
            // 
            // lblaldigiurun
            // 
            this.lblaldigiurun.AutoSize = true;
            this.lblaldigiurun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblaldigiurun.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblaldigiurun.ForeColor = System.Drawing.Color.White;
            this.lblaldigiurun.Location = new System.Drawing.Point(555, 121);
            this.lblaldigiurun.Name = "lblaldigiurun";
            this.lblaldigiurun.Size = new System.Drawing.Size(133, 31);
            this.lblaldigiurun.TabIndex = 3;
            this.lblaldigiurun.Text = "Aldigi Urun";
            // 
            // lblAlinanUrunAdedi
            // 
            this.lblAlinanUrunAdedi.AutoSize = true;
            this.lblAlinanUrunAdedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAlinanUrunAdedi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAlinanUrunAdedi.ForeColor = System.Drawing.Color.White;
            this.lblAlinanUrunAdedi.Location = new System.Drawing.Point(779, 121);
            this.lblAlinanUrunAdedi.Name = "lblAlinanUrunAdedi";
            this.lblAlinanUrunAdedi.Size = new System.Drawing.Size(131, 31);
            this.lblAlinanUrunAdedi.TabIndex = 4;
            this.lblAlinanUrunAdedi.Text = "Urun Adedi";
            // 
            // txtMusteriAd_M
            // 
            this.txtMusteriAd_M.Location = new System.Drawing.Point(91, 188);
            this.txtMusteriAd_M.Multiline = true;
            this.txtMusteriAd_M.Name = "txtMusteriAd_M";
            this.txtMusteriAd_M.ReadOnly = true;
            this.txtMusteriAd_M.Size = new System.Drawing.Size(170, 277);
            this.txtMusteriAd_M.TabIndex = 5;
            this.txtMusteriAd_M.TextChanged += new System.EventHandler(this.txtMusteriAd_M_TextChanged);
            // 
            // txtMusteriSoyad_M
            // 
            this.txtMusteriSoyad_M.Location = new System.Drawing.Point(312, 188);
            this.txtMusteriSoyad_M.Multiline = true;
            this.txtMusteriSoyad_M.Name = "txtMusteriSoyad_M";
            this.txtMusteriSoyad_M.ReadOnly = true;
            this.txtMusteriSoyad_M.Size = new System.Drawing.Size(168, 277);
            this.txtMusteriSoyad_M.TabIndex = 6;
            // 
            // txtMusteriAlinanUrun_M
            // 
            this.txtMusteriAlinanUrun_M.Location = new System.Drawing.Point(535, 188);
            this.txtMusteriAlinanUrun_M.Multiline = true;
            this.txtMusteriAlinanUrun_M.Name = "txtMusteriAlinanUrun_M";
            this.txtMusteriAlinanUrun_M.ReadOnly = true;
            this.txtMusteriAlinanUrun_M.Size = new System.Drawing.Size(168, 277);
            this.txtMusteriAlinanUrun_M.TabIndex = 7;
            // 
            // txtMusteriAdet_M
            // 
            this.txtMusteriAdet_M.Location = new System.Drawing.Point(761, 188);
            this.txtMusteriAdet_M.Multiline = true;
            this.txtMusteriAdet_M.Name = "txtMusteriAdet_M";
            this.txtMusteriAdet_M.ReadOnly = true;
            this.txtMusteriAdet_M.Size = new System.Drawing.Size(168, 277);
            this.txtMusteriAdet_M.TabIndex = 8;
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.txtMusteriAdet_M);
            this.Controls.Add(this.txtMusteriAlinanUrun_M);
            this.Controls.Add(this.txtMusteriSoyad_M);
            this.Controls.Add(this.txtMusteriAd_M);
            this.Controls.Add(this.lblAlinanUrunAdedi);
            this.Controls.Add(this.lblaldigiurun);
            this.Controls.Add(this.lblMusteriSoyad);
            this.Controls.Add(this.lblMusteriAd);
            this.Controls.Add(this.lblBaslik3);
            this.Name = "MusteriForm";
            this.Text = "MusteriForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBaslik3;
        public System.Windows.Forms.Label lblMusteriAd;
        public System.Windows.Forms.Label lblMusteriSoyad;
        public System.Windows.Forms.Label lblaldigiurun;
        public System.Windows.Forms.Label lblAlinanUrunAdedi;
        public System.Windows.Forms.TextBox txtMusteriAd_M;
        public System.Windows.Forms.TextBox txtMusteriSoyad_M;
        public System.Windows.Forms.TextBox txtMusteriAlinanUrun_M;
        public System.Windows.Forms.TextBox txtMusteriAdet_M;
    }
}