namespace stok_Takip_Otomasyonu
{
    partial class UrunSat
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
            this.urun_Ara = new System.Windows.Forms.TextBox();
            this.ara = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // urun_Ara
            // 
            this.urun_Ara.Location = new System.Drawing.Point(394, 115);
            this.urun_Ara.Multiline = true;
            this.urun_Ara.Name = "urun_Ara";
            this.urun_Ara.Size = new System.Drawing.Size(386, 45);
            this.urun_Ara.TabIndex = 0;
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.Crimson;
            this.ara.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ara.ForeColor = System.Drawing.Color.White;
            this.ara.Location = new System.Drawing.Point(786, 115);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(94, 45);
            this.ara.TabIndex = 1;
            this.ara.Text = "ARA";
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Crimson;
            this.title.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(431, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(353, 44);
            this.title.TabIndex = 2;
            this.title.Text = "ÜRÜN SATIŞ EKRANI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(713, 347);
            this.dataGridView1.TabIndex = 3;
            // 
            // UrunSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 677);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.urun_Ara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunSat";
            this.Load += new System.EventHandler(this.UrunSat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox urun_Ara;
        private Button ara;
        private Label title;
        private DataGridView dataGridView1;
        private Button sat;
        private TextBox satis_Sayisi;
    }
}