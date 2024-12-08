using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace social_media
{
    public partial class Main_Page : Form
    {

        post_manager post_manager;
        post_structure post_structure;
        Login login;

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private int pre = 0;
        private int numchar = 300;

        public Main_Page(Login loginform)
        {
            InitializeComponent();
            this.FormClosing += Main_Page_FormClosing;
            post_manager = new post_manager();
            post_structure = new post_structure();
            login = loginform;
            rtxbSendingPost.TextChanged += RichTextBox_TextChanged;
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

            lblUsername.Text = "@" + login.Username;

            string[] Posts = post_manager.posts;
            int i = 0;
            foreach (string content in Posts)
            {
                i++;
                post_structure.AddPost(mainPanel, content, i);

                //Caret silme
                RichTextBox? post = FindControlRecursive(mainPanel, $"Post{i}") as RichTextBox;
                if (post != null)
                {
                    this.MouseMove += (sender, e) => HideCaret(post.Handle);
                    post.MouseClick += (sender, e) => HideCaret(post.Handle);
                }
                else
                {
                    MessageBox.Show("");
                }

            };

        }




        private void Main_Page_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private Control FindControlRecursive(Control parent, string name)
        {
            if (parent.Name == name)
                return parent;

            foreach (Control child in parent.Controls)
            {
                Control found = FindControlRecursive(child, name);
                if (found != null)
                    return found;
            }

            return null;
        }

        private void createPostButton_Click(object sender, EventArgs e)
        {
            createPanel.Show();
        }

        private void createPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            int curr = rtxbSendingPost.Text.Length;
            if (curr > pre)
            {
                numchar--;
                numChar.Text = numchar.ToString();
                pre = curr;
                if (numchar == 0)
                {
                    numChar.ForeColor = Color.Red;
                }
            }
            else
            {
                numchar++;
                numChar.Text = numchar.ToString();
                pre = curr;
                if (numchar != 0)
                {
                    numChar.ForeColor = Color.Black;
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxbSendingPost.Rtf = null;
            numchar = 300;
            numChar.Text = "300";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createPanel.Hide();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            
            if (await RegisterUser(login.Username, rtxbSendingPost))
            {
                MessageBox.Show("Post sent");
            }
            else
                MessageBox.Show("Error");
        }

        private async Task<bool> RegisterUser(string username, RichTextBox richTextBox)
        {
            using (HttpClient client = new HttpClient())
            {
                string rtfContent = richTextBox.Rtf;
                // API'ya gönderilecek veriler
                var values = new Dictionary<string, string>
                {
                    { "loginUser", username },
                    { "postContent", rtfContent },
                };

                // Verileri form-encoded olarak gönder
                var content = new FormUrlEncodedContent(values);

                // API'ya POST isteği gönder
                var response = await client.PostAsync("https://oasisgamequizium.shop/OOPProject/Posts/PostNewPost.php", content);

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
