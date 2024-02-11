using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_WindowsFormsIntro
{
    public partial class Form1 : Form
    {
        int x = 0;
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(CalcIn.Text);
            }
            catch { }
        }

        private void CalculateBTN_MouseClick(object sender, MouseEventArgs e)
        {
            CalcOut.Text = Convert.ToString(x * x - 3 + x);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(rng.Next(0, 255), rng.Next(0, 255), rng.Next(0, 255));
        }

        private void MouseOverLeft_MouseMove(object sender, MouseEventArgs e)
        {
            MouseOverLeft.Text = "Arrival";
            MouseOverRight.Text = "Departure";
        }

        private void MouseOverRight_MouseMove(object sender, MouseEventArgs e)
        {
            MouseOverLeft.Text = "Departure";
            MouseOverRight.Text = "Arrival";
        }
    }
}
