using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai05
{
    public partial class ThemModal : Form
    {
        public string selectedKhoa;
        public string mssv;
        public string ten;
        public float diem;

        public ThemModal()
        {
            InitializeComponent();
            this.Load += ThemModal_Load;

            this.KeyPreview = true;
            this.KeyDown += ThemModal_KeyDown;
        }

        private void ThemModal_Load(object sender, EventArgs e)
        {
            khoaComboBox.SelectedIndex = 0;
        }

        private void ThemModal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mssvText.Text) || string.IsNullOrEmpty(tenText.Text) || string.IsNullOrEmpty(diemText.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mssv = mssvText.Text;
            ten = tenText.Text;
            diem = float.Parse(diemText.Text);
            selectedKhoa = khoaComboBox.SelectedItem.ToString();

            if (diem > 10 || diem < 0)
            {
                MessageBox.Show("Điểm phải từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}