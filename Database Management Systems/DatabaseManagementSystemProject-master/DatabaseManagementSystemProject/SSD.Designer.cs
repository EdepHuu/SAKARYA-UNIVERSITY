
namespace DatabaseManagementSystemProject
{
    partial class SSD
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
            this.label6 = new System.Windows.Forms.Label();
            this.okuma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yazma = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.kapasite = new System.Windows.Forms.TextBox();
            this.ssdid = new System.Windows.Forms.TextBox();
            this.listele = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1027, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "Okuma Hızı";
            // 
            // okuma
            // 
            this.okuma.BackColor = System.Drawing.Color.White;
            this.okuma.Location = new System.Drawing.Point(1030, 175);
            this.okuma.Multiline = true;
            this.okuma.Name = "okuma";
            this.okuma.Size = new System.Drawing.Size(180, 27);
            this.okuma.TabIndex = 66;
            this.okuma.TextChanged += new System.EventHandler(this.okuma_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(827, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Yazma Hızı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(827, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1027, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Kapasite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(827, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Ürün Kodu";
            // 
            // yazma
            // 
            this.yazma.BackColor = System.Drawing.Color.White;
            this.yazma.Location = new System.Drawing.Point(830, 175);
            this.yazma.Multiline = true;
            this.yazma.Name = "yazma";
            this.yazma.Size = new System.Drawing.Size(180, 27);
            this.yazma.TabIndex = 59;
            this.yazma.TextChanged += new System.EventHandler(this.yazma_TextChanged);
            // 
            // marka
            // 
            this.marka.BackColor = System.Drawing.Color.White;
            this.marka.Location = new System.Drawing.Point(830, 275);
            this.marka.Multiline = true;
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(180, 27);
            this.marka.TabIndex = 58;
            this.marka.TextChanged += new System.EventHandler(this.marka_TextChanged);
            // 
            // kapasite
            // 
            this.kapasite.BackColor = System.Drawing.Color.White;
            this.kapasite.Location = new System.Drawing.Point(1030, 75);
            this.kapasite.Multiline = true;
            this.kapasite.Name = "kapasite";
            this.kapasite.Size = new System.Drawing.Size(180, 27);
            this.kapasite.TabIndex = 57;
            this.kapasite.TextChanged += new System.EventHandler(this.kapasite_TextChanged);
            // 
            // ssdid
            // 
            this.ssdid.BackColor = System.Drawing.Color.White;
            this.ssdid.Location = new System.Drawing.Point(830, 75);
            this.ssdid.Multiline = true;
            this.ssdid.Name = "ssdid";
            this.ssdid.Size = new System.Drawing.Size(180, 27);
            this.ssdid.TabIndex = 56;
            this.ssdid.TextChanged += new System.EventHandler(this.ssdid_TextChanged);
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.MediumPurple;
            this.listele.FlatAppearance.BorderSize = 0;
            this.listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listele.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listele.Location = new System.Drawing.Point(830, 455);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(400, 50);
            this.listele.TabIndex = 55;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.MediumPurple;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.Location = new System.Drawing.Point(1040, 524);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(190, 50);
            this.sil.TabIndex = 54;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.MediumPurple;
            this.ekle.FlatAppearance.BorderSize = 0;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle.Location = new System.Drawing.Point(830, 524);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(190, 50);
            this.ekle.TabIndex = 53;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 682);
            this.dataGridView1.TabIndex = 52;
            // 
            // SSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1251, 706);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.okuma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yazma);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.kapasite);
            this.Controls.Add(this.ssdid);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SSD";
            this.Text = "SSD";
            this.Load += new System.EventHandler(this.SSD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox okuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yazma;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox kapasite;
        private System.Windows.Forms.TextBox ssdid;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}