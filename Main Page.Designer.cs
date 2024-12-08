namespace social_media
{
    partial class Main_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new FlowLayoutPanel();
            userAvatar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            numFollowers = new Label();
            followers = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            numFollowing = new Label();
            following = new Label();
            createPostButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userAvatar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top;
            mainPanel.AutoScroll = true;
            mainPanel.Location = new Point(546, 42);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(828, 923);
            mainPanel.TabIndex = 0;
            // 
            // userAvatar
            // 
            userAvatar.BackColor = Color.Blue;
            userAvatar.Cursor = Cursors.Hand;
            userAvatar.Location = new Point(102, 50);
            userAvatar.Name = "userAvatar";
            userAvatar.Size = new Size(160, 160);
            userAvatar.TabIndex = 1;
            userAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(102, 213);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 2;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(102, 243);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 3;
            label2.Text = "@username";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(numFollowers);
            flowLayoutPanel1.Controls.Add(followers);
            flowLayoutPanel1.Location = new Point(102, 296);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(438, 34);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // numFollowers
            // 
            numFollowers.AutoSize = true;
            numFollowers.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numFollowers.Location = new Point(0, 0);
            numFollowers.Margin = new Padding(0);
            numFollowers.Name = "numFollowers";
            numFollowers.Size = new Size(55, 30);
            numFollowers.TabIndex = 5;
            numFollowers.Text = "100";
            // 
            // followers
            // 
            followers.Cursor = Cursors.Hand;
            followers.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            followers.Location = new Point(55, 0);
            followers.Margin = new Padding(0);
            followers.Name = "followers";
            followers.Size = new Size(114, 30);
            followers.TabIndex = 6;
            followers.Text = "followers";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(numFollowing);
            flowLayoutPanel2.Controls.Add(following);
            flowLayoutPanel2.Location = new Point(102, 336);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(438, 34);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // numFollowing
            // 
            numFollowing.AutoSize = true;
            numFollowing.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numFollowing.Location = new Point(0, 0);
            numFollowing.Margin = new Padding(0);
            numFollowing.Name = "numFollowing";
            numFollowing.Size = new Size(69, 30);
            numFollowing.TabIndex = 5;
            numFollowing.Text = "2550";
            // 
            // following
            // 
            following.Cursor = Cursors.Hand;
            following.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            following.Location = new Point(72, 0);
            following.Name = "following";
            following.Size = new Size(114, 30);
            following.TabIndex = 6;
            following.Text = "following";
            // 
            // createPostButton
            // 
            createPostButton.Location = new Point(1429, 728);
            createPostButton.Name = "createPostButton";
            createPostButton.Size = new Size(103, 96);
            createPostButton.TabIndex = 9;
            createPostButton.UseVisualStyleBackColor = true;
            createPostButton.Click += createPostButton_Click;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1902, 1033);
            Controls.Add(createPostButton);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userAvatar);
            Controls.Add(mainPanel);
            Name = "Main_Page";
            Text = "Main_Page";
            WindowState = FormWindowState.Maximized;
            Load += Main_Page_Load;
            ((System.ComponentModel.ISupportInitialize)userAvatar).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel mainPanel;
        private PictureBox userAvatar;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label numFollowers;
        private Label followers;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label numFollowing;
        private Label following;
        private Button createPostButton;
    }
}