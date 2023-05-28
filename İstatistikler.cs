using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok_Takip_Otomasyonu
{
    public partial class İstatistikler : Form
    {
        public İstatistikler()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = stok_Takipdb; Integrated Security=true");

        private void İstatistikler_Load(object sender, EventArgs e)
        {

        }

        private void goster_Click(object sender, EventArgs e)
        {
            decimal toplamKar = 0, toplamKar1 = 0, toplamKar2 = 0;
            decimal toplamFiyat = 0, toplamFiyat1 = 0, toplamFiyat2 = 0;
            decimal toplamAlis = 0, toplamAlis1 = 0, toplamAlis2 = 0;
            decimal toplamSatis = 0, toplamSatis1 = 0, toplamSatis2 = 0;
            connection.Open();
            SqlCommand command = new SqlCommand("select *from urunTbl", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int stok = (reader.GetInt32(2));
                decimal alis_Fiyati = reader.GetDecimal(6);
                decimal satis_Fiyati = reader.GetDecimal(7);
                decimal fiyat = reader.GetDecimal(3);
                string tur = reader.GetString(9);
                if (tur == "TRY")
                {
                    decimal kar = stok * (satis_Fiyati - alis_Fiyati);
                    toplamKar += kar;
                    toplamFiyat += stok * fiyat;
                    toplamAlis += stok * alis_Fiyati;
                    toplamSatis += stok * satis_Fiyati;
                }
                else if (tur == "EUR")
                {
                    decimal kar1 = stok * (satis_Fiyati - alis_Fiyati);
                    toplamKar1 += kar1;
                    toplamFiyat1 += stok * fiyat;
                    toplamAlis1 += stok * alis_Fiyati;
                    toplamSatis1 += stok * satis_Fiyati;
                }
                else
                {
                    decimal kar2 = stok * (satis_Fiyati - alis_Fiyati);
                    toplamKar2 += kar2;
                    toplamFiyat2 += stok * fiyat;
                    toplamAlis2 += stok * alis_Fiyati;
                    toplamSatis2 += stok * satis_Fiyati;
                }


            }
            reader.Close();
            connection.Close();
            label1.Text = "Toplam Kar : " + toplamKar.ToString() + " TRY / " + toplamKar1.ToString() + " EUR / " + toplamKar2.ToString() + " USD";
            label2.Text = "Ürünlerin Toplam Güncel Fiyat : " + toplamFiyat.ToString() + " TRY / " + toplamFiyat1.ToString() + " EUR / " + toplamFiyat2.ToString() + "USD";
            label3.Text = "Toplam Satış Fiyatı : " + toplamSatis.ToString() + " TRY / " + toplamSatis1.ToString() + " EUR / " + toplamSatis2.ToString() + " USD";
            label4.Text = "Toplam Alış Fiyatı : " + toplamAlis.ToString() + " TRY / " + toplamAlis1.ToString() + " EUR / " + toplamAlis2.ToString() + " USD";
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
