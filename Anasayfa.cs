using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace stok_Takip_Otomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void urun_Ekle_Click(object sender, EventArgs e)
        {
            UrunEkle urunekle = new UrunEkle();
            urunekle.Show();
            this.Hide();
        }

        private void urunleri_Goster_Click(object sender, EventArgs e)
        {
            UrunArama urunarama = new UrunArama();
            urunarama.Show();
            this.Hide();
        }

        

        private void urun_Guncelle_Click(object sender, EventArgs e)
        {
            GuncelleSil guncellesil = new GuncelleSil();
            guncellesil.Show();
            this.Hide();
        }

        private void istatistik_Click(object sender, EventArgs e)
        {
            İstatistikler istatistikler = new İstatistikler();
            istatistikler.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
