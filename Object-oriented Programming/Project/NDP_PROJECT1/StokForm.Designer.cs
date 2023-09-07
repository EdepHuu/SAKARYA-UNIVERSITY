
namespace NDP_PROJECT1
{
    partial class StokForm
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
            this.lblBaslik2 = new System.Windows.Forms.Label();
            this.btnStokDepo = new System.Windows.Forms.Button();
            this.btnStokRaf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik2
            // 
            this.lblBaslik2.AutoSize = true;
            this.lblBaslik2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBaslik2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik2.Location = new System.Drawing.Point(235, 40);
            this.lblBaslik2.Name = "lblBaslik2";
            this.lblBaslik2.Size = new System.Drawing.Size(539, 50);
            this.lblBaslik2.TabIndex = 0;
            this.lblBaslik2.Text = "STOK KISMINA HOSGELDINIZ";
            this.lblBaslik2.Click += new System.EventHandler(this.lblBaslik2_Click);
            // 
            // btnStokDepo
            // 
            this.btnStokDepo.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStokDepo.Location = new System.Drawing.Point(235, 265);
            this.btnStokDepo.Name = "btnStokDepo";
            this.btnStokDepo.Size = new System.Drawing.Size(248, 86);
            this.btnStokDepo.TabIndex = 1;
            this.btnStokDepo.Text = "DEPODAKI STOK\r\n";
            this.btnStokDepo.UseVisualStyleBackColor = true;
            this.btnStokDepo.Click += new System.EventHandler(this.btnStokDepo_Click);
            // 
            // btnStokRaf
            // 
            this.btnStokRaf.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStokRaf.Location = new System.Drawing.Point(526, 265);
            this.btnStokRaf.Name = "btnStokRaf";
            this.btnStokRaf.Size = new System.Drawing.Size(248, 86);
            this.btnStokRaf.TabIndex = 2;
            this.btnStokRaf.Text = "RAFDAKI STOK";
            this.btnStokRaf.UseVisualStyleBackColor = true;
            this.btnStokRaf.Click += new System.EventHandler(this.btnStokRaf_Click_1);
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.btnStokRaf);
            this.Controls.Add(this.btnStokDepo);
            this.Controls.Add(this.lblBaslik2);
            this.Name = "StokForm";
            this.Text = "STOK";
            this.Load += new System.EventHandler(this.StokForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnStokRaf_Click(object sender, System.EventArgs e)
        {
            RafdakiStokForm rafdakistok1 = new RafdakiStokForm();
            rafdakistok1.Show();

        }

        private void BtnStokDepo_Click1(object sender, System.EventArgs e)
        {
            DepodakiStokForm depodakistok1 = new DepodakiStokForm();
            depodakistok1.Show();

        }





        #endregion

        public System.Windows.Forms.Label lblBaslik2;
        public System.Windows.Forms.Button btnStokDepo;
        public System.Windows.Forms.Button btnStokRaf;
    }
}