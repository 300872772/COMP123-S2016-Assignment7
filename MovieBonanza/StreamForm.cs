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
     * This is the partial StreamForm class for movie streaming.  
     * </summary>  
     *   
     * @class StreamForm  
     */
    public partial class StreamForm : Form
    {
        //PRIVATE INSTANCE VARIABLE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string Title;
        public string Category;
        public Image MovieImage;
        public string Cost;
        public string SubTotal;
        public string SalesTax;
        public string GrandTotal;
        public bool DVD;
        public string MovieURL;
        public int MovieSelectionIndex;

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that initialize values.
        * </summary>
        * 
        * @constructor StreamForm 
        * 
        */
        public StreamForm()
        {
            InitializeComponent();
        }
        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
       * <summary>
       * This is the privte method for _Click event of BackButton
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
            if (this.DVD.Equals(true))
            { orderForm.DVDCheckBox.Checked = true;

               orderForm.DVDCostLabel.Visible = true;
                orderForm.DVDCostTextBox.Visible = true;
                orderForm.DVDCostTextBox.Text = "10.00";
            }
            else
            { orderForm.DVDCheckBox.Checked = false; }
            orderForm.MovieURL = this.MovieURL;
            orderForm.MovieSelectionIndex = this.MovieSelectionIndex;

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
       * This is the privte method for _Click event of SelectionButton
       * </summary>
       * 
       * @method SelectionButton_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void SelectionButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectForm = new SelectionForm();
            selectForm.Show();
            this.Hide();
        }
        /**
       * <summary>
       * This is the privte method for _MouseDown event of SelectionButton
       * </summary>
       * 
       * @method SelectionButton_MouseDown
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void SelectionButton_MouseDown(object sender, MouseEventArgs e)
        {
            SelectionButton.ForeColor = Color.Aqua;
        }
        /**
       * <summary>
       * This is the privte method for _MouseHover event of SelectionButton
       * </summary>
       * 
       * @method SelectionButton_MouseHover
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void SelectionButton_MouseHover(object sender, EventArgs e)
        {
            SelectionButton.ForeColor = Color.Red;
        }
        /**
       * <summary>
       * This is the privte method for _MouseLeave event of SelectionButton
       * </summary>
       * 
       * @method SelectionButton_MouseLeave
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void SelectionButton_MouseLeave(object sender, EventArgs e)
        {
            SelectionButton.ForeColor = Color.DarkRed;
        }
        /**
       * <summary>
       * This is the privte method for _MouseUp event of SelectionButton
       * </summary>
       * 
       * @method SelectionButton_MouseUp
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void SelectionButton_MouseUp(object sender, MouseEventArgs e)
        {
            SelectionButton.ForeColor = Color.Red;
        }
        /**
       * <summary>
       * This is the privte method for _Click event of SelectionStreamFormMenuStrip
       * </summary>
       * 
       * @method SelectionStreamFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void SelectionStreamFormMenuStrip_Click(object sender, EventArgs e)
        {
            SelectionButton_Click(sender, e);
        }
        /**
       * <summary>
       * This is the privte method for _Click event of ExitStreamFormMenuStrip
       * </summary>
       * 
       * @method ExitStreamFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void ExitStreamFormMenuStrip_Click(object sender, EventArgs e)
        {
            DialogResult exitDialogResult;
            exitDialogResult = MessageBox.Show("Do you realy want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);

            if (exitDialogResult == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

        }
        /**
       * <summary>
       * This is the privte method for _Load event of StreamForm
       * </summary>
       * 
       * @method StreamForm_Load
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void StreamForm_Load(object sender, EventArgs e)
        {


        }
        /**
       * <summary>
       * This is the privte method for _Activated event of StreamForm
       * </summary>
       * 
       * @method StreamForm_Activated
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
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
        /**
       * <summary>
       * This is the privte method for _Click event of AboutUsStreamFormMenuStrip
       * </summary>
       * 
       * @method AboutUsStreamFormMenuStrip_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void AboutUsStreamFormMenuStrip_Click(object sender, EventArgs e)
        {
            MovieBonanzaAboutBox aboutBox = new MovieBonanzaAboutBox();
            aboutBox.ShowDialog();
        }
        /**
       * <summary>
       * This is the privte method for _Navigated event of StreamWebBrowser
       * </summary>
       * 
       * @method StreamWebBrowser_Navigated
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void StreamWebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            StreamLabel3.Visible = false;
        }

        private void StreamWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        /**
       * <summary>
       * This is the privte method for _Click event of OkButton
       * </summary>
       * 
       * @method OkButton_Click
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void OkButton_Click(object sender, EventArgs e)
        {
            ExitStreamFormMenuStrip_Click(sender, e);
        }
        /**
       * <summary>
       * This is the privte method for _MouseLeave event of OkButton
       * </summary>
       * 
       * @method OkButton_MouseLeave
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void OkButton_MouseLeave(object sender, EventArgs e)
        {
            OkButton.ForeColor = Color.DarkRed;
        }
        /**
       * <summary>
       * This is the privte method for _MouseHover event of OkButton
       * </summary>
       * 
       * @method OkButton_MouseHover
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void OkButton_MouseHover(object sender, EventArgs e)
        {
            OkButton.ForeColor = Color.Red;
        }
        /**
       * <summary>
       * This is the privte method for _MouseDown event of OkButton
       * </summary>
       * 
       * @method OkButton_MouseDown
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void OkButton_MouseDown(object sender, MouseEventArgs e)
        {
            OkButton.ForeColor = Color.Cyan;
        }
        /**
       * <summary>
       * This is the privte method for _MouseUp event of OkButton
       * </summary>
       * 
       * @method OkButton_MouseUp
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
        private void OkButton_MouseUp(object sender, MouseEventArgs e)
        {
            OkButton.ForeColor = Color.Red;
        }
    }
}
