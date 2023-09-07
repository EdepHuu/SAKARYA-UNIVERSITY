
namespace NDP_PROJECT1
{
    partial class MusteriGirisEkrani
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyAd = new System.Windows.Forms.TextBox();
            this.btnAlısveris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAd.Location = new System.Drawing.Point(64, 46);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(57, 28);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsoyad.Location = new System.Drawing.Point(64, 117);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(102, 28);
            this.lblsoyad.TabIndex = 1;
            this.lblsoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(207, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.PlaceholderText = "Adinizi Giriniz...";
            this.txtAd.Size = new System.Drawing.Size(230, 27);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyAd
            // 
            this.txtSoyAd.Location = new System.Drawing.Point(207, 121);
            this.txtSoyAd.Name = "txtSoyAd";
            this.txtSoyAd.PlaceholderText = "Soyadinizi Giriniz...";
            this.txtSoyAd.Size = new System.Drawing.Size(230, 27);
            this.txtSoyAd.TabIndex = 3;
            // 
            // btnAlısveris
            // 
            this.btnAlısveris.BackColor = System.Drawing.Color.MistyRose;
            this.btnAlısveris.Location = new System.Drawing.Point(207, 209);
            this.btnAlısveris.Name = "btnAlısveris";
            this.btnAlısveris.Size = new System.Drawing.Size(230, 73);
            this.btnAlısveris.TabIndex = 4;
            this.btnAlısveris.Text = "ALISVERISE BASLA";
            this.btnAlısveris.UseVisualStyleBackColor = false;
            this.btnAlısveris.Click += new System.EventHandler(this.btnAlısveris_Click);
            // 
            // MusteriGirisEkrani
            // 
            this.AcceptButton = this.btnAlısveris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(627, 350);
            this.Controls.Add(this.btnAlısveris);
            this.Controls.Add(this.txtSoyAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "MusteriGirisEkrani";
            this.Text = "MusteriGirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyAd;
        private System.Windows.Forms.Button btnAlısveris;
    }
}