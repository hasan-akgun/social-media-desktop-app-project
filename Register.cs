using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace social_media
{
    public partial class Register : Form
    {
        MySqlConnection connection;
        Login loginform;
        public Register()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;user=root;database=user_database;password=A98x%kG1n.45#;");

        }
        private void Register_Load(object sender, EventArgs e)
        {

            loginform = new Login();
            

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

        private void getStarted_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string username = txtUsername.Text;

            // GÝRDÝLERÝN GEÇERLÝ OLUP OLMADIÐININ KONTROLÜ
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please Enter ID, Name and Password!");
                return;
            }
            else if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("ID can not include special characters!");
                return;
            }
            else if (name.Length > 20)
            {
                MessageBox.Show("Username must be below 20 character!");
                return;
            }
            else if (password.Length < 7)
            {
                MessageBox.Show("Password must be contain at least 8 characters!");
                return;
            }
            else if (txtConfirm.Text != txtPassword.Text)
            {
                MessageBox.Show("Check the password!");
                return;
            }

            //VERÝTABANINA KAYIT ÝÞLEMÝ
            try
            {
                string query = "INSERT INTO users (id, username, password) VALUES (@id, @username, @password)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", username);
                    cmd.Parameters.AddWithValue("@username", name);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Registiration is succesfull");
                        this.Hide();
                        loginform.Show();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registiration is unsuccesfull");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Registiration error: " + ex.Message);
            }
        }

        //ÞÝFRE GÖSTER/GÝZLE
        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !(txtPassword.UseSystemPasswordChar);
            txtConfirm.UseSystemPasswordChar = !(txtConfirm.UseSystemPasswordChar);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
        }

        private void lblBackLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform.Show();
            connection.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
