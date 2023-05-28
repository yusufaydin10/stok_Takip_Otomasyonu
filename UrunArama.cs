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
    public partial class UrunArama : Form
    {
        public UrunArama()
        {
            InitializeComponent();
           
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = stok_Takipdb; Integrated Security=true");
        DataTable tbl = new DataTable();
        void Filtrele()
        {
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "urunadi like '" + urun_Ara.Text + "%' or barkodNo like '" + urun_Ara.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void UrunArama_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urunTbl", connection);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void ara_Click(object sender, EventArgs e)
        {
            Filtrele();
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
