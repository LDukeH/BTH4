using System;

namespace Bai05
{
    public partial class Form1 : Form
    {
        private int _id = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserStripButton_Click(object sender, EventArgs e)
        {
            openThemModal();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openThemModal();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            openThemModal();
        }

        private void addUserLabel_Click(object sender, EventArgs e)
        {
            openThemModal();
        }

        private void searchTextBox_TextChange(object sender, EventArgs e)
        {
            SearchDataGrid(searchTextBox.Text);
        }

        //Cac ham xu ly
        private void openThemModal()
        {
            using (ThemModal modal = new ThemModal())
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    string ten = modal.ten;
                    string mssv = modal.mssv;
                    string diem = modal.diem.ToString();
                    string khoa = modal.selectedKhoa;

                    dataGrid.Rows.Add(_id, mssv, ten, khoa, diem);
                    _id++;
                }
            }
        }

        private void SearchDataGrid(string keyword)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                bool isVisible = false;

                if (row.Cells["tenSV"].Value != null)
                {
                    //Kiem tra xem cai ten viet thuong co contain keyword viet thuong khong
                    isVisible = row.Cells["tenSV"].Value.ToString().ToLower().Contains(keyword.ToLower());
                }

                row.Visible = isVisible;
            }
        }
    }
}