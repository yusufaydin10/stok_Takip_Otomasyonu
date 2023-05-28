namespace stok_Takip_Otomasyonu
{
    partial class GuncelleSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuncelleSil));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.satis_F = new System.Windows.Forms.Label();
            this.alis_Fiyati = new System.Windows.Forms.TextBox();
            this.alis_F = new System.Windows.Forms.Label();
            this.satis_Fiyati = new System.Windows.Forms.TextBox();
            this.kategoriler = new System.Windows.Forms.ComboBox();
            this.barkod = new System.Windows.Forms.Label();
            this.barkod_No = new System.Windows.Forms.TextBox();
            this.kategori = new System.Windows.Forms.Label();
            this.urun_Fiyati = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.urun_Adet = new System.Windows.Forms.Label();
            this.stok = new System.Windows.Forms.TextBox();
            this.urunun_Adi = new System.Windows.Forms.Label();
            this.urun_Adi = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.guncelle = new System.Windows.Forms.Button();
            this.birim = new System.Windows.Forms.ComboBox();
            this.para_Birimi = new System.Windows.Forms.Label();
            this.tur = new System.Windows.Forms.ComboBox();
            this.Poset = new System.Windows.Forms.Label();
            this.urun_Ara = new System.Windows.Forms.TextBox();
            this.ara = new System.Windows.Forms.Button();
            this.satis_Sayisi = new System.Windows.Forms.TextBox();
            this.sat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // satis_F
            // 
            this.satis_F.AutoSize = true;
            this.satis_F.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.satis_F.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.satis_F.Location = new System.Drawing.Point(66, 501);
            this.satis_F.Name = "satis_F";
            this.satis_F.Size = new System.Drawing.Size(120, 23);
            this.satis_F.TabIndex = 32;
            this.satis_F.Text = "SATIŞ FİYATI";
            // 
            // alis_Fiyati
            // 
            this.alis_Fiyati.Location = new System.Drawing.Point(219, 561);
            this.alis_Fiyati.Multiline = true;
            this.alis_Fiyati.Name = "alis_Fiyati";
            this.alis_Fiyati.Size = new System.Drawing.Size(239, 31);
            this.alis_Fiyati.TabIndex = 31;
            this.alis_Fiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alis_Fiyati_KeyPress);
            // 
            // alis_F
            // 
            this.alis_F.AutoSize = true;
            this.alis_F.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alis_F.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.alis_F.Location = new System.Drawing.Point(67, 561);
            this.alis_F.Name = "alis_F";
            this.alis_F.Size = new System.Drawing.Size(111, 23);
            this.alis_F.TabIndex = 30;
            this.alis_F.Text = "ALIŞ FİYATI";
            // 
            // satis_Fiyati
            // 
            this.satis_Fiyati.Location = new System.Drawing.Point(219, 501);
            this.satis_Fiyati.Multiline = true;
            this.satis_Fiyati.Name = "satis_Fiyati";
            this.satis_Fiyati.Size = new System.Drawing.Size(239, 31);
            this.satis_Fiyati.TabIndex = 29;
            this.satis_Fiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.satis_Fiyati_KeyPress);
            // 
            // kategoriler
            // 
            this.kategoriler.FormattingEnabled = true;
            this.kategoriler.Items.AddRange(new object[] {
            "KİTAP",
            "OYUNCAK",
            "2.EL",
            "KIRTASİYE MALZEMELERİ",
            "BOYA MALZEMELERİ",
            "GİYİM",
            "ELEKTRONİK",
            "MUTFAK EŞYALARI",
            "EL İŞİ MALZEMELERİ",
            "OYUNLAR",
            "AKSESUARLAR",
            "BOYA MALZEMELERİ",
            "SINAV KİTAPLARI",
            "OKUMA KİTAPLARI",
            "DEKORASYON",
            ""});
            this.kategoriler.Location = new System.Drawing.Point(219, 331);
            this.kategoriler.Name = "kategoriler";
            this.kategoriler.Size = new System.Drawing.Size(239, 28);
            this.kategoriler.TabIndex = 28;
            // 
            // barkod
            // 
            this.barkod.AutoSize = true;
            this.barkod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barkod.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.barkod.Location = new System.Drawing.Point(12, 395);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(200, 23);
            this.barkod.TabIndex = 27;
            this.barkod.Text = "BARKOD NUMARASI";
            // 
            // barkod_No
            // 
            this.barkod_No.Location = new System.Drawing.Point(219, 395);
            this.barkod_No.Multiline = true;
            this.barkod_No.Name = "barkod_No";
            this.barkod_No.Size = new System.Drawing.Size(239, 31);
            this.barkod_No.TabIndex = 26;
            // 
            // kategori
            // 
            this.kategori.AutoSize = true;
            this.kategori.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kategori.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kategori.Location = new System.Drawing.Point(84, 336);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(107, 23);
            this.kategori.TabIndex = 25;
            this.kategori.Text = "KATEGORİ";
            // 
            // urun_Fiyati
            // 
            this.urun_Fiyati.AutoSize = true;
            this.urun_Fiyati.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urun_Fiyati.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.urun_Fiyati.Location = new System.Drawing.Point(99, 212);
            this.urun_Fiyati.Name = "urun_Fiyati";
            this.urun_Fiyati.Size = new System.Drawing.Size(61, 23);
            this.urun_Fiyati.TabIndex = 24;
            this.urun_Fiyati.Text = "FİYAT";
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(219, 204);
            this.fiyat.Multiline = true;
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(239, 31);
            this.fiyat.TabIndex = 23;
            this.fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiyat_KeyPress);
            // 
            // urun_Adet
            // 
            this.urun_Adet.AutoSize = true;
            this.urun_Adet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urun_Adet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.urun_Adet.Location = new System.Drawing.Point(67, 156);
            this.urun_Adet.Name = "urun_Adet";
            this.urun_Adet.Size = new System.Drawing.Size(125, 23);
            this.urun_Adet.TabIndex = 22;
            this.urun_Adet.Text = "STOK BİLGİSİ";
            // 
            // stok
            // 
            this.stok.Location = new System.Drawing.Point(219, 148);
            this.stok.Multiline = true;
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(239, 31);
            this.stok.TabIndex = 21;
            this.stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stok_KeyPress);
            // 
            // urunun_Adi
            // 
            this.urunun_Adi.AutoSize = true;
            this.urunun_Adi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunun_Adi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.urunun_Adi.Location = new System.Drawing.Point(84, 92);
            this.urunun_Adi.Name = "urunun_Adi";
            this.urunun_Adi.Size = new System.Drawing.Size(104, 23);
            this.urunun_Adi.TabIndex = 20;
            this.urunun_Adi.Text = "ÜRÜN ADI";
            // 
            // urun_Adi
            // 
            this.urun_Adi.Location = new System.Drawing.Point(219, 84);
            this.urun_Adi.Multiline = true;
            this.urun_Adi.Name = "urun_Adi";
            this.urun_Adi.Size = new System.Drawing.Size(239, 31);
            this.urun_Adi.TabIndex = 19;
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sil.ForeColor = System.Drawing.Color.White;
            this.sil.Location = new System.Drawing.Point(219, 685);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(142, 68);
            this.sil.TabIndex = 18;
            this.sil.Text = "ÜRÜNÜ SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(374, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(472, 44);
            this.title.TabIndex = 17;
            this.title.Text = "ÜRÜN GÜNCELLEME/SİLME";
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.guncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guncelle.ForeColor = System.Drawing.Color.White;
            this.guncelle.Location = new System.Drawing.Point(219, 604);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(211, 75);
            this.guncelle.TabIndex = 33;
            this.guncelle.Text = "ÜRÜNÜ GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // birim
            // 
            this.birim.FormattingEnabled = true;
            this.birim.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR"});
            this.birim.Location = new System.Drawing.Point(219, 269);
            this.birim.Name = "birim";
            this.birim.Size = new System.Drawing.Size(239, 28);
            this.birim.TabIndex = 35;
            // 
            // para_Birimi
            // 
            this.para_Birimi.AutoSize = true;
            this.para_Birimi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.para_Birimi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.para_Birimi.Location = new System.Drawing.Point(67, 274);
            this.para_Birimi.Name = "para_Birimi";
            this.para_Birimi.Size = new System.Drawing.Size(125, 23);
            this.para_Birimi.TabIndex = 34;
            this.para_Birimi.Text = "PARA BİRİMİ";
            // 
            // tur
            // 
            this.tur.FormattingEnabled = true;
            this.tur.Items.AddRange(new object[] {
            "ADET",
            "POŞET",
            "KUTU",
            "KOLİ"});
            this.tur.Location = new System.Drawing.Point(219, 448);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(239, 28);
            this.tur.TabIndex = 37;
            // 
            // Poset
            // 
            this.Poset.AutoSize = true;
            this.Poset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Poset.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Poset.Location = new System.Drawing.Point(67, 448);
            this.Poset.Name = "Poset";
            this.Poset.Size = new System.Drawing.Size(123, 23);
            this.Poset.TabIndex = 36;
            this.Poset.Text = "KUTU/POŞET";
            // 
            // urun_Ara
            // 
            this.urun_Ara.Location = new System.Drawing.Point(855, 76);
            this.urun_Ara.Multiline = true;
            this.urun_Ara.Name = "urun_Ara";
            this.urun_Ara.Size = new System.Drawing.Size(305, 41);
            this.urun_Ara.TabIndex = 38;
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ara.ForeColor = System.Drawing.Color.White;
            this.ara.Location = new System.Drawing.Point(1166, 76);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(115, 41);
            this.ara.TabIndex = 39;
            this.ara.Text = "ARA";
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // satis_Sayisi
            // 
            this.satis_Sayisi.Location = new System.Drawing.Point(874, 695);
            this.satis_Sayisi.Multiline = true;
            this.satis_Sayisi.Name = "satis_Sayisi";
            this.satis_Sayisi.Size = new System.Drawing.Size(346, 45);
            this.satis_Sayisi.TabIndex = 40;
            this.satis_Sayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.satis_Sayisi_KeyPress);
            // 
            // sat
            // 
            this.sat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sat.ForeColor = System.Drawing.Color.White;
            this.sat.Location = new System.Drawing.Point(1226, 695);
            this.sat.Name = "sat";
            this.sat.Size = new System.Drawing.Size(122, 45);
            this.sat.TabIndex = 41;
            this.sat.Text = "SAT";
            this.sat.UseVisualStyleBackColor = false;
            this.sat.Click += new System.EventHandler(this.sat_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-1, 712);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 49);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // geri
            // 
            this.geri.AutoSize = true;
            this.geri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.geri.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.geri.Location = new System.Drawing.Point(-1, 685);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(108, 23);
            this.geri.TabIndex = 43;
            this.geri.Text = "GERİ DÖN";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1410, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 36);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(621, 123);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(814, 502);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(500, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 104);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(436, 618);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 49);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(367, 702);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 49);
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // GuncelleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1447, 763);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sat);
            this.Controls.Add(this.satis_Sayisi);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.urun_Ara);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.Poset);
            this.Controls.Add(this.birim);
            this.Controls.Add(this.para_Birimi);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.satis_F);
            this.Controls.Add(this.alis_Fiyati);
            this.Controls.Add(this.alis_F);
            this.Controls.Add(this.satis_Fiyati);
            this.Controls.Add(this.kategoriler);
            this.Controls.Add(this.barkod);
            this.Controls.Add(this.barkod_No);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.urun_Fiyati);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.urun_Adet);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.urunun_Adi);
            this.Controls.Add(this.urun_Adi);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuncelleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuncelleSil";
            this.Load += new System.EventHandler(this.GuncelleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label satis_F;
        private TextBox alis_Fiyati;
        private Label alis_F;
        private TextBox satis_Fiyati;
        private ComboBox kategoriler;
        private Label barkod;
        private TextBox barkod_No;
        private Label kategori;
        private Label urun_Fiyati;
        private TextBox fiyat;
        private Label urun_Adet;
        private TextBox stok;
        private Label urunun_Adi;
        private TextBox urun_Adi;
        private Button sil;
        private Label title;
        private Button guncelle;
        private ComboBox birim;
        private Label para_Birimi;
        private ComboBox tur;
        private Label Poset;
        private TextBox urun_Ara;
        private Button ara;
        private TextBox satis_Sayisi;
        private Button sat;
        private Button button1;
        private Label geri;
        private Button button2;

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}