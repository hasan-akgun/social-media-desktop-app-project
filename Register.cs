using MySql.Data.MySqlClient;

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
    }
}
