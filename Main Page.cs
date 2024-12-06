using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace social_media
{
    public partial class Main_Page : Form
    {
        post_manager post_manager;
        public Main_Page()
        {
            InitializeComponent();
            this.FormClosing += Main_Page_FormClosing;
            post_manager = new post_manager();
           
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            string[] Posts = post_manager.posts;
            foreach (string content in Posts)
            {
                int i = 0;
                i++;
                AddPost(content, i);

            };
            
            RichTextBox post1 = panel.Controls["Post1"] as RichTextBox;
            
        }

        private void AddPost(string content, int i)
        {
            

            // RichTextBox oluşturma ve forma ekleme
            RichTextBox postText = new RichTextBox();
            postText.Name = $"Post{i}";
            postText.Multiline = true; // Çok satırlı RichTextBox
            postText.ReadOnly = true; // Sadece okunabilir yap
            postText.Width = 650; // RichTextBox genişliği   
            postText.BorderStyle = BorderStyle.None;
            postText.BackColor = Color.WhiteSmoke;
            postText.Margin= new Padding(0,0,0,0);
            postText.Font = new Font("Arial", 15, FontStyle.Regular); // Font ayarı          
            postText.Text = content;
            int dynamicHeight = DynamicHeight(postText);
            postText.Height = dynamicHeight;

            PictureBox avatar = new PictureBox
            {
                Name = "PictureBox1",
                Size = new Size(80, 80), // PictureBox boyutları
                SizeMode = PictureBoxSizeMode.StretchImage, // Resim boyutlama modu
                BackColor = Color.Blue,
            };

            Button like = new Button()
            {
                Width = 50,
                Height = 50,
                BackColor = Color.Brown
            };

            Button comment = new Button()
            {
                Width = 50,
                Height = 50,
                BackColor = Color.Brown,
                Margin = new Padding(100, 3, 3, 3)
            };

            FlowLayoutPanel postPanel = new FlowLayoutPanel()
            {
                Width = panel.Width - 30,
                BorderStyle = BorderStyle.None,
                Height = dynamicHeight+115,
                BackColor= Color.Purple,
            };



            FlowLayoutPanel avatarPanel = new FlowLayoutPanel()
            {
                Width = 80,
                Height = 80,
                BorderStyle = BorderStyle.None,
                BackColor = Color.Green
            };


            FlowLayoutPanel labelPanel = new FlowLayoutPanel()
            {
                Width = postPanel.Width-100,
                Height = postPanel.Height,
                BorderStyle = BorderStyle.None,
                BackColor =Color.White,
            };

            FlowLayoutPanel textPanel = new FlowLayoutPanel()
            {
                BorderStyle = BorderStyle.None,
                Width = labelPanel.Width,
                Height = dynamicHeight+60,
                BackColor=Color.Red,
            };

            FlowLayoutPanel buttonPanel = new FlowLayoutPanel()
            {
                Width = textPanel.Width,
                Height = 55,
                BackColor = Color.Turquoise,
                BorderStyle = BorderStyle.None
            };

            Label lblUsername = new Label();
            lblUsername.Text = "username";
            lblUsername.AutoSize = true;
            lblUsername.Margin = new Padding(0, 1, 0, 0);
            lblUsername.Font = new Font("Arial", 15, FontStyle.Bold);

            Label lblId = new Label();
            lblId.Text = "@id";
            lblId.AutoSize = true;
            lblId.Margin = new Padding(0, 1, 0, 0);
            lblId.Font = new Font("Arial", 15, FontStyle.Regular);
            lblId.ForeColor = Color.Gray;



            // RichTextBox'ı panelin içine ekle
            panel.Controls.Add(postPanel);
            postPanel.Controls.Add(avatarPanel);
            postPanel.Controls.Add(labelPanel);
            labelPanel.Controls.Add(lblUsername);
            labelPanel.Controls.Add(lblId);
            labelPanel.Controls.Add(textPanel);
            avatarPanel.Controls.Add(avatar);
            textPanel.Controls.Add(postText);
            textPanel.Controls.Add(buttonPanel);
            buttonPanel.Controls.Add(like);
            buttonPanel.Controls.Add(comment);



        }
        private int DynamicHeight(RichTextBox richTextBox)
        {
            int lineHeight = richTextBox.Font.Height;
            int lineCount = richTextBox.GetLineFromCharIndex(richTextBox.Text.Length - 1) + 1;
            return (lineCount * lineHeight)+20; // Satır sayısı * satır yüksekliği + biraz boşluk
        }


        private void Main_Page_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
