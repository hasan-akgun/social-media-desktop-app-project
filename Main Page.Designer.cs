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
            lblUsername = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            numFollowers = new Label();
            followers = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            numFollowing = new Label();
            following = new Label();
            createPostButton = new Button();
            createPanel = new TableLayoutPanel();
            btnClear = new Button();
            btnSend = new Button();
            button1 = new Button();
            rtxbSendingPost = new RichTextBox();
            numChar = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnHeart = new Button();
            btnSmile = new Button();
            btnLaugh = new Button();
            btnShocked = new Button();
            btnSad = new Button();
            btnCry = new Button();
            btnThankfull = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)userAvatar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            createPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Location = new Point(553, 42);
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
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUsername.ForeColor = Color.Gray;
            lblUsername.Location = new Point(102, 243);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(150, 28);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "@username";
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
            // createPanel
            // 
            createPanel.BackColor = Color.CornflowerBlue;
            createPanel.ColumnCount = 4;
            createPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            createPanel.ColumnStyles.Add(new ColumnStyle());
            createPanel.ColumnStyles.Add(new ColumnStyle());
            createPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            createPanel.Controls.Add(btnClear, 0, 1);
            createPanel.Controls.Add(btnSend, 3, 1);
            createPanel.Controls.Add(button1, 3, 0);
            createPanel.Controls.Add(rtxbSendingPost, 2, 1);
            createPanel.Controls.Add(numChar, 3, 2);
            createPanel.Controls.Add(flowLayoutPanel3, 2, 2);
            createPanel.Location = new Point(554, 260);
            createPanel.Name = "createPanel";
            createPanel.RowCount = 3;
            createPanel.RowStyles.Add(new RowStyle());
            createPanel.RowStyles.Add(new RowStyle());
            createPanel.RowStyles.Add(new RowStyle());
            createPanel.Size = new Size(811, 407);
            createPanel.TabIndex = 10;
            createPanel.Visible = false;
            createPanel.Paint += createPanel_Paint;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left;
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(10, 155);
            btnClear.Margin = new Padding(10, 0, 0, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 60);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Left;
            btnSend.BackColor = Color.White;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Location = new Point(736, 155);
            btnSend.Margin = new Padding(0);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(60, 60);
            btnSend.TabIndex = 4;
            btnSend.Text = "send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(766, 3);
            button1.Margin = new Padding(30, 3, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(32, 34);
            button1.TabIndex = 1;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rtxbSendingPost
            // 
            rtxbSendingPost.AutoWordSelection = true;
            rtxbSendingPost.BorderStyle = BorderStyle.None;
            rtxbSendingPost.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxbSendingPost.Location = new Point(78, 43);
            rtxbSendingPost.MaxLength = 300;
            rtxbSendingPost.Name = "rtxbSendingPost";
            rtxbSendingPost.Size = new Size(650, 285);
            rtxbSendingPost.TabIndex = 0;
            rtxbSendingPost.Text = "";
            rtxbSendingPost.TextChanged += rtxbSendingPost_TextChanged;
            // 
            // numChar
            // 
            numChar.AutoSize = true;
            numChar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numChar.Location = new Point(739, 331);
            numChar.Name = "numChar";
            numChar.Size = new Size(43, 24);
            numChar.TabIndex = 9;
            numChar.Text = "300";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btnHeart);
            flowLayoutPanel3.Controls.Add(btnSmile);
            flowLayoutPanel3.Controls.Add(btnLaugh);
            flowLayoutPanel3.Controls.Add(btnShocked);
            flowLayoutPanel3.Controls.Add(btnSad);
            flowLayoutPanel3.Controls.Add(btnCry);
            flowLayoutPanel3.Controls.Add(btnThankfull);
            flowLayoutPanel3.Location = new Point(78, 334);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(655, 73);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // btnHeart
            // 
            btnHeart.Anchor = AnchorStyles.Left;
            btnHeart.AutoSize = true;
            btnHeart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHeart.BackColor = Color.White;
            btnHeart.FlatStyle = FlatStyle.Flat;
            btnHeart.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHeart.Location = new Point(0, 0);
            btnHeart.Margin = new Padding(0);
            btnHeart.Name = "btnHeart";
            btnHeart.Size = new Size(87, 63);
            btnHeart.TabIndex = 12;
            btnHeart.Text = "❤";
            btnHeart.UseVisualStyleBackColor = false;
            // 
            // btnSmile
            // 
            btnSmile.Anchor = AnchorStyles.Left;
            btnSmile.AutoSize = true;
            btnSmile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSmile.BackColor = Color.White;
            btnSmile.FlatStyle = FlatStyle.Flat;
            btnSmile.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSmile.Location = new Point(94, 0);
            btnSmile.Margin = new Padding(7, 0, 0, 0);
            btnSmile.Name = "btnSmile";
            btnSmile.Size = new Size(87, 63);
            btnSmile.TabIndex = 13;
            btnSmile.Text = "😃";
            btnSmile.UseVisualStyleBackColor = false;
            // 
            // btnLaugh
            // 
            btnLaugh.Anchor = AnchorStyles.Left;
            btnLaugh.AutoSize = true;
            btnLaugh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLaugh.BackColor = Color.White;
            btnLaugh.FlatStyle = FlatStyle.Flat;
            btnLaugh.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLaugh.Location = new Point(188, 0);
            btnLaugh.Margin = new Padding(7, 0, 0, 0);
            btnLaugh.Name = "btnLaugh";
            btnLaugh.Size = new Size(87, 63);
            btnLaugh.TabIndex = 14;
            btnLaugh.Text = "😂";
            btnLaugh.UseVisualStyleBackColor = false;
            // 
            // btnShocked
            // 
            btnShocked.Anchor = AnchorStyles.Left;
            btnShocked.AutoSize = true;
            btnShocked.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShocked.BackColor = Color.White;
            btnShocked.FlatStyle = FlatStyle.Flat;
            btnShocked.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnShocked.Location = new Point(282, 0);
            btnShocked.Margin = new Padding(7, 0, 0, 0);
            btnShocked.Name = "btnShocked";
            btnShocked.Size = new Size(87, 63);
            btnShocked.TabIndex = 15;
            btnShocked.Text = "😨";
            btnShocked.UseVisualStyleBackColor = false;
            // 
            // btnSad
            // 
            btnSad.Anchor = AnchorStyles.Left;
            btnSad.AutoSize = true;
            btnSad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSad.BackColor = Color.White;
            btnSad.FlatStyle = FlatStyle.Flat;
            btnSad.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSad.Location = new Point(376, 0);
            btnSad.Margin = new Padding(7, 0, 0, 0);
            btnSad.Name = "btnSad";
            btnSad.Size = new Size(87, 63);
            btnSad.TabIndex = 16;
            btnSad.Text = "😢";
            btnSad.UseVisualStyleBackColor = false;
            // 
            // btnCry
            // 
            btnCry.Anchor = AnchorStyles.Left;
            btnCry.AutoSize = true;
            btnCry.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCry.BackColor = Color.White;
            btnCry.FlatStyle = FlatStyle.Flat;
            btnCry.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCry.Location = new Point(470, 0);
            btnCry.Margin = new Padding(7, 0, 0, 0);
            btnCry.Name = "btnCry";
            btnCry.Size = new Size(87, 63);
            btnCry.TabIndex = 17;
            btnCry.Text = "😭";
            btnCry.UseVisualStyleBackColor = false;
            // 
            // btnThankfull
            // 
            btnThankfull.Anchor = AnchorStyles.Left;
            btnThankfull.AutoSize = true;
            btnThankfull.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnThankfull.BackColor = Color.White;
            btnThankfull.FlatStyle = FlatStyle.Flat;
            btnThankfull.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnThankfull.Location = new Point(564, 0);
            btnThankfull.Margin = new Padding(7, 0, 0, 0);
            btnThankfull.Name = "btnThankfull";
            btnThankfull.Size = new Size(87, 63);
            btnThankfull.TabIndex = 18;
            btnThankfull.Text = "🙏";
            btnThankfull.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Left;
            btnReset.BackColor = Color.White;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(480, 42);
            btnReset.Margin = new Padding(10, 0, 0, 0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(60, 60);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnReset);
            Controls.Add(createPanel);
            Controls.Add(createPostButton);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblUsername);
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
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel mainPanel;
        private PictureBox userAvatar;
        private Label label1;
        private Label lblUsername;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label numFollowers;
        private Label followers;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label numFollowing;
        private Label following;
        private Button createPostButton;
        private TableLayoutPanel createPanel;
        private Button button1;
        private RichTextBox rtxbSendingPost;
        private Button btnSend;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label numChar;
        private Button btnClear;
        private Button btnHeart;
        private Button btnSmile;
        private Button btnLaugh;
        private Button btnShocked;
        private Button btnSad;
        private Button btnCry;
        private Button btnThankfull;
        private Button btnReset;
    }
}