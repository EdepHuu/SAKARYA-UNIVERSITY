
namespace NDP_PROJECT1
{
    partial class TedarikciGiris
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
            this.lblFirmaAd = new System.Windows.Forms.Label();
            this.lblFirmaNo = new System.Windows.Forms.Label();
            this.txtFirmaAd = new System.Windows.Forms.TextBox();
            this.txtFirmaNo = new System.Windows.Forms.TextBox();
            this.btnileri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirmaAd
            // 
            this.lblFirmaAd.AutoSize = true;
            this.lblFirmaAd.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirmaAd.Location = new System.Drawing.Point(46, 36);
            this.lblFirmaAd.Name = "lblFirmaAd";
            this.lblFirmaAd.Size = new System.Drawing.Size(162, 28);
            this.lblFirmaAd.TabIndex = 0;
            this.lblFirmaAd.Text = "Firma Adi:";
            // 
            // lblFirmaNo
            // 
            this.lblFirmaNo.AutoSize = true;
            this.lblFirmaNo.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirmaNo.Location = new System.Drawing.Point(46, 109);
            this.lblFirmaNo.Name = "lblFirmaNo";
            this.lblFirmaNo.Size = new System.Drawing.Size(147, 28);
            this.lblFirmaNo.TabIndex = 1;
            this.lblFirmaNo.Text = "Firma No:";
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.Location = new System.Drawing.Point(252, 40);
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.PlaceholderText = "Urun alinacak firmanin adini giriniz...";
            this.txtFirmaAd.Size = new System.Drawing.Size(291, 27);
            this.txtFirmaAd.TabIndex = 2;
            // 
            // txtFirmaNo
            // 
            this.txtFirmaNo.Location = new System.Drawing.Point(252, 113);
            this.txtFirmaNo.Name = "txtFirmaNo";
            this.txtFirmaNo.PlaceholderText = "Urun alinacak firmanin numarasini giriniz...";
            this.txtFirmaNo.Size = new System.Drawing.Size(291, 27);
            this.txtFirmaNo.TabIndex = 3;
            // 
            // btnileri
            // 
            this.btnileri.BackColor = System.Drawing.Color.White;
            this.btnileri.Font = new System.Drawing.Font("SimSun", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnileri.Location = new System.Drawing.Point(161, 179);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(261, 89);
            this.btnileri.TabIndex = 4;
            this.btnileri.Text = "Siparis Al ve Stok Ekle";
            this.btnileri.UseVisualStyleBackColor = false;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            // 
            // TedarikciGiris
            // 
            this.AcceptButton = this.btnileri;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(627, 350);
            this.Controls.Add(this.btnileri);
            this.Controls.Add(this.txtFirmaNo);
            this.Controls.Add(this.txtFirmaAd);
            this.Controls.Add(this.lblFirmaNo);
            this.Controls.Add(this.lblFirmaAd);
            this.Name = "TedarikciGiris";
            this.Text = "TedarikciGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirmaAd;
        private System.Windows.Forms.Label lblFirmaNo;
        private System.Windows.Forms.TextBox txtFirmaAd;
        private System.Windows.Forms.TextBox txtFirmaNo;
        private System.Windows.Forms.Button btnileri;
    }
}