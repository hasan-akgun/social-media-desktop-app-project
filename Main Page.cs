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
            post1.Text = "buldum";
        }

        private void AddPost(string content, int i)
        {
            // RichTextBox oluşturma ve forma ekleme
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Name = $"Post{i}";
            richTextBox.Multiline = true; // Çok satırlı RichTextBox
            richTextBox.ReadOnly = true; // Sadece okunabilir yap
            richTextBox.Width = 800; // RichTextBox genişliği   
            richTextBox.BackColor = Color.WhiteSmoke;
            richTextBox.Font = new Font("Arial", 20, FontStyle.Regular); // Font ayarı          
            richTextBox.Text = content;
            panel.Controls.Add(richTextBox); // RichTextBox'ı panelin içine ekle
            AdjustRichTextBoxHeight(richTextBox);
        }
        private void AdjustRichTextBoxHeight(RichTextBox richTextBox)
        {
            int lineHeight = richTextBox.Font.Height;
            int lineCount = richTextBox.GetLineFromCharIndex(richTextBox.Text.Length - 1) + 1;
            int margin = 5;
            richTextBox.Height = (lineCount * lineHeight) + margin; // Satır sayısı * satır yüksekliği + biraz boşluk
        }

        private void Main_Page_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
