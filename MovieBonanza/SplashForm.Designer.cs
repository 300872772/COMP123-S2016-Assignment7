namespace MovieBonanza
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.SplashPictureBox2 = new System.Windows.Forms.PictureBox();
            this.SplashPictureBox1 = new System.Windows.Forms.PictureBox();
            this.SplashProgressBar = new System.Windows.Forms.ProgressBar();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.MovieBonanzaLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashPictureBox2
            // 
            this.SplashPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.SplashPictureBox2.BackgroundImage = global::MovieBonanza.Properties.Resources.movie_icon_29;
            this.SplashPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SplashPictureBox2.Location = new System.Drawing.Point(12, 72);
            this.SplashPictureBox2.Name = "SplashPictureBox2";
            this.SplashPictureBox2.Size = new System.Drawing.Size(206, 199);
            this.SplashPictureBox2.TabIndex = 0;
            this.SplashPictureBox2.TabStop = false;
            // 
            // SplashPictureBox1
            // 
            this.SplashPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.SplashPictureBox1.BackgroundImage = global::MovieBonanza.Properties.Resources.Video_Production_Icon;
            this.SplashPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SplashPictureBox1.Location = new System.Drawing.Point(533, 92);
            this.SplashPictureBox1.Name = "SplashPictureBox1";
            this.SplashPictureBox1.Size = new System.Drawing.Size(179, 179);
            this.SplashPictureBox1.TabIndex = 1;
            this.SplashPictureBox1.TabStop = false;
            // 
            // SplashProgressBar
            // 
            this.SplashProgressBar.Location = new System.Drawing.Point(238, 248);
            this.SplashProgressBar.Maximum = 3000;
            this.SplashProgressBar.Name = "SplashProgressBar";
            this.SplashProgressBar.Size = new System.Drawing.Size(260, 23);
            this.SplashProgressBar.Step = 100;
            this.SplashProgressBar.TabIndex = 2;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Enabled = true;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // MovieBonanzaLabel
            // 
            this.MovieBonanzaLabel.AutoSize = true;
            this.MovieBonanzaLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieBonanzaLabel.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieBonanzaLabel.ForeColor = System.Drawing.Color.LightGray;
            this.MovieBonanzaLabel.Location = new System.Drawing.Point(199, 9);
            this.MovieBonanzaLabel.Name = "MovieBonanzaLabel";
            this.MovieBonanzaLabel.Size = new System.Drawing.Size(307, 44);
            this.MovieBonanzaLabel.TabIndex = 3;
            this.MovieBonanzaLabel.Text = "MOVIE BONANZA";
            // 
            // LogoPictureBox1
            // 
            this.LogoPictureBox1.BackgroundImage = global::MovieBonanza.Properties.Resources.favico;
            this.LogoPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPictureBox1.Location = new System.Drawing.Point(155, 9);
            this.LogoPictureBox1.Name = "LogoPictureBox1";
            this.LogoPictureBox1.Size = new System.Drawing.Size(48, 44);
            this.LogoPictureBox1.TabIndex = 4;
            this.LogoPictureBox1.TabStop = false;
            // 
            // LogoPictureBox2
            // 
            this.LogoPictureBox2.BackgroundImage = global::MovieBonanza.Properties.Resources.favico;
            this.LogoPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPictureBox2.Location = new System.Drawing.Point(501, 12);
            this.LogoPictureBox2.Name = "LogoPictureBox2";
            this.LogoPictureBox2.Size = new System.Drawing.Size(48, 44);
            this.LogoPictureBox2.TabIndex = 5;
            this.LogoPictureBox2.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::MovieBonanza.Properties.Resources.screens;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 283);
            this.ControlBox = false;
            this.Controls.Add(this.LogoPictureBox2);
            this.Controls.Add(this.LogoPictureBox1);
            this.Controls.Add(this.MovieBonanzaLabel);
            this.Controls.Add(this.SplashProgressBar);
            this.Controls.Add(this.SplashPictureBox1);
            this.Controls.Add(this.SplashPictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashPictureBox2;
        private System.Windows.Forms.PictureBox SplashPictureBox1;
        private System.Windows.Forms.ProgressBar SplashProgressBar;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label MovieBonanzaLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox1;
        private System.Windows.Forms.PictureBox LogoPictureBox2;
    }
}