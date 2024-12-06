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
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1902, 1033);
            Controls.Add(mainPanel);
            Name = "Main_Page";
            Text = "Main_Page";
            WindowState = FormWindowState.Maximized;
            Load += Main_Page_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel mainPanel;
    }
}