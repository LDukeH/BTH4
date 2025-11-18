namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Cac ham xu ly
        private string openFile()
        {
            string filePath = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                }
            }
            return filePath;
        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            sourceLink.Text = openFile();
        }

        private void destButton_Click(object sender, EventArgs e)
        {
            destLink.Text = openFile();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = sourceLink.Text;
                string destPath = destLink.Text;

                string sourceExt = Path.GetExtension(sourcePath);
                string destExt = Path.GetExtension(destPath);

                if (!string.Equals(sourceExt, destExt, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Loại tập tin không trùng khớp!\nNguồn: {sourceExt}\nĐích: {destExt}",
                                    "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                long fileSize = new FileInfo(sourcePath).Length;
                progressBar.Value = 0;
                progressBar.Maximum = 100;

                int bufferSize = 102; //0.1KB
                byte[] buffer = new byte[bufferSize];
                long totalBytesRead = 0;

                using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
                using (FileStream destStream = new FileStream(destPath, FileMode.Create, FileAccess.Write))
                {
                    int bytesRead;
                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destStream.Write(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;

                        int value = (int)((totalBytesRead * 100) / fileSize);
                        progressBar.Value = value;
                        progressBar.Refresh();
                    }
                }
                MessageBox.Show("Sao chép tập tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sao chép tập tin: " + ex.Message);
            }
        }
    }
}