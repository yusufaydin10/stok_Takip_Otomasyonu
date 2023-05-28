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
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand command;
        DataSet ds;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = stok_Takipdb; Integrated Security=true");
        DataTable tbl=new DataTable();

        void Filtrele()
        {
            
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "urunadi like '" + urun_Ara.Text + "%' or barkodNo like '" + urun_Ara.Text + "%'";
            dataGridView1.DataSource = dv;
          
        }

        void tablogoster()
        {
           
            da = new SqlDataAdapter("Select *From urunTbl", connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "urunTbl");
            dataGridView1.DataSource = ds.Tables["urunTbl"];
            connection.Close();
        }


        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            {
          
                  
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                tablogoster();
                
                da.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {

            string sorgu = "delete from urunTbl where urunadi =@urunadi";
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@urunadi", urun_Adi.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            tablogoster();
            MessageBox.Show("Hasta Başarıyla Silindi");

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update urunTbl set fiyat=@fiyat,alisFiyati=@alisFiyati,satisFiyati=@satisFiyati,kategori=@kategori,tur=@tur,birim=@birim,stok=@stok,urunadi=@urunadi where barkodNo=@barkodNo";
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@urunadi", urun_Adi.Text.ToUpper());
            command.Parameters.AddWithValue("@fiyat", fiyat.Text);
            command.Parameters.AddWithValue("@alisFiyati", alis_Fiyati.Text);
            command.Parameters.AddWithValue("@satisFiyati", satis_Fiyati.Text);
            command.Parameters.AddWithValue("@barkodNo", barkod_No.Text);
            command.Parameters.AddWithValue("@kategori", kategoriler.Text);
            command.Parameters.AddWithValue("@tur", tur.Text);
            command.Parameters.AddWithValue("@birim", birim.Text);
            command.Parameters.AddWithValue("@stok", stok.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            tablogoster();
            MessageBox.Show("Hasta Başarıyla Güncellendi");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            urun_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            stok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kategoriler.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            barkod_No.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            alis_Fiyati.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            satis_Fiyati.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tur.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            birim.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            
        }

        private void ara_Click(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void sat_Click(object sender, EventArgs e)
        {
            if (satis_Sayisi.Text == "")
            {
                MessageBox.Show("Satış Miktarını Giriniz");
            }
            else { 
            int satilan = Convert.ToInt32(satis_Sayisi.Text);
            string sorgu = "Update urunTbl set stok=stok-@satilan where barkodNo=@barkodNo AND stok>=@satilan";

            SqlCommand command = new SqlCommand(sorgu, connection);
            
            command.Parameters.AddWithValue("@satilan",satilan);
            command.Parameters.AddWithValue("@barkodNo", barkod_No.Text);
            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            string deleteQuery = "DELETE FROM UrunTbl WHERE stok <= 0";
            SqlCommand deletecommand = new SqlCommand(deleteQuery, connection);
            int deletedRows = deletecommand.ExecuteNonQuery();
            connection.Close();
            tablogoster();
            MessageBox.Show("Ürün satıldı.Güncellendi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fiyat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void alis_Fiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void satis_Sayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
