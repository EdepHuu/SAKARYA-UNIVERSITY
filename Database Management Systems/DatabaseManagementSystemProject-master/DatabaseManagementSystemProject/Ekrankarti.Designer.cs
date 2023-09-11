
namespace DatabaseManagementSystemProject
{
    partial class Ekrankarti
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uretici = new System.Windows.Forms.TextBox();
            this.tur = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.bellek = new System.Windows.Forms.TextBox();
            this.ekranid = new System.Windows.Forms.TextBox();
            this.listele = new System.Windows.Forms.Button();
            this.eksil = new System.Windows.Forms.Button();
            this.ekekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(827, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1027, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Üretici";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(827, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1027, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bellek Kapasitesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(827, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ürün Kodu";
            // 
            // uretici
            // 
            this.uretici.BackColor = System.Drawing.Color.White;
            this.uretici.Location = new System.Drawing.Point(1030, 175);
            this.uretici.Multiline = true;
            this.uretici.Name = "uretici";
            this.uretici.Size = new System.Drawing.Size(180, 27);
            this.uretici.TabIndex = 30;
            this.uretici.TextChanged += new System.EventHandler(this.uretici_TextChanged);
            // 
            // tur
            // 
            this.tur.BackColor = System.Drawing.Color.White;
            this.tur.Location = new System.Drawing.Point(830, 275);
            this.tur.Multiline = true;
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(180, 27);
            this.tur.TabIndex = 28;
            this.tur.TextChanged += new System.EventHandler(this.tur_TextChanged);
            // 
            // marka
            // 
            this.marka.BackColor = System.Drawing.Color.White;
            this.marka.Location = new System.Drawing.Point(830, 175);
            this.marka.Multiline = true;
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(180, 27);
            this.marka.TabIndex = 27;
            this.marka.TextChanged += new System.EventHandler(this.marka_TextChanged);
            // 
            // bellek
            // 
            this.bellek.BackColor = System.Drawing.Color.White;
            this.bellek.Location = new System.Drawing.Point(1030, 75);
            this.bellek.Multiline = true;
            this.bellek.Name = "bellek";
            this.bellek.Size = new System.Drawing.Size(180, 27);
            this.bellek.TabIndex = 26;
            this.bellek.TextChanged += new System.EventHandler(this.bellek_TextChanged);
            // 
            // ekranid
            // 
            this.ekranid.BackColor = System.Drawing.Color.White;
            this.ekranid.Location = new System.Drawing.Point(830, 75);
            this.ekranid.Multiline = true;
            this.ekranid.Name = "ekranid";
            this.ekranid.Size = new System.Drawing.Size(180, 27);
            this.ekranid.TabIndex = 25;
            this.ekranid.TextChanged += new System.EventHandler(this.ekranid_TextChanged);
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
            this.listele.TabIndex = 24;
            this.listele.Text = "LISTELE";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // eksil
            // 
            this.eksil.BackColor = System.Drawing.Color.MediumPurple;
            this.eksil.FlatAppearance.BorderSize = 0;
            this.eksil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eksil.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eksil.Location = new System.Drawing.Point(1040, 524);
            this.eksil.Name = "eksil";
            this.eksil.Size = new System.Drawing.Size(190, 50);
            this.eksil.TabIndex = 23;
            this.eksil.Text = "SIL";
            this.eksil.UseVisualStyleBackColor = false;
            this.eksil.Click += new System.EventHandler(this.eksil_Click);
            // 
            // ekekle
            // 
            this.ekekle.BackColor = System.Drawing.Color.MediumPurple;
            this.ekekle.FlatAppearance.BorderSize = 0;
            this.ekekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekekle.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekekle.Location = new System.Drawing.Point(830, 524);
            this.ekekle.Name = "ekekle";
            this.ekekle.Size = new System.Drawing.Size(190, 50);
            this.ekekle.TabIndex = 22;
            this.ekekle.Text = "EKLE";
            this.ekekle.UseVisualStyleBackColor = false;
            this.ekekle.Click += new System.EventHandler(this.ekekle_Click);
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
            this.dataGridView1.TabIndex = 21;
            // 
            // Ekrankarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1251, 706);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uretici);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.bellek);
            this.Controls.Add(this.ekranid);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.eksil);
            this.Controls.Add(this.ekekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ekrankarti";
            this.Text = "Ekrankarti";
            this.Load += new System.EventHandler(this.Ekrankarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uretici;
        private System.Windows.Forms.TextBox tur;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox bellek;
        private System.Windows.Forms.TextBox ekranid;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button eksil;
        private System.Windows.Forms.Button ekekle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}