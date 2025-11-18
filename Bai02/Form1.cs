using System;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            dateText.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy hh:mm:ss tt");

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            dateText.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy hh:mm:ss tt");
        }
    }
}