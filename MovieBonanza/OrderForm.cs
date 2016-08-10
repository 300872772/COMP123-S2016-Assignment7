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
    public partial class OrderForm : Form
    {
        public string MovieURL;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectForm = new SelectionForm();
            selectForm.Show();
            this.Hide();
        }
        private void BackButton_MouseHover(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.Aqua;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.White;
        }

        private void BackButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackButton.ForeColor = Color.Red;
        }

        private void BackButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackButton.ForeColor = Color.Aqua;
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm();



            streamForm.Title = this.TitleTextBox.Text;
            streamForm.Category = this.CategoryTextBox.Text;
            streamForm.MovieImage = this.MoviePictureBox.BackgroundImage;
            streamForm.Cost = this.CostTextBox.Text;
            streamForm.SubTotal = this.SubTotalTextBox.Text;
            streamForm.SalesTax = this.SalesTaxTextBox.Text;
            streamForm.GrandTotal = this.GrandTotalTextBox.Text;
            if (this.DVDCheckBox.Checked) streamForm.DVD = true; else streamForm.DVD = false;
            streamForm.MovieURL = this.MovieURL;

            streamForm.Show();
            this.Hide();

        }

        private void StreamButton_MouseHover(object sender, EventArgs e)
        {
            StreamButton.ForeColor = Color.Red;

        }

        private void StreamButton_MouseLeave(object sender, EventArgs e)
        {
            StreamButton.ForeColor = Color.DarkRed;
        }

        private void StreamButton_MouseDown(object sender, MouseEventArgs e)
        {
            StreamButton.ForeColor = Color.Aqua;
        }

        private void StreamButton_MouseUp(object sender, MouseEventArgs e)
        {
            StreamButton.ForeColor = Color.Red;
        }

        private void CancleButton_MouseHover(object sender, EventArgs e)
        {
            CancleButton.ForeColor = Color.Aqua;
        }

        private void CancleButton_MouseLeave(object sender, EventArgs e)
        {
            CancleButton.ForeColor = Color.White;
        }

        private void CancleButton_MouseDown(object sender, MouseEventArgs e)
        {
            CancleButton.ForeColor = Color.Red;
        }

        private void CancleButton_MouseUp(object sender, MouseEventArgs e)
        {
            CancleButton.ForeColor = Color.Aqua;
        }

        private void BackOrderFormMenuStrip_Click(object sender, EventArgs e)
        {
            BackButton_Click(sender, e);
        }

        private void ExitOrderFormMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StreamOrderFormMenuStrip_Click(object sender, EventArgs e)
        {
            StreamButton_Click(sender, e);
        }

        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(DVDCheckBox.Checked)
            {
                this.GrandTotalTextBox.Text = Math.Round(Convert.ToDouble(this.SubTotalTextBox.Text) + Convert.ToDouble(this.SalesTaxTextBox.Text) + 10, 2).ToString();
            }
            else
            {
                this.GrandTotalTextBox.Text = Math.Round(Convert.ToDouble(this.SubTotalTextBox.Text) + Convert.ToDouble(this.SalesTaxTextBox.Text), 2).ToString();

            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
