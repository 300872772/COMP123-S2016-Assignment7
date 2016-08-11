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
     * This is the partial OrderForm class for movie order.  
     * </summary>  
     *   
     * @class OrderForm  
     */
    public partial class OrderForm : Form
    {
        //PRIVATE INSTANCE VARIABLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string MovieURL;
        public int MovieSelectionIndex;

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that initialize values.
        * </summary>
        * 
        * @constructor OrderForm 
        * 
        */
        public OrderForm()
        {
            InitializeComponent();
        }
        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
       * <summary>
       * This is the privte method for click event of BackButton
       * </summary>
       * 
       * @method BackButton_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void BackButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectForm = new SelectionForm();
            selectForm.Show();
            this.Hide();

          selectForm.MovieSelectListBox.SetSelected(MovieSelectionIndex, true);
            selectForm.TitleTextBox.Text = this.TitleTextBox.Text;
            selectForm.CategoryTextBox.Text = this.CategoryTextBox.Text;
            selectForm.MoviePictureBox.BackgroundImage = this.MoviePictureBox.BackgroundImage;
            selectForm.CostTextBox.Text = this.CostTextBox.Text;

        }
        /**
       * <summary>
       * This is the privte method for _MouseHover event of BackButton
       * </summary>
       * 
       * @method BackButton_MouseHover
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void BackButton_MouseHover(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.Aqua;
        }
        /**
       * <summary>
       * This is the privte method for _MouseLeave event of BackButton
       * </summary>
       * 
       * @method BackButton_MouseLeave
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.White;
        }
        /**
       * <summary>
       * This is the privte method for _MouseDown event of BackButton
       * </summary>
       * 
       * @method BackButton_MouseDown
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void BackButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackButton.ForeColor = Color.Red;
        }
        /**
       * <summary>
       * This is the privte method for _MouseUp event of BackButton
       * </summary>
       * 
       * @method BackButton_MouseUp
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void BackButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackButton.ForeColor = Color.Aqua;
        }
        /**
       * <summary>
       * This is the privte method for _Click event of StreamButton which open stream form
       * </summary>
       * 
       * @method StreamButton_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
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
            streamForm.MovieSelectionIndex = this.MovieSelectionIndex;
            streamForm.Show();
            this.Hide();

        }
        /**
       * <summary>
       * This is the privte method for _MouseHover event of StreamButton
       * </summary>
       * 
       * @method StreamButton_MouseHover
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void StreamButton_MouseHover(object sender, EventArgs e)
        {
            StreamButton.ForeColor = Color.Red;

        }
        /**
       * <summary>
       * This is the privte method for _MouseLeave event of StreamButton
       * </summary>
       * 
       * @method StreamButton_MouseLeave
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void StreamButton_MouseLeave(object sender, EventArgs e)
        {
            StreamButton.ForeColor = Color.DarkRed;
        }
        /**
       * <summary>
       * This is the privte method for _MouseDown event of StreamButton
       * </summary>
       * 
       * @method StreamButton_MouseDown
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void StreamButton_MouseDown(object sender, MouseEventArgs e)
        {
            StreamButton.ForeColor = Color.Aqua;
        }
        /**
       * <summary>
       * This is the privte method for _MouseUp event of StreamButton
       * </summary>
       * 
       * @method StreamButton_MouseUp
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void StreamButton_MouseUp(object sender, MouseEventArgs e)
        {
            StreamButton.ForeColor = Color.Red;
        }
        /**
       * <summary>
       * This is the privte method for _MouseHover event of CancleButton
       * </summary>
       * 
       * @method CancleButton_MouseHover
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void CancleButton_MouseHover(object sender, EventArgs e)
        {
            CancleButton.ForeColor = Color.Aqua;
        }
        /**
       * <summary>
       * This is the privte method for _MouseLeave event of CancleButton
       * </summary>
       * 
       * @method CancleButton_MouseLeave
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void CancleButton_MouseLeave(object sender, EventArgs e)
        {
            CancleButton.ForeColor = Color.White;
        }
        /**
       * <summary>
       * This is the privte method for _MouseDown event of CancleButton
       * </summary>
       * 
       * @method CancleButton_MouseDown
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void CancleButton_MouseDown(object sender, MouseEventArgs e)
        {
            CancleButton.ForeColor = Color.Red;
        }
        /**
       * <summary>
       * This is the privte method for _MouseUp event of CancleButton
       * </summary>
       * 
       * @method CancleButton_MouseUp
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void CancleButton_MouseUp(object sender, MouseEventArgs e)
        {
            CancleButton.ForeColor = Color.Aqua;
        }
        /**
       * <summary>
       * This is the privte method for _Click event of BackOrderFormMenuStrip
       * </summary>
       * 
       * @method BackOrderFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void BackOrderFormMenuStrip_Click(object sender, EventArgs e)
        {
            BackButton_Click(sender, e);
        }
        /**
       * <summary>
       * This is the privte method for _Click event of ExitOrderFormMenuStrip
       * </summary>
       * 
       * @method ExitOrderFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void ExitOrderFormMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        /**
       * <summary>
       * This is the privte method for _Click event of StreamOrderFormMenuStrip
       * </summary>
       * 
       * @method StreamOrderFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void StreamOrderFormMenuStrip_Click(object sender, EventArgs e)
        {
            StreamButton_Click(sender, e);
        }
        /**
       * <summary>
       * This is the privte method for _CheckedChanged event of DVDCheckBox
       * </summary>
       * 
       * @method DVDCheckBox_CheckedChanged
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(DVDCheckBox.Checked)
            {
                this.GrandTotalTextBox.Text = Math.Round(Convert.ToDouble(this.SubTotalTextBox.Text) + Convert.ToDouble(this.SalesTaxTextBox.Text) + 10, 2).ToString();

                DVDCostLabel.Visible = true;
                DVDCostTextBox.Visible = true;
                DVDCostTextBox.Text = "10.00";
            }
            else
            {
                this.GrandTotalTextBox.Text = Math.Round(Convert.ToDouble(this.SubTotalTextBox.Text) + Convert.ToDouble(this.SalesTaxTextBox.Text), 2).ToString();

                DVDCostLabel.Visible = false;
                DVDCostTextBox.Visible = false;
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
        /**
       * <summary>
       * This is the privte method for _Click event of CancleButton
       * </summary>
       * 
       * @method CancleButton_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void CancleButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectForm = new SelectionForm();
            selectForm.Show();
            this.Close();
        }
        /**
       * <summary>
       * This is the privte method for _Click event of printToolStripMenuItem
       * </summary>
       * 
       * @method printToolStripMenuItem_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to print?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if(result==DialogResult.Yes)
            { 
                MessageBox.Show("Printing is in process.");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Printing has been canceled.");

            }
            else
            {
                MessageBox.Show("Printing has been canceled.");
            }

        }
        /**
       * <summary>
       * This is the privte method for _Click event of cancelToolStripMenuItem
       * </summary>
       * 
       * @method cancelToolStripMenuItem_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancleButton_Click(sender, e);
        }
        /**
       * <summary>
       * This is the privte method for _Click event of AboutUsOrderFormMenuStrip
       * </summary>
       * 
       * @method AboutUsOrderFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void AboutUsOrderFormMenuStrip_Click(object sender, EventArgs e)
        {
            MovieBonanzaAboutBox aboutBox = new MovieBonanzaAboutBox();
             aboutBox.ShowDialog();
        }
    }
}
