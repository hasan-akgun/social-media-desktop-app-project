using System.Text.RegularExpressions;
using Newtonsoft.Json;
namespace social_media
{
    public partial class Register : Form
    {
        Login loginform;
        public Register()
        {
            InitializeComponent();
            txtPassword.KeyPress += TextBox_KeyPress;
            txtConfirm.KeyPress += TextBox_KeyPress;
        }
        private void Register_Load(object sender, EventArgs e)
        {
            loginform = new Login();        
        }

        private void getStarted_Click(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string password = txtPassword.Text;
            string username = txtUsername.Text.Trim();

            // G�RD�LER�N GE�ERL� OLUP OLMADI�ININ KONTROL�
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
            if (await RegisterUser(username, password, name))
            {
                MessageBox.Show("Registiration is succesfull");
                this.Hide();
                loginform.Show();
            }
            
        }

        //��FRE G�STER/G�ZLE
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
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bo�luk karakteri tespit edilirse i�lemi iptal etme
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Bo�luk karakterini iptal et
            }
        }


        private async Task<bool> RegisterUser(string username, string password, string name)
        {
            using (HttpClient client = new HttpClient())
            {
                // API'ya g�nderilecek veriler
                var values = new Dictionary<string, string>
                {
                    { "loginUser", username },
                    { "loginName", name },
                    { "loginPass", password },
                };

                // Verileri form-encoded olarak g�nder
                var content = new FormUrlEncodedContent(values);

                // API'ya POST iste�i g�nder
                var response = await client.PostAsync("https://oasisgamequizium.shop/OOPProject/Register.php", content);

                if (response.IsSuccessStatusCode)
                {
                    // API yan�t�n� oku
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("API Yan�t�: " + responseString); // Yan�t� kontrol etmek i�in ekrana yazd�r

                    try
                    {
                        // Yan�t� dinamik olarak JSON ayr��t�r
                        dynamic responseObject = JsonConvert.DeserializeObject(responseString);

                        if (responseObject.status == "success")
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show((string)responseObject.message);
                        }
                    }
                    catch (JsonReaderException ex)
                    {
                        MessageBox.Show("JSON Ayr��t�rma Hatas�: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("API �a�r�s� ba�ar�s�z oldu. Durum kodu: " + response.StatusCode);
                }

                return false;
            }
        }

    }
}
