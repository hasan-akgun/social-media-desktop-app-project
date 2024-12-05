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
            panel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top;
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(546, 12);
            panel.Name = "panel";
            panel.Size = new Size(828, 1009);
            panel.TabIndex = 0;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel);
            Name = "Main_Page";
            Text = "Main_Page";
            WindowState = FormWindowState.Maximized;
            Load += Main_Page_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel;
    }
}