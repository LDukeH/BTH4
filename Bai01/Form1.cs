namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MouseClick += Form1_Click;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Click(object sender, MouseEventArgs e)
        {
            string button = "";

            switch (e.Button)
            {
                case MouseButtons.Left:
                    button = "Trái";
                    break;

                case MouseButtons.Right:
                    button = "Phải";
                    break;

                case MouseButtons.Middle:
                    button = "Giữa";
                    break;
            }
            MessageBox.Show($"Bạn đã nhấn chuột {button} tại vị trí ({e.X}, {e.Y})", "Thông báo");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show($"Bạn đã nhấn phím: {e.KeyCode}, ASCII: {e.KeyValue}");
        }
    }
}