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
            this.CurrentMovieLabel = new System.Windows.Forms.Label();
            this.MovieSelectListBox = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MovieSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CatagoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectionFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.NextSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUsSelectionFormMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MovieSelectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SelectionFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFormMainLabel
            // 
            this.SelectFormMainLabel.AutoSize = true;
            this.SelectFormMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectFormMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFormMainLabel.ForeColor = System.Drawing.Color.Aqua;
            this.SelectFormMainLabel.Location = new System.Drawing.Point(102, 43);
            this.SelectFormMainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectFormMainLabel.Name = "SelectFormMainLabel";
            this.SelectFormMainLabel.Size = new System.Drawing.Size(556, 24);
            this.SelectFormMainLabel.TabIndex = 8;
            this.SelectFormMainLabel.Text = "Choose the movie you wish to STREAM from the list below";
            // 
            // CurrentMovieLabel
            // 
            this.CurrentMovieLabel.AutoSize = true;
            this.CurrentMovieLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentMovieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CurrentMovieLabel.Location = new System.Drawing.Point(15, 110);
            this.CurrentMovieLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CurrentMovieLabel.Name = "CurrentMovieLabel";
            this.CurrentMovieLabel.Size = new System.Drawing.Size(115, 20);
            this.CurrentMovieLabel.TabIndex = 7;
            this.CurrentMovieLabel.Text = "Current Movies";
            // 
            // MovieSelectListBox
            // 
            this.MovieSelectListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MovieSelectListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovieSelectListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MovieSelectListBox.FormattingEnabled = true;
            this.MovieSelectListBox.ItemHeight = 20;
            this.MovieSelectListBox.Location = new System.Drawing.Point(20, 138);
            this.MovieSelectListBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MovieSelectListBox.Name = "MovieSelectListBox";
            this.MovieSelectListBox.Size = new System.Drawing.Size(272, 362);
            this.MovieSelectListBox.Sorted = true;
            this.MovieSelectListBox.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MovieBonanza.Properties.Resources.icons_circle_MOVIElink;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 80);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // MovieSelectGroupBox
            // 
            this.MovieSelectGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MovieSelectGroupBox.Controls.Add(this.CostLabel);
            this.MovieSelectGroupBox.Controls.Add(this.CatagoryLabel);
            this.MovieSelectGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectGroupBox.Controls.Add(this.textBox3);
            this.MovieSelectGroupBox.Controls.Add(this.textBox2);
            this.MovieSelectGroupBox.Controls.Add(this.textBox1);
            this.MovieSelectGroupBox.Controls.Add(this.pictureBox1);
            this.MovieSelectGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MovieSelectGroupBox.Location = new System.Drawing.Point(314, 138);
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
            this.CostLabel.Location = new System.Drawing.Point(502, 186);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(42, 20);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost";
            // 
            // CatagoryLabel
            // 
            this.CatagoryLabel.AutoSize = true;
            this.CatagoryLabel.Location = new System.Drawing.Point(248, 186);
            this.CatagoryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CatagoryLabel.Name = "CatagoryLabel";
            this.CatagoryLabel.Size = new System.Drawing.Size(73, 20);
            this.CatagoryLabel.TabIndex = 5;
            this.CatagoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(248, 32);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(508, 224);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(254, 224);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(224, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(254, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(375, 26);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 222);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.NextButton.Location = new System.Drawing.Point(788, 429);
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
            this.AboutSelectionFormMenuStrip});
            this.SelectionFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SelectionFormMenuStrip.Name = "SelectionFormMenuStrip";
            this.SelectionFormMenuStrip.Size = new System.Drawing.Size(982, 24);
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
            this.NextSelectionFormMenuStrip.Size = new System.Drawing.Size(152, 22);
            this.NextSelectionFormMenuStrip.Text = "Next";
            // 
            // ExitSelectionFormMenuStrip
            // 
            this.ExitSelectionFormMenuStrip.Name = "ExitSelectionFormMenuStrip";
            this.ExitSelectionFormMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExitSelectionFormMenuStrip.Size = new System.Drawing.Size(152, 22);
            this.ExitSelectionFormMenuStrip.Text = "Exit";
            this.ExitSelectionFormMenuStrip.Click += new System.EventHandler(this.ExitSelectionFormMenuStrip_Click);
            // 
            // AboutSelectionFormMenuStrip
            // 
            this.AboutSelectionFormMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUsSelectionFormMenuStrip});
            this.AboutSelectionFormMenuStrip.Name = "AboutSelectionFormMenuStrip";
            this.AboutSelectionFormMenuStrip.Size = new System.Drawing.Size(52, 20);
            this.AboutSelectionFormMenuStrip.Text = "About";
            // 
            // AboutUsSelectionFormMenuStrip
            // 
            this.AboutUsSelectionFormMenuStrip.Name = "AboutUsSelectionFormMenuStrip";
            this.AboutUsSelectionFormMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AboutUsSelectionFormMenuStrip.Size = new System.Drawing.Size(165, 22);
            this.AboutUsSelectionFormMenuStrip.Text = "About Us";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MovieBonanza.Properties.Resources.movie_noPlay_blank;
            this.ClientSize = new System.Drawing.Size(982, 510);
            this.Controls.Add(this.SelectionFormMenuStrip);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MovieSelectGroupBox);
            this.Controls.Add(this.SelectFormMainLabel);
            this.Controls.Add(this.CurrentMovieLabel);
            this.Controls.Add(this.MovieSelectListBox);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectionForm";
            this.Text = "Movie Bonanza - Your Online Streaming Service";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MovieSelectGroupBox.ResumeLayout(false);
            this.MovieSelectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SelectionFormMenuStrip.ResumeLayout(false);
            this.SelectionFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectFormMainLabel;
        private System.Windows.Forms.Label CurrentMovieLabel;
        private System.Windows.Forms.ListBox MovieSelectListBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox MovieSelectGroupBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CatagoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.MenuStrip SelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileSelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NextSelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitSelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutSelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutUsSelectionFormMenuStrip;
    }
}

