using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace social_media
{
    internal class post_structure
    {

        public void AddPost(Panel panel, Post post , int i)
        {
            
            // RichTextBox oluşturma ve forma ekleme
            RichTextBox postText = new RichTextBox();
            postText.Name = $"text{i}";
            postText.Multiline = true; // Çok satırlı RichTextBox
            postText.ReadOnly = true; // Sadece okunabilir yap
            postText.Width = 650; // RichTextBox genişliği   
            postText.BorderStyle = BorderStyle.None;
            postText.BackColor = Color.WhiteSmoke;
            postText.Margin = new Padding(0, 0, 0, 0);
            postText.Font = new Font("Arial", 15, FontStyle.Regular); // Font ayarı          
            postText.Rtf = post.Text;
            postText.Height = 500; //Satır sayısını sayarken GetLine metodunun doğru çalışması için 
            postText.AutoWordSelection = true;
            int dynamicHeight = DynamicHeight(postText);
            postText.Height = dynamicHeight;

            PictureBox avatar = new PictureBox
            {
                Name = "PictureBox1",
                Size = new Size(80, 80), // PictureBox boyutları
                SizeMode = PictureBoxSizeMode.StretchImage, // Resim boyutlama modu
                BackColor = Color.Blue,
                Cursor = Cursors.Hand,
            };

            Button like = new Button()
            {
                Width = 50,
                Height = 50,
                BackColor = Color.Brown,
                Margin = new Padding(100, 0, 3, 3)

            };

            Button comment = new Button()
            {
                Width = 50,
                Height = 50,
                BackColor = Color.Brown,
                Margin = new Padding(100, 0, 3, 3)
            };

            FlowLayoutPanel postPanel = new FlowLayoutPanel()
            {
                Width = panel.Width - 30,
                BorderStyle = BorderStyle.FixedSingle,
                Height = dynamicHeight + 115,
                Name = $"Post{i}"
            };




            FlowLayoutPanel avatarPanel = new FlowLayoutPanel()
            {
                Width = 80,
                Height = 80,
                BorderStyle = BorderStyle.None,
            };


            FlowLayoutPanel labelPanel = new FlowLayoutPanel()
            {
                Width = postPanel.Width - 100,
                Height = postPanel.Height,
                BorderStyle = BorderStyle.None,
            };

            FlowLayoutPanel textPanel = new FlowLayoutPanel()
            {
                BorderStyle = BorderStyle.None,
                Width = labelPanel.Width,
                Height = dynamicHeight + 60,
            };

            FlowLayoutPanel buttonPanel = new FlowLayoutPanel()
            {
                Width = textPanel.Width,
                Height = 55,
                BorderStyle = BorderStyle.None
                
            };

            Label lblName = new Label();
            lblName.Text = post.Name;
            lblName.AutoSize = true;
            lblName.Margin = new Padding(0, 1, 0, 0);
            lblName.Font = new Font("Arial", 15, FontStyle.Bold);

            Label lblUsername = new Label();
            lblUsername.Text = "@"+post.Username;
            lblUsername.AutoSize = true;
            lblUsername.Margin = new Padding(0, 1, 0, 0);
            lblUsername.Font = new Font("Arial", 15, FontStyle.Regular);
            lblUsername.ForeColor = Color.Gray;

            Label lblTime = new Label();
            lblTime.Text = post.created_at;
            lblTime.AutoSize = true;
            lblTime.Margin = new Padding(200, 30, 0, 0);
            lblTime.Font = new Font("Arial", 10, FontStyle.Regular);
            lblTime.ForeColor = Color.Gray;

            // RichTextBox'ı panelin içine ekle
            panel.Controls.Add(postPanel);
            postPanel.Controls.Add(avatarPanel);
            postPanel.Controls.Add(labelPanel);
            labelPanel.Controls.Add(lblName);
            labelPanel.Controls.Add(lblUsername);
            labelPanel.Controls.Add(textPanel);
            avatarPanel.Controls.Add(avatar);
            textPanel.Controls.Add(postText);
            textPanel.Controls.Add(buttonPanel);
            buttonPanel.Controls.Add(like);
            buttonPanel.Controls.Add(comment);
            buttonPanel.Controls.Add(lblTime);


        }
        private int DynamicHeight(RichTextBox richTextBox)
        {
            int lineHeight = richTextBox.Font.Height;
            int lineCount = richTextBox.GetLineFromCharIndex(richTextBox.Text.Length - 1) + 1;
            return (lineCount * lineHeight) + 10; // Satır sayısı * satır yüksekliği + biraz boşluk
        }
    }

    


}
