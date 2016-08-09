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
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();

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
    }
}
