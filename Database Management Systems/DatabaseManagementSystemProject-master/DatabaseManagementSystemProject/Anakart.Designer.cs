
namespace DatabaseManagementSystemProject
{
    partial class Anakart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.anakartekle = new System.Windows.Forms.Button();
            this.anakartsil = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.anakartid = new System.Windows.Forms.TextBox();
            this.ramslot = new System.Windows.Forms.TextBox();
            this.ramcap = new System.Windows.Forms.TextBox();
            this.tur = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.depola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 682);
            this.dataGridView1.TabIndex = 3;
            // 
            // anakartekle
            // 
            this.anakartekle.BackColor = System.Drawing.Color.MediumPurple;
            this.anakartekle.FlatAppearance.BorderSize = 0;
            this.anakartekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anakartekle.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anakartekle.Location = new System.Drawing.Point(822, 524);
            this.anakartekle.Name = "anakartekle";
            this.anakartekle.Size = new System.Drawing.Size(190, 50);
            this.anakartekle.TabIndex = 4;
            this.anakartekle.Text = "EKLE";
            this.anakartekle.UseVisualStyleBackColor = false;
            this.anakartekle.Click += new System.EventHandler(this.anakartekle_Click);
            // 
            // anakartsil
            // 
            this.anakartsil.BackColor = System.Drawing.Color.MediumPurple;
            this.anakartsil.FlatAppearance.BorderSize = 0;
            this.anakartsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anakartsil.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anakartsil.Location = new System.Drawing.Point(1032, 524);
            this.anakartsil.Name = "anakartsil";
            this.anakartsil.Size = new System.Drawing.Size(190, 50);
            this.anakartsil.TabIndex = 5;
            this.anakartsil.Text = "SIL";
            this.anakartsil.UseVisualStyleBackColor = false;
            this.anakartsil.Click += new System.EventHandler(this.anakartsil_Click);
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.MediumPurple;
            this.listele.FlatAppearance.BorderSize = 0;
            this.listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listele.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listele.Location = new System.Drawing.Point(822, 455);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(400, 50);
            this.listele.TabIndex = 6;
            this.listele.Text = "LISTELE";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // anakartid
            // 
            this.anakartid.BackColor = System.Drawing.Color.White;
            this.anakartid.Location = new System.Drawing.Point(822, 75);
            this.anakartid.Multiline = true;
            this.anakartid.Name = "anakartid";
            this.anakartid.Size = new System.Drawing.Size(180, 27);
            this.anakartid.TabIndex = 9;
            this.anakartid.TextChanged += new System.EventHandler(this.anakartid_TextChanged);
            // 
            // ramslot
            // 
            this.ramslot.BackColor = System.Drawing.Color.White;
            this.ramslot.Location = new System.Drawing.Point(1022, 75);
            this.ramslot.Multiline = true;
            this.ramslot.Name = "ramslot";
            this.ramslot.Size = new System.Drawing.Size(180, 27);
            this.ramslot.TabIndex = 10;
            this.ramslot.TextChanged += new System.EventHandler(this.ramslot_TextChanged);
            // 
            // ramcap
            // 
            this.ramcap.BackColor = System.Drawing.Color.White;
            this.ramcap.Location = new System.Drawing.Point(822, 175);
            this.ramcap.Multiline = true;
            this.ramcap.Name = "ramcap";
            this.ramcap.Size = new System.Drawing.Size(180, 27);
            this.ramcap.TabIndex = 11;
            this.ramcap.TextChanged += new System.EventHandler(this.ramcap_TextChanged);
            // 
            // tur
            // 
            this.tur.BackColor = System.Drawing.Color.White;
            this.tur.Location = new System.Drawing.Point(822, 275);
            this.tur.Multiline = true;
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(180, 27);
            this.tur.TabIndex = 12;
            this.tur.TextChanged += new System.EventHandler(this.tur_TextChanged);
            // 
            // marka
            // 
            this.marka.BackColor = System.Drawing.Color.White;
            this.marka.Location = new System.Drawing.Point(1022, 275);
            this.marka.Multiline = true;
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(180, 27);
            this.marka.TabIndex = 13;
            this.marka.TextChanged += new System.EventHandler(this.marka_TextChanged);
            // 
            // depola
            // 
            this.depola.BackColor = System.Drawing.Color.White;
            this.depola.Location = new System.Drawing.Point(1022, 175);
            this.depola.Multiline = true;
            this.depola.Name = "depola";
            this.depola.Size = new System.Drawing.Size(180, 27);
            this.depola.TabIndex = 14;
            this.depola.TextChanged += new System.EventHandler(this.depola_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(819, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1019, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ram Slot Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(819, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ram Kapasitesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1019, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Depolama Alanı Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(819, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tür";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1019, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Marka";
            // 
            // Anakart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1251, 706);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depola);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.ramcap);
            this.Controls.Add(this.ramslot);
            this.Controls.Add(this.anakartid);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.anakartsil);
            this.Controls.Add(this.anakartekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anakart";
            this.Text = "Anakart";
            this.Load += new System.EventHandler(this.Anakart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button anakartekle;
        private System.Windows.Forms.Button anakartsil;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.TextBox anakartid;
        private System.Windows.Forms.TextBox ramslot;
        private System.Windows.Forms.TextBox ramcap;
        private System.Windows.Forms.TextBox tur;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox depola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}