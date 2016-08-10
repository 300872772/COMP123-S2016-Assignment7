using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashProgressBar.PerformStep();
            if (SplashProgressBar.Value >= SplashProgressBar.Maximum)
               {
                SplashTimer.Enabled = false;

                 this.Hide();
                 SelectionForm selectionForm = new SelectionForm();
                 selectionForm.Show();
                 //this.Close();

             }

        }
    }
}
