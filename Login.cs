using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace social_media
{
    public partial class Login : Form
    {
        Register registerform;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            registerform = new Register();
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerform.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kullanıcı adı ve şifreyi kontrol et
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!");
                return;
            }

            // Kullanıcı doğrulama
            if (await ValidateUser(username, password))
            {
                MessageBox.Show("Giriş Başarılı!");
                Main_Page main_Page = new Main_Page();
                main_Page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre!");
            }
        }

        // Kullanıcıyı doğrulayan fonksiyon
        private async Task<bool> ValidateUser(string id, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                // API'ya gönderilecek veriler
                var values = new Dictionary<string, string>
                {
                    { "loginUser", id },
                    { "loginPass", password }
                };

                // Verileri form-encoded olarak gönder
                var content = new FormUrlEncodedContent(values);

                // API'ya POST isteği gönder
                var response = await client.PostAsync("https://oasisgamequizium.shop/OOPProject/Login.php", content);

                if (response.IsSuccessStatusCode)
                {
                    // API yanıtını oku
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("API Yanıtı: " + responseString); // Yanıtı kontrol etmek için ekrana yazdır

                    try
                    {
                        // Yanıtı dinamik olarak JSON ayrıştır
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
                        MessageBox.Show("JSON Ayrıştırma Hatası: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("API çağrısı başarısız oldu. Durum kodu: " + response.StatusCode);
                }

                return false;
            }
        }
    }
}
