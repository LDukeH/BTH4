using System;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private string date;
        private string time;

        public Form1()
        {
            InitializeComponent();

            date = DateTime.Now.ToString("d/m/yyyy");
            time = DateTime.Now.ToString("hh:mm:ss tt");

            dateStatusText.Text = $"Hôm nay là ngày {date} - Bây giờ là {time}";

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Media Files|*.mp3;*.mp4;*.wav;*.wmv;*.avi;*.mkv|All Files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            date = DateTime.Now.ToString("d/M/yyyy");
            time = DateTime.Now.ToString("hh:mm:ss tt");
            dateStatusText.Text = $"Hôm nay là ngày {date} - Bây giờ là {time}";
        }
    }
}