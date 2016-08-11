using System;
using System.Collections.Generic;
using System.Linq;
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
     * This is the driver class for running starting form.  
     * </summary>  
     *   
     * @class Program  
     */
    static class Program
    {
        //MAIN MATHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ 
        /** 
        * <summary> 
        * The main method for driver class Program 
        * </summary> 
        * @method Main  
        * @returns {void} 
        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
