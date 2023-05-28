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


namespace stok_Takip_Otomasyonu
{
  
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = stok_Takipdb; Integrated Security=true");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (user_Name.Text == "" ||
            password.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                bool isThere = false;
                connection.Open();
                SqlCommand command = new SqlCommand("select *from uyeTbl", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (user_Name.Text == reader["username"].ToString() && password.Text == reader["password"].ToString())
                    {
                        isThere = true;
                        break;
                    }
                    else
                    {
                        isThere = false;
                    }
                }
                connection.Close();
                if (isThere)
                {
                    Anasayfa anasayfa = new Anasayfa();
                    anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriþ Yapamadýnýz ");
                    user_Name.Text = "";
                    password.Text = "";

                }

                }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            user_Name.Text = "";
            password.Text = "";
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                login.PerformClick();
            }
        }

   

     
    }
}