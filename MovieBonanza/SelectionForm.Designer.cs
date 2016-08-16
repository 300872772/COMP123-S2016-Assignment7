namespace MovieBonanza
{
    partial class SelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.SelectFormMainLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MovieSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CatagoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectionFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.NextSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUsSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MovieSelectListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MovieSelectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SelectionFormMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFormMainLabel
            // 
            this.SelectFormMainLabel.AutoSize = true;
            this.SelectFormMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectFormMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFormMainLabel.ForeColor = System.Drawing.Color.Cyan;
            this.SelectFormMainLabel.Location = new System.Drawing.Point(90, 37);
            this.SelectFormMainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectFormMainLabel.Name = "SelectFormMainLabel";
            this.SelectFormMainLabel.Size = new System.Drawing.Size(556, 24);
            this.SelectFormMainLabel.TabIndex = 8;
            this.SelectFormMainLabel.Text = "Choose the movie you wish to STREAM from the list below";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MovieBonanza.Properties.Resources.icons_circle_MOVIElink;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(26, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 53);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // MovieSelectGroupBox
            // 
            this.MovieSelectGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.MovieSelectGroupBox.BackgroundImage = global::MovieBonanza.Properties.Resources.skin1;
            this.MovieSelectGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MovieSelectGroupBox.Controls.Add(this.CostLabel);
            this.MovieSelectGroupBox.Controls.Add(this.CatagoryLabel);
            this.MovieSelectGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectGroupBox.Controls.Add(this.CostTextBox);
            this.MovieSelectGroupBox.Controls.Add(this.CategoryTextBox);
            this.MovieSelectGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieSelectGroupBox.Controls.Add(this.MoviePictureBox);
            this.MovieSelectGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieSelectGroupBox.ForeColor = System.Drawing.Color.Yellow;
            this.MovieSelectGroupBox.Location = new System.Drawing.Point(332, 98);
            this.MovieSelectGroupBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MovieSelectGroupBox.Name = "MovieSelectGroupBox";
            this.MovieSelectGroupBox.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MovieSelectGroupBox.Size = new System.Drawing.Size(647, 275);
            this.MovieSelectGroupBox.TabIndex = 10;
            this.MovieSelectGroupBox.TabStop = false;
            this.MovieSelectGroupBox.Text = "Your Selection";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.ForeColor = System.Drawing.Color.Cyan;
            this.CostLabel.Location = new System.Drawing.Point(495, 163);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(42, 20);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost";
            // 
            // CatagoryLabel
            // 
            this.CatagoryLabel.AutoSize = true;
            this.CatagoryLabel.ForeColor = System.Drawing.Color.Cyan;
            this.CatagoryLabel.Location = new System.Drawing.Point(241, 163);
            this.CatagoryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CatagoryLabel.Name = "CatagoryLabel";
            this.CatagoryLabel.Size = new System.Drawing.Size(73, 20);
            this.CatagoryLabel.TabIndex = 5;
            this.CatagoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.Cyan;
            this.TitleLabel.Location = new System.Drawing.Point(243, 53);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.White;
            this.CostTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.CostTextBox.Location = new System.Drawing.Point(501, 201);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(121, 26);
            this.CostTextBox.TabIndex = 3;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BackColor = System.Drawing.Color.White;
            this.CategoryTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.CategoryTextBox.Location = new System.Drawing.Point(247, 201);
            this.CategoryTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(224, 26);
            this.CategoryTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.Color.White;
            this.TitleTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.TitleTextBox.Location = new System.Drawing.Point(249, 92);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(375, 26);
            this.TitleTextBox.TabIndex = 1;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BackColor = System.Drawing.Color.White;
            this.MoviePictureBox.BackgroundImage = global::MovieBonanza.Properties.Resources.waitingforever;
            this.MoviePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoviePictureBox.Location = new System.Drawing.Point(31, 56);
            this.MoviePictureBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(176, 171);
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.BackgroundImage = global::MovieBonanza.Properties.Resources.BlankButton;
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(577, 404);
            this.NextButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(173, 79);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NextButton_MouseDown);
            this.NextButton.MouseLeave += new System.EventHandler(this.NextButton_MouseLeave);
            this.NextButton.MouseHover += new System.EventHandler(this.NextButton_MouseHover);
            this.NextButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NextButton_MouseUp);
            // 
            // SelectionFormMenuStrip
            // 
            this.SelectionFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSelectionFormMenuStrip,
            this.HelpSelectionFormMenuStrip});
            this.SelectionFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SelectionFormMenuStrip.Name = "SelectionFormMenuStrip";
            this.SelectionFormMenuStrip.Size = new System.Drawing.Size(994, 24);
            this.SelectionFormMenuStrip.TabIndex = 12;
            this.SelectionFormMenuStrip.Text = "menuStrip1";
            // 
            // FileSelectionFormMenuStrip
            // 
            this.FileSelectionFormMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NextSelectionFormMenuStrip,
            this.ExitSelectionFormMenuStrip});
            this.FileSelectionFormMenuStrip.Name = "FileSelectionFormMenuStrip";
            this.FileSelectionFormMenuStrip.Size = new System.Drawing.Size(37, 20);
            this.FileSelectionFormMenuStrip.Text = "File";
            // 
            // NextSelectionFormMenuStrip
            // 
            this.NextSelectionFormMenuStrip.Name = "NextSelectionFormMenuStrip";
            this.NextSelectionFormMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NextSelectionFormMenuStrip.Size = new System.Drawing.Size(141, 22);
            this.NextSelectionFormMenuStrip.Text = "Next";
            this.NextSelectionFormMenuStrip.Click += new System.EventHandler(this.NextSelectionFormMenuStrip_Click);
            // 
            // ExitSelectionFormMenuStrip
            // 
            this.ExitSelectionFormMenuStrip.Name = "ExitSelectionFormMenuStrip";
            this.ExitSelectionFormMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExitSelectionFormMenuStrip.Size = new System.Drawing.Size(141, 22);
            this.ExitSelectionFormMenuStrip.Text = "Exit";
            this.ExitSelectionFormMenuStrip.Click += new System.EventHandler(this.ExitSelectionFormMenuStrip_Click);
            // 
            // HelpSelectionFormMenuStrip
            // 
            this.HelpSelectionFormMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUsSelectionFormMenuStrip});
            this.HelpSelectionFormMenuStrip.Name = "HelpSelectionFormMenuStrip";
            this.HelpSelectionFormMenuStrip.Size = new System.Drawing.Size(44, 20);
            this.HelpSelectionFormMenuStrip.Text = "Help";
            // 
            // AboutUsSelectionFormMenuStrip
            // 
            this.AboutUsSelectionFormMenuStrip.Name = "AboutUsSelectionFormMenuStrip";
            this.AboutUsSelectionFormMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AboutUsSelectionFormMenuStrip.Size = new System.Drawing.Size(165, 22);
            this.AboutUsSelectionFormMenuStrip.Text = "About Us";
            this.AboutUsSelectionFormMenuStrip.Click += new System.EventHandler(this.AboutUsSelectionFormMenuStrip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::MovieBonanza.Properties.Resources.skin2;
            this.groupBox1.Controls.Add(this.MovieSelectListBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(33, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 399);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Movies";
            // 
            // MovieSelectListBox
            // 
            this.MovieSelectListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MovieSelectListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovieSelectListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MovieSelectListBox.FormattingEnabled = true;
            this.MovieSelectListBox.ItemHeight = 20;
            this.MovieSelectListBox.Location = new System.Drawing.Point(22, 30);
            this.MovieSelectListBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MovieSelectListBox.Name = "MovieSelectListBox";
            this.MovieSelectListBox.Size = new System.Drawing.Size(208, 342);
            this.MovieSelectListBox.Sorted = true;
            this.MovieSelectListBox.TabIndex = 7;
            this.MovieSelectListBox.SelectedIndexChanged += new System.EventHandler(this.MovieSelectListBox_SelectedIndexChanged);
            this.MovieSelectListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MovieSelectListBox_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MovieBonanza.Properties.Resources.skin3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(332, 404);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 79);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MovieBonanza.Properties.Resources.movie_noPlay_blank;
            this.ClientSize = new System.Drawing.Size(994, 510);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectionFormMenuStrip);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MovieSelectGroupBox);
            this.Controls.Add(this.SelectFormMainLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza - Your Online Streaming Service";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MovieSelectGroupBox.ResumeLayout(false);
            this.MovieSelectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.SelectionFormMenuStrip.ResumeLayout(false);
            this.SelectionFormMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectFormMainLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox MovieSelectGroupBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CatagoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.MenuStrip SelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileSelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NextSelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitSelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpSelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutUsSelectionFormMenuStrip;
        public System.Windows.Forms.TextBox CostTextBox;
        public System.Windows.Forms.TextBox CategoryTextBox;
        public System.Windows.Forms.TextBox TitleTextBox;
        public System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox MovieSelectListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

