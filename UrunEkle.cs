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
using System.Xml.Linq;

namespace stok_Takip_Otomasyonu
{
    public partial class UrunEkle : Form
    {
    
        public UrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = stok_Takipdb; Integrated Security=true");

        private void ekle_Click(object sender, EventArgs e)
        {
            string yeni_Kategori = kategori_Ekle.Text.ToUpper();
            if (!string.IsNullOrEmpty(yeni_Kategori))
            {
                try
                {

                    string query = "SELECT COUNT(*) FROM kategorilerTbl WHERE LOWER(kategori) = UPPER(@kategori)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kategori", yeni_Kategori);

                    connection.Open();
                    int ayni_kategori = (int)command.ExecuteScalar();

                    if (ayni_kategori > 0)
                    {
                        MessageBox.Show("Bu kategori zaten mevcut.");
                    }
                    else
                    {
                        query = "INSERT INTO kategorilerTbl (kategori) VALUES (@kategori)";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@kategori", yeni_Kategori);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Kategori başarıyla eklendi.");

                        kategoriler.Items.Add(yeni_Kategori);
                        kategori_Ekle.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            string silinecek_Kategori = kategori_Ekle.Text;

            if (!string.IsNullOrEmpty(silinecek_Kategori))
            {
                try
                {
                    string query = "DELETE FROM kategorilerTbl WHERE LOWER(kategori) = UPPER(@kategori)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kategori", silinecek_Kategori);

                    connection.Open();
                    int guncelle = command.ExecuteNonQuery();

                    if (guncelle > 0)
                    {
                        MessageBox.Show("Kategori başarıyla silindi.");
                        kategoriler.Items.Remove(silinecek_Kategori);
                        kategori_Ekle.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Kategori bulunamadı.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT kategori FROM kategorilerTbl";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string kategori = reader["kategori"].ToString();
                    kategoriler.Items.Add(kategori);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void urun_Ekle_Click(object sender, EventArgs e)
        {
            if (urun_Adi.Text == "" || stok_Bilgisi.Text == "" || urun_Fiyati.Text == "" || alis_Fiyati.Text == "" || satis_Fiyati.Text == "" || barkod_No.Text == "" || tur.SelectedIndex == -1 || kategoriler.SelectedIndex == -1 || birim.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into urunTbl(urunadi,stok,fiyat,kategori,barkodNo,alisFiyati,satisFiyati,tur,birim) values ('" + (urun_Adi.Text.ToUpper() + "','" + stok_Bilgisi.Text + "','" + urun_Fiyati.Text + "','" + kategoriler.SelectedItem.ToString() + "','" + barkod_No.Text + "','" + alis_Fiyati.Text + "','" + satis_Fiyati.Text + "','" + tur.SelectedItem.ToString() + "','" + birim.SelectedItem.ToString() + "')"), connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("ürün eklendi");
                    connection.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void stok_Bilgisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void urun_Fiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void alis_Fiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void satis_Fiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void kategori_Ekle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

    

