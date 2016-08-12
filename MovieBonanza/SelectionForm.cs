using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 
 *Author: Md Mamunur Rahman 
 * Student ID: 300872772  
 * 
 * Date last modified: August 09, 2016 
 * Description: This application demonstrates a Online Movie Streaming Solution  
 *  
 * Version: 0.0.6 - added all comments
 */
namespace MovieBonanza
{
    /**  
     * <summary>  
     * This is the partial SelectionForm class for movie selection.  
     * </summary>  
     *   
     * @class SelectionForm  
     */
    public partial class SelectionForm : Form
    {
        //PRIVATE INSTANCE VARIABLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        MovieList movieList;
        public string MovieURL;

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that initialize values.
        * </summary>
        * 
        * @constructor SelectionForm 
        * 
        */
        public SelectionForm()
        {
            InitializeComponent();
        }
        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
       * <summary>
       * This is the privte method for click event of NextButton
       * </summary>
       * 
       * @method NextButton_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
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
        /**
       * <summary>
       * This is the privte method for _MouseHover event of NextButton
       * </summary>
       * 
       * @method NextButton_MouseHover
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void NextButton_MouseHover(object sender, EventArgs e)
        {
            NextButton.ForeColor = Color.Aqua;
        }
        /**
       * <summary>
       * This is the privte method for _MouseLeave event of NextButton
       * </summary>
       * 
       * @method NextButton_MouseLeave
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void NextButton_MouseLeave(object sender, EventArgs e)
        {
            NextButton.ForeColor = Color.White;
        }
        /**
       * <summary>
       * This is the privte method for _MouseDown event of NextButton
       * </summary>
       * 
       * @method NextButton_MouseDown
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void NextButton_MouseDown(object sender, MouseEventArgs e)
        {
            NextButton.ForeColor = Color.Red;
        }
        /**
       * <summary>
       * This is the privte method for _MouseUp event of NextButton
       * </summary>
       * 
       * @method NextButton_MouseUp
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void NextButton_MouseUp(object sender, MouseEventArgs e)
        {
            NextButton.ForeColor = Color.Aqua;
        }
        /**
       * <summary>
       * This is the privte method for _Click event of ExitSelectionFormMenuStrip
       * </summary>
       * 
       * @method ExitSelectionFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void ExitSelectionFormMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        /**
       * <summary>
       * This is the privte method for _Click event of NextSelectionFormMenuStrip
       * </summary>
       * 
       * @method NextSelectionFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void NextSelectionFormMenuStrip_Click(object sender, EventArgs e)
        {
            NextButton_Click(sender, e);

        }
        /**
       * <summary>
       * This is the privte method for _Load event of SelectionForm form
       * </summary>
       * 
       * @method SelectionForm_Load
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void SelectionForm_Load(object sender, EventArgs e)
        {
             movieList = new MovieList("movieData");
            // movieList.OrderByDescending(o => o.Title).ToList();

            foreach (var item in movieList)
            {
                MovieSelectListBox.Items.Add(item.Title);
            }

            MovieSelectListBox.SetSelected(0, true);

            int index = movieList.FindIndex(o => o.Title.Contains(MovieSelectListBox.Text));
            

            
            TitleTextBox.Text = movieList[index].Title;
            CategoryTextBox.Text = movieList[index].Category;
            CostTextBox.Text = movieList[index].Cost.ToString();
            MoviePictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(movieList[0].MovieImage.Trim());
            MovieURL = movieList[index].MovieURL;


        }
        /**
       * <summary>
       * This is the privte method for _SelectedIndexChanged event of MovieSelectListBox
       * </summary>
       * 
       * @method MovieSelectListBox_SelectedIndexChanged
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void MovieSelectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = movieList.FindIndex(o => o.Title.Contains(MovieSelectListBox.Text));
            TitleTextBox.Text = movieList[index].Title;
            CategoryTextBox.Text = movieList[index].Category;
            CostTextBox.Text = movieList[index].Cost.ToString();
            MoviePictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(movieList[index].MovieImage.Trim());
            MovieURL = movieList[index].MovieURL;


        }
        /**
       * <summary>
       * This is the privte method for _Click event of AboutUsSelectionFormMenuStrip
       * </summary>
       * 
       * @method AboutUsSelectionFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void AboutUsSelectionFormMenuStrip_Click(object sender, EventArgs e)
        {
            MovieBonanzaAboutBox aboutBox = new MovieBonanzaAboutBox();
            aboutBox.ShowDialog();


        }

        private void MovieSelectListBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                NextButton_Click(sender, e);
                    break;

            }


        }
    }
}
