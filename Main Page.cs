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

        PostManager PostManager;
        post_structure post_structure;
        Login login;
        Random random;
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private int pre_char = 0;
        private int numchar = 300;
        private int curr_char;
        private int see = 1;
        private int list_post_num;
        private int curr_post_num=0;
        private int randomize;
        private int pre_list = 0;
        public Main_Page(Login loginform)
        {
            InitializeComponent();
            this.FormClosing += Main_Page_FormClosing;
            PostManager = new PostManager();
            post_structure = new post_structure();
            login = loginform;
            random = new Random();
            lblSee.Visible = false;
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "@" + login.Username.ToLower();
            LoadPosts();
        }

        private async void LoadPosts()
        {
            await PostManager.LoadPostsAsync();
            while (curr_post_num < see * 10)
            {
                DisplayPosts();
                CountPosts();
            }
            mainPanel.Controls.Add(lblSee);
            lblSee.Visible = true;
        }

        private void DisplayPosts()
        {
            int i = 0;
            foreach (var post in PostManager.Posts)
            {
                randomize = random.Next(1, 5);
                i++;

                if (!post.isShown && randomize == 2)
                {
                    post_structure.AddPost(mainPanel, post, i);
                    post.isShown = true;
                }
                //Caret silme
                RichTextBox? find = FindControlRecursive(mainPanel, $"text{i}") as RichTextBox;
                if (find != null)
                {
                    this.MouseMove += (sender, e) => HideCaret(find.Handle);
                    find.MouseClick += (sender, e) => HideCaret(find.Handle);
                }

                CountPosts();
                if (curr_post_num > (see*10)-1)
                {
                    return;
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

            if (await SendPost(login.Username, rtxbSendingPost))
            {
                MessageBox.Show("Post sent");
                rtxbSendingPost.Rtf = null;
                createPanel.Hide();
            }
            else
                MessageBox.Show("Error");
        }

        private void rtxbSendingPost_TextChanged(object sender, EventArgs e)
        {
            curr_char = rtxbSendingPost.Text.Length;
            if (curr_char > pre_char)
            {
                numchar -= (curr_char - pre_char);
                numChar.Text = numchar.ToString();
                pre_char = curr_char;
                if (numchar == 0)
                {
                    numChar.ForeColor = Color.Red;
                }
            }
            else
            {
                numchar += (pre_char - curr_char);
                numChar.Text = numchar.ToString();
                pre_char = curr_char;
                if (numchar != 0)
                {
                    numChar.ForeColor = Color.Black;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblSee.Visible = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(lblSee);
            see = 1;
            curr_post_num = 0;
            LoadPosts();
        }

        private void lblSee_Click(object sender, EventArgs e)
        {       
            list_post_num = PostManager.Posts.Count;
            CountPosts();
            if (list_post_num == curr_post_num)
            {
                pre_list=list_post_num;
                MessageBox.Show("equal");
                return;
            }
            see++;
            if (list_post_num + pre_list > see * 10)
            {
                while (curr_post_num < see * 10)
                {
                    DisplayPosts();
                    CountPosts();
                }
            }
            else
            {
                int remain_post_num = (list_post_num + pre_list) - curr_post_num;
                while (remain_post_num != 0)
                {
                    DisplayPosts();
                    CountPosts();
                    remain_post_num = (list_post_num + pre_list) - curr_post_num;
                }
            }
            mainPanel.Controls.Add(lblSee);
        }

        private void CountPosts()
        {
            curr_post_num = 0;
            foreach (Control control in mainPanel.Controls)
            {
                if (control.Name.Contains("Post"))
                {
                    curr_post_num++;
                }
            }

        }

        private async Task<bool> SendPost(string username, RichTextBox richTextBox)
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
