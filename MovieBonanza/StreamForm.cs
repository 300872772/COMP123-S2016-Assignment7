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
    public partial class StreamForm : Form
    {
        public string Title;
        public string Category;
        public Image MovieImage;
        public string Cost;
        public string SubTotal;
        public string SalesTax;
        public string GrandTotal;
        public bool DVD;
        public string MovieURL;

        public StreamForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();

            orderForm.TitleTextBox.Text = this.Title;
            orderForm.CategoryTextBox.Text = this.Category;
            orderForm.MoviePictureBox.BackgroundImage = this.MovieImage;
            orderForm.CostTextBox.Text = this.Cost;
            orderForm.SubTotalTextBox.Text = this.SubTotal;
            orderForm.SalesTaxTextBox.Text = this.SalesTax;
            orderForm.GrandTotalTextBox.Text = this.GrandTotal;
            if (this.DVD.Equals(true)) orderForm.DVDCheckBox.Checked=true; else orderForm.DVDCheckBox.Checked=false;
            orderForm.MovieURL = this.MovieURL;


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

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectForm = new SelectionForm();
            selectForm.Show();
            this.Hide();
        }

        private void SelectionButton_MouseDown(object sender, MouseEventArgs e)
        {
            SelectionButton.ForeColor = Color.Aqua;
        }

        private void SelectionButton_MouseHover(object sender, EventArgs e)
        {
            SelectionButton.ForeColor = Color.Red;
        }

        private void SelectionButton_MouseLeave(object sender, EventArgs e)
        {
            SelectionButton.ForeColor = Color.DarkRed;
        }

        private void SelectionButton_MouseUp(object sender, MouseEventArgs e)
        {
            SelectionButton.ForeColor = Color.Red;
        }

        private void SelectionStreamFormMenuStrip_Click(object sender, EventArgs e)
        {
            SelectionButton_Click(sender, e);
        }

        private void ExitStreamFormMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {


        }

        private void StreamForm_Activated(object sender, EventArgs e)
        {
            if (this.MovieURL != "")
            {
                const string page = "<html><head><title></title></head><body>{0}</body></html>";
                this.StreamWebBrowser.DocumentText = string.Format(page, "<iframe width=\"560\" height=\"315\" src=\"" + this.MovieURL + "\" frameborder=\"0\" allowfullscreen></iframe>");
               
            }
            else
            {
                MessageBox.Show("Movie URL is not correct");
            }
        }

        private void StreamWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
