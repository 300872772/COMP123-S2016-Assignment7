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
     * This is the partial SplashForm class for starting splash.  
     * </summary>  
     *   
     * @class SplashForm  
     */
    public partial class SplashForm : Form
    {
        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that initialize values.
        * </summary>
        * 
        * @constructor SplashForm 
        * 
        */
        public SplashForm()
        {
            InitializeComponent();
        }
        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
       * <summary>
       * This is the privte method for _Tick event of SplashTimer
       * </summary>
       * 
       * @method SplashTimer_Tick
       * @returns {void} 
       * @param {Object} sender
       * @param {EventArgs} e
       * 
       */
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

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
