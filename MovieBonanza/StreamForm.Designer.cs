namespace MovieBonanza
{
    partial class StreamForm
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
            this.StreamFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileStreamFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.BackStreamFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStreamFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutStreamFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUsStreamFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.StreamGroupBox = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackButton = new System.Windows.Forms.Button();
            this.SelectionButton = new System.Windows.Forms.Button();
            this.SelectionStreamFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.StreamFormMenuStrip.SuspendLayout();
            this.StreamGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StreamFormMenuStrip
            // 
            this.StreamFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStreamFormMenuStrip,
            this.AboutStreamFormMenuStrip});
            this.StreamFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.StreamFormMenuStrip.Name = "StreamFormMenuStrip";
            this.StreamFormMenuStrip.Size = new System.Drawing.Size(982, 24);
            this.StreamFormMenuStrip.TabIndex = 7;
            this.StreamFormMenuStrip.Text = "menuStrip1";
            // 
            // FileStreamFormMenuStrip
            // 
            this.FileStreamFormMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackStreamFormMenuStrip,
            this.SelectionStreamFormMenuStrip,
            this.ExitStreamFormMenuStrip});
            this.FileStreamFormMenuStrip.Name = "FileStreamFormMenuStrip";
            this.FileStreamFormMenuStrip.Size = new System.Drawing.Size(37, 20);
            this.FileStreamFormMenuStrip.Text = "File";
            // 
            // BackStreamFormMenuStrip
            // 
            this.BackStreamFormMenuStrip.Name = "BackStreamFormMenuStrip";
            this.BackStreamFormMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BackStreamFormMenuStrip.Size = new System.Drawing.Size(153, 22);
            this.BackStreamFormMenuStrip.Text = "Back";
            // 
            // ExitStreamFormMenuStrip
            // 
            this.ExitStreamFormMenuStrip.Name = "ExitStreamFormMenuStrip";
            this.ExitStreamFormMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExitStreamFormMenuStrip.Size = new System.Drawing.Size(153, 22);
            this.ExitStreamFormMenuStrip.Text = "Exit";
            this.ExitStreamFormMenuStrip.Click += new System.EventHandler(this.ExitStreamFormMenuStrip_Click);
            // 
            // AboutStreamFormMenuStrip
            // 
            this.AboutStreamFormMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUsStreamFormMenuStrip});
            this.AboutStreamFormMenuStrip.Name = "AboutStreamFormMenuStrip";
            this.AboutStreamFormMenuStrip.Size = new System.Drawing.Size(52, 20);
            this.AboutStreamFormMenuStrip.Text = "About";
            // 
            // AboutUsStreamFormMenuStrip
            // 
            this.AboutUsStreamFormMenuStrip.Name = "AboutUsStreamFormMenuStrip";
            this.AboutUsStreamFormMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AboutUsStreamFormMenuStrip.Size = new System.Drawing.Size(165, 22);
            this.AboutUsStreamFormMenuStrip.Text = "About Us";
            // 
            // StreamGroupBox
            // 
            this.StreamGroupBox.Controls.Add(this.webBrowser1);
            this.StreamGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamGroupBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.StreamGroupBox.Location = new System.Drawing.Point(27, 54);
            this.StreamGroupBox.Name = "StreamGroupBox";
            this.StreamGroupBox.Size = new System.Drawing.Size(739, 405);
            this.StreamGroupBox.TabIndex = 8;
            this.StreamGroupBox.TabStop = false;
            this.StreamGroupBox.Text = "Streaming";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(733, 380);
            this.webBrowser1.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::MovieBonanza.Properties.Resources.BlankButton;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(805, 392);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(154, 67);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackButton_MouseDown);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            this.BackButton.MouseHover += new System.EventHandler(this.BackButton_MouseHover);
            this.BackButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackButton_MouseUp);
            // 
            // SelectionButton
            // 
            this.SelectionButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectionButton.BackgroundImage = global::MovieBonanza.Properties.Resources.button_blank_gray_01;
            this.SelectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectionButton.FlatAppearance.BorderSize = 0;
            this.SelectionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SelectionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionButton.ForeColor = System.Drawing.Color.DarkRed;
            this.SelectionButton.Location = new System.Drawing.Point(807, 147);
            this.SelectionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(152, 142);
            this.SelectionButton.TabIndex = 10;
            this.SelectionButton.Text = "Selection";
            this.SelectionButton.UseVisualStyleBackColor = false;
            this.SelectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            this.SelectionButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectionButton_MouseDown);
            this.SelectionButton.MouseLeave += new System.EventHandler(this.SelectionButton_MouseLeave);
            this.SelectionButton.MouseHover += new System.EventHandler(this.SelectionButton_MouseHover);
            this.SelectionButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectionButton_MouseUp);
            // 
            // SelectionStreamFormMenuStrip
            // 
            this.SelectionStreamFormMenuStrip.Name = "SelectionStreamFormMenuStrip";
            this.SelectionStreamFormMenuStrip.Size = new System.Drawing.Size(153, 22);
            this.SelectionStreamFormMenuStrip.Text = "Selection Form";
            this.SelectionStreamFormMenuStrip.Click += new System.EventHandler(this.SelectionStreamFormMenuStrip_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MovieBonanza.Properties.Resources.video_revs_png11;
            this.ClientSize = new System.Drawing.Size(982, 510);
            this.Controls.Add(this.SelectionButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StreamGroupBox);
            this.Controls.Add(this.StreamFormMenuStrip);
            this.Name = "StreamForm";
            this.Text = "StreamForm";
            this.StreamFormMenuStrip.ResumeLayout(false);
            this.StreamFormMenuStrip.PerformLayout();
            this.StreamGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StreamFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileStreamFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem BackStreamFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStreamFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutStreamFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutUsStreamFormMenuStrip;
        private System.Windows.Forms.GroupBox StreamGroupBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SelectionButton;
        private System.Windows.Forms.ToolStripMenuItem SelectionStreamFormMenuStrip;
    }
}