namespace Bai05
{
    partial class ThemModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemModal));
            toolStrip1 = new ToolStrip();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mssvText = new TextBox();
            tenText = new TextBox();
            diemText = new TextBox();
            khoaComboBox = new ComboBox();
            btnCancel = new ToolStripButton();
            btnOK = new ToolStripButton();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCancel, btnOK });
            toolStrip1.Location = new Point(0, 411);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1470585F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.85294F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(mssvText, 1, 0);
            tableLayoutPanel1.Controls.Add(tenText, 1, 1);
            tableLayoutPanel1.Controls.Add(diemText, 1, 3);
            tableLayoutPanel1.Controls.Add(khoaComboBox, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(60);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.10204F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.89796F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tableLayoutPanel1.Size = new Size(800, 411);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(63, 60);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã Số Sinh Viên";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(63, 115);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(63, 160);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 2;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(63, 216);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 3;
            label4.Text = "Điểm TB";
            // 
            // mssvText
            // 
            mssvText.Font = new Font("Segoe UI", 10F);
            mssvText.Location = new Point(234, 63);
            mssvText.Name = "mssvText";
            mssvText.Size = new Size(487, 30);
            mssvText.TabIndex = 4;
            // 
            // tenText
            // 
            tenText.Font = new Font("Segoe UI", 10F);
            tenText.Location = new Point(234, 118);
            tenText.Name = "tenText";
            tenText.Size = new Size(503, 30);
            tenText.TabIndex = 5;
            // 
            // diemText
            // 
            diemText.Font = new Font("Segoe UI", 10F);
            diemText.Location = new Point(234, 219);
            diemText.Name = "diemText";
            diemText.Size = new Size(149, 30);
            diemText.TabIndex = 6;
            // 
            // khoaComboBox
            // 
            khoaComboBox.Font = new Font("Segoe UI", 10F);
            khoaComboBox.FormattingEnabled = true;
            khoaComboBox.Items.AddRange(new object[] { "Khoa học máy tính", "Kỹ thuật phần mềm", "Mạng máy tính và truyền thông dữ liệu", "Hệ thống thông tin", "An toàn thông tin", "Trí tuệ nhân tạo", "Khoa học dữ liệu", "Thương mại điện tử" });
            khoaComboBox.Location = new Point(234, 163);
            khoaComboBox.Name = "khoaComboBox";
            khoaComboBox.Size = new Size(217, 31);
            khoaComboBox.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Alignment = ToolStripItemAlignment.Right;
            btnCancel.BackColor = Color.OrangeRed;
            btnCancel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCancel.Font = new Font("Segoe UI", 14F);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageTransparentColor = Color.Magenta;
            btnCancel.Margin = new Padding(0, 1, 24, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(79, 36);
            btnCancel.Text = "Thoát";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Alignment = ToolStripItemAlignment.Right;
            btnOK.BackColor = Color.LimeGreen;
            btnOK.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnOK.Font = new Font("Segoe UI", 14F);
            btnOK.Image = (Image)resources.GetObject("btnOK.Image");
            btnOK.ImageTransparentColor = Color.Magenta;
            btnOK.Margin = new Padding(0, 1, 24, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(128, 36);
            btnOK.Text = "Thêm Mới";
            btnOK.Click += btnOK_Click;
            // 
            // ThemModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            Name = "ThemModal";
            Text = "ThemModal";
            Load += ThemModal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCancel;
        private ToolStripButton btnOK;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox mssvText;
        private TextBox tenText;
        private TextBox diemText;
        private ComboBox khoaComboBox;
    }
}