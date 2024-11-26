using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace social_media
{
    public partial class Register : Form
    {
        MySqlConnection connection;
        public Register()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;user=root;database=user_database;password=A98x%kG1n.45#;");

        }
        private void Register_Load(object sender, EventArgs e)
        {

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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string id = txtId.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Enter ID, Name and Password!");
                return;
            }
            else if (!Regex.IsMatch(id, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("ID can not include special characters!");
                return;
            }
            else if (username.Length > 20)
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

            try
            {
                string query = "INSERT INTO users (id, username, password) VALUES (@id, @username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Registiration is succesfull");
                    Login loginform = new Login();
                    this.Hide();
                    loginform.Show();
                }
                else
                {
                    MessageBox.Show("Registiration is unsuccesfull");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Registiration error: " + ex.Message);
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !(txtPassword.UseSystemPasswordChar);
            txtConfirm.UseSystemPasswordChar = !(txtConfirm.UseSystemPasswordChar);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
        }

        private void lblBackLogin_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            this.Hide();
            loginform.Show();
        }
    }
}
