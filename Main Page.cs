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
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public Main_Page()
        {
            InitializeComponent();
            this.FormClosing += Main_Page_FormClosing;
            post_manager = new post_manager();
            post_structure = new post_structure();



        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
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

        }
    }
}
