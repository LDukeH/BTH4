namespace Bai05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            addUserButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            dataGrid = new DataGridView();
            soTT = new DataGridViewTextBoxColumn();
            maSoSV = new DataGridViewTextBoxColumn();
            tenSV = new DataGridViewTextBoxColumn();
            khoa = new DataGridViewTextBoxColumn();
            diemTB = new DataGridViewTextBoxColumn();
            searchTextBox = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1106, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem, thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(96, 24);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.Size = new Size(159, 26);
            thêmMớiToolStripMenuItem.Text = "Thêm mới";
            thêmMớiToolStripMenuItem.Click += thêmMớiToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(159, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel2, addUserButton, toolStripSeparator1, toolStripLabel1, searchTextBox });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1106, 40);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(0, 37);
            // 
            // addUserButton
            // 
            addUserButton.Font = new Font("Segoe UI", 14F);
            addUserButton.Image = Properties.Resources.addUserIcon;
            addUserButton.ImageScaling = ToolStripItemImageScaling.None;
            addUserButton.ImageTransparentColor = Color.Magenta;
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(160, 37);
            addUserButton.Text = "Thêm Mới";
            addUserButton.TextAlign = ContentAlignment.MiddleRight;
            addUserButton.Click += addUserButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = SystemColors.Control;
            toolStripSeparator1.Margin = new Padding(60, 0, 60, 0);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 40);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 12F);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(175, 37);
            toolStripLabel1.Text = "Tìm Kiếm Theo Tên";
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { soTT, maSoSV, tenSV, khoa, diemTB });
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 68);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(1106, 522);
            dataGrid.TabIndex = 2;
            dataGrid.AllowUserToAddRows = false;
            // 
            // soTT
            // 
            soTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            soTT.HeaderText = "Số TT";
            soTT.MinimumWidth = 6;
            soTT.Name = "soTT";
            // 
            // maSoSV
            // 
            maSoSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maSoSV.HeaderText = "Mã Số SV";
            maSoSV.MinimumWidth = 6;
            maSoSV.Name = "maSoSV";
            // 
            // tenSV
            // 
            tenSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenSV.HeaderText = "Tên Sinh Viên";
            tenSV.MinimumWidth = 6;
            tenSV.Name = "tenSV";
            // 
            // khoa
            // 
            khoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            khoa.HeaderText = "Khoa";
            khoa.MinimumWidth = 6;
            khoa.Name = "khoa";
            // 
            // diemTB
            // 
            diemTB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            diemTB.HeaderText = "Điểm TB";
            diemTB.MinimumWidth = 6;
            diemTB.Name = "diemTB";
            // 
            // searchTextBox
            // 
            searchTextBox.AutoSize = false;
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Font = new Font("Segoe UI", 10F);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(300, 30);
            searchTextBox.TextChanged += searchTextBox_TextChange;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 590);
            Controls.Add(dataGrid);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton addUserButton;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn soTT;
        private DataGridViewTextBoxColumn maSoSV;
        private DataGridViewTextBoxColumn tenSV;
        private DataGridViewTextBoxColumn khoa;
        private DataGridViewTextBoxColumn diemTB;
        private ToolStripTextBox searchTextBox;
    }
}
