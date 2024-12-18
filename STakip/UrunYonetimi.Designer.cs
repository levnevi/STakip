namespace STakip
{
    partial class UrunYonetimi
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
            this.gbUrunKayitFormu = new System.Windows.Forms.GroupBox();
            this.rtbUrunOzellikleri = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Kategori = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtMarkasi = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbUrunKayitFormu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // gbUrunKayitFormu
            // 
            this.gbUrunKayitFormu.Controls.Add(this.rtbUrunOzellikleri);
            this.gbUrunKayitFormu.Controls.Add(this.label7);
            this.gbUrunKayitFormu.Controls.Add(this.btnKaydet);
            this.gbUrunKayitFormu.Controls.Add(this.cbDurum);
            this.gbUrunKayitFormu.Controls.Add(this.cmbKategori);
            this.gbUrunKayitFormu.Controls.Add(this.label6);
            this.gbUrunKayitFormu.Controls.Add(this.Kategori);
            this.gbUrunKayitFormu.Controls.Add(this.txtFiyat);
            this.gbUrunKayitFormu.Controls.Add(this.txtMarkasi);
            this.gbUrunKayitFormu.Controls.Add(this.txtUrunAdi);
            this.gbUrunKayitFormu.Controls.Add(this.label5);
            this.gbUrunKayitFormu.Controls.Add(this.label4);
            this.gbUrunKayitFormu.Controls.Add(this.label3);
            this.gbUrunKayitFormu.Location = new System.Drawing.Point(99, 230);
            this.gbUrunKayitFormu.Name = "gbUrunKayitFormu";
            this.gbUrunKayitFormu.Size = new System.Drawing.Size(763, 175);
            this.gbUrunKayitFormu.TabIndex = 4;
            this.gbUrunKayitFormu.TabStop = false;
            this.gbUrunKayitFormu.Text = "Ürün Girişi";
            // 
            // rtbUrunOzellikleri
            // 
            this.rtbUrunOzellikleri.Location = new System.Drawing.Point(551, 44);
            this.rtbUrunOzellikleri.Name = "rtbUrunOzellikleri";
            this.rtbUrunOzellikleri.Size = new System.Drawing.Size(142, 96);
            this.rtbUrunOzellikleri.TabIndex = 12;
            this.rtbUrunOzellikleri.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ürün Özellikleri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(250, 106);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(168, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(297, 80);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(47, 17);
            this.cbDurum.TabIndex = 9;
            this.cbDurum.Text = "Aktif";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Elektronik",
            "Bilgisayar",
            "Telefon",
            "Kitap",
            "Mobilya"});
            this.cmbKategori.Location = new System.Drawing.Point(297, 41);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Durum";
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Location = new System.Drawing.Point(244, 41);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(46, 13);
            this.Kategori.TabIndex = 6;
            this.Kategori.Text = "Kategori";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(91, 106);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 5;
            // 
            // txtMarkasi
            // 
            this.txtMarkasi.Location = new System.Drawing.Point(91, 74);
            this.txtMarkasi.Name = "txtMarkasi";
            this.txtMarkasi.Size = new System.Drawing.Size(100, 20);
            this.txtMarkasi.TabIndex = 4;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(91, 35);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Markası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı";
            // 
            // UrunYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 505);
            this.Controls.Add(this.gbUrunKayitFormu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunYonetimi";
            this.Text = "UrunYonetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbUrunKayitFormu.ResumeLayout(false);
            this.gbUrunKayitFormu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbUrunKayitFormu;
        private System.Windows.Forms.RichTextBox rtbUrunOzellikleri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Kategori;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtMarkasi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}