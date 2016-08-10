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
    public partial class SelectionForm : Form
    {
        MovieList movieList;
        public string MovieURL;
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();

            orderForm.TitleTextBox.Text = this.TitleTextBox.Text;
            orderForm.CategoryTextBox.Text = this.CategoryTextBox.Text;
            orderForm.MoviePictureBox.BackgroundImage = this.MoviePictureBox.BackgroundImage;
            orderForm.CostTextBox.Text = this.CostTextBox.Text;
            orderForm.SubTotalTextBox.Text = orderForm.CostTextBox.Text;
            orderForm.SalesTaxTextBox.Text = Math.Round(Convert.ToDouble(orderForm.SubTotalTextBox.Text)*.13,2).ToString();
            orderForm.GrandTotalTextBox.Text = Math.Round(Convert.ToDouble(orderForm.SubTotalTextBox.Text) + Convert.ToDouble(orderForm.SalesTaxTextBox.Text),2).ToString();
            orderForm.MovieURL = this.MovieURL;
            orderForm.MovieSelectionIndex = MovieSelectListBox.SelectedIndex;
        }

        private void NextButton_MouseHover(object sender, EventArgs e)
        {
            NextButton.ForeColor = Color.Aqua;
        }

        private void NextButton_MouseLeave(object sender, EventArgs e)
        {
            NextButton.ForeColor = Color.White;
        }

        private void NextButton_MouseDown(object sender, MouseEventArgs e)
        {
            NextButton.ForeColor = Color.Red;
        }

        private void NextButton_MouseUp(object sender, MouseEventArgs e)
        {
            NextButton.ForeColor = Color.Aqua;
        }

        private void ExitSelectionFormMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextSelectionFormMenuStrip_Click(object sender, EventArgs e)
        {
            NextButton_Click(sender, e);

        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
             movieList = new MovieList("movieData");
            

            foreach (var item in movieList)
            {
                MovieSelectListBox.Items.Add(item.Title);
            }

            MovieSelectListBox.SetSelected(0,true);
            TitleTextBox.Text = movieList[0].Title;
            CategoryTextBox.Text = movieList[0].Category;
            CostTextBox.Text = movieList[0].Cost.ToString();
            MoviePictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(movieList[0].MovieImage.Trim());
            MovieURL = movieList[0].MovieURL;


        }

        private void MovieSelectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = movieList[MovieSelectListBox.SelectedIndex].Title;
            CategoryTextBox.Text = movieList[MovieSelectListBox.SelectedIndex].Category;
            CostTextBox.Text = movieList[MovieSelectListBox.SelectedIndex].Cost.ToString();
            MoviePictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(movieList[MovieSelectListBox.SelectedIndex].MovieImage.Trim());
            MovieURL = movieList[MovieSelectListBox.SelectedIndex].MovieURL;


        }

        private void AboutUsSelectionFormMenuStrip_Click(object sender, EventArgs e)
        {
            MovieBonanzaAboutBox aboutBox = new MovieBonanzaAboutBox();
            aboutBox.ShowDialog();


        }
    }
}
