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
    public partial class UrunSat : Form
    {
        public UrunSat()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = stok_Takipdb; Integrated Security=true");
        DataTable tbl = new DataTable();
        void Filtrele()
        {
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "urunadi like '" + urun_Ara.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        

        private void UrunSat_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urunTbl", connection);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void sat_Click(object sender, EventArgs e)
        {
           
        }

        private void satis_Sayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void ara_Click(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}
