using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Logging;

namespace stok_Takip_Otomasyonu
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = stok_Takipdb; Integrated Security=true");


        private void kayit_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || sur_Name.Text == "" || e_Mail.Text == "" || user_Name.Text == "" || password.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into uyeTbl(name,surname,email,username,password) values('" + name.Text + "','" + sur_Name.Text + "','" + e_Mail.Text + "','" + user_Name.Text + "','" + password.Text + "')", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı");
                    connection.Close();
                    name.Text = "";
                    sur_Name.Text = "";
                    user_Name.Text = "";
                    password.Text = "";
                    e_Mail.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }


            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            name.Text = "";
            sur_Name.Text = "";
            user_Name.Text = "";
            password.Text = "";
            e_Mail.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sur_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Register_Load(object sender, EventArgs e)
        {

        }

     
    }
}
