using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace social_media
{
    public partial class Login : Form
    {
        MySqlConnection connection;
        Register registerform;

        public Login()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;user=root;database=user_database;password=A98x%kG1n.45#;");
        }



        private void Login_Load(object sender, EventArgs e)
        {
            registerform = new Register();

            try
            {
                connection.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Connected: " + ex.Message);
            }

        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !(txtPassword.UseSystemPasswordChar);
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerform.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string password = txtPassword.Text;
            if (ValidateUser(id, password))
            {
                MessageBox.Show("Login Succesfull");
                connection.Close();
                registerform.Close();
                Main_Page main_Page = new Main_Page();
                main_Page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not valid id or password");
            }
        }

        //VERİTABANINDAKİ KULLANICIYI KARŞILAŞTIRMA
        private bool ValidateUser(string id, string password)
        {
            string query = "SELECT * FROM users WHERE id = @id AND password = @password";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
    }
}
