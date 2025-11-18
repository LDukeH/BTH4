using System.Drawing;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        private int[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        private string currentFilePath = null;

        public Form1()
        {
            InitializeComponent();

            foreach (FontFamily font in FontFamily.Families)
            {
                fontToolStrip.Items.Add(font.Name);
            }
            foreach (int size in fontSizes)
            {
                sizeToolStrip.Items.Add(size);
            }
            fontToolStrip.Text = "Tahoma";
            fontToolStrip.SelectedItem = "Tahoma";
            sizeToolStrip.Text = "14";
            sizeToolStrip.SelectedItem = "14";

            editorText.Font = new Font("Tahoma", 14);
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    editorText.Font = fontDialog.Font;
                    fontToolStrip.Text = fontDialog.Font.Name;
                    sizeToolStrip.Text = fontDialog.Font.Size.ToString();
                    fontToolStrip.SelectedItem = fontDialog.Font.Name;
                    sizeToolStrip.SelectedItem = fontDialog.Font.Size.ToString();
                }
            }
        }

        private void fontToolStrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void sizeToolStrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void lưuNộiDungVănBảnCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void newStripButton_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void saveStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void boldStripButton_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void italicStripButton_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void underlineStripButton_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        //Cac ham xu ly
        private void saveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                    saveFileDialog.DefaultExt = "rtf";
                    saveFileDialog.AddExtension = true;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentFilePath = saveFileDialog.FileName;
                        editorText.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    }
                }
            }
            else
            {
                editorText.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu thành công!");
            }
        }

        private void openFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
                openFileDialog.DefaultExt = "rtf";
                openFileDialog.FilterIndex = 2;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    editorText.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void newFile()
        {
            editorText.Text = "";

            fontToolStrip.Text = "Tahoma";
            fontToolStrip.SelectedItem = "Tahoma";
            sizeToolStrip.Text = "14";
            sizeToolStrip.SelectedItem = "14";

            editorText.Font = new Font("Tahoma", 14);
        }

        private void ChangeFont()
        {
            if (fontToolStrip.Text != "" && sizeToolStrip.Text != "")
            {
                try
                {
                    float size = float.Parse(sizeToolStrip.Text);
                    editorText.Font = new Font(fontToolStrip.Text, size);
                }
                catch
                {
                    MessageBox.Show("Kích thước không hợp lệ!");
                }
            }
        }

        private void ToggleStyle(FontStyle style)
        {
            Font currentFont = editorText.SelectionFont;
            if (currentFont == null) return;

            FontStyle newFontStyle;

            if (currentFont.Style.HasFlag(style))
            {
                newFontStyle = currentFont.Style & ~style;
            }
            else
            {
                newFontStyle = currentFont.Style | style;
            }
            editorText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }
    }
}