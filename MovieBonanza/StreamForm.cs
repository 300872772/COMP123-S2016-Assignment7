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
        public StreamForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
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
    }
}
