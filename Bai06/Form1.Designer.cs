namespace Bai06
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            sourceLink = new MaskedTextBox();
            destLink = new TextBox();
            sourceButton = new Button();
            destButton = new Button();
            copyButton = new Button();
            groupBox2 = new GroupBox();
            progressBar = new ProgressBar();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao chép tập tin";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1158676F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.88413F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(sourceLink, 1, 0);
            tableLayoutPanel1.Controls.Add(destLink, 1, 1);
            tableLayoutPanel1.Controls.Add(sourceButton, 2, 0);
            tableLayoutPanel1.Controls.Add(destButton, 2, 1);
            tableLayoutPanel1.Controls.Add(copyButton, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Margin = new Padding(3, 20, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 30, 10, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.Size = new Size(794, 245);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(13, 30);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 0;
            label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(13, 89);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 1;
            label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // sourceLink
            // 
            sourceLink.BorderStyle = BorderStyle.FixedSingle;
            sourceLink.Dock = DockStyle.Top;
            sourceLink.Location = new Point(215, 33);
            sourceLink.Name = "sourceLink";
            sourceLink.Size = new Size(421, 27);
            sourceLink.TabIndex = 2;
            // 
            // destLink
            // 
            destLink.BorderStyle = BorderStyle.FixedSingle;
            destLink.Dock = DockStyle.Top;
            destLink.Location = new Point(215, 92);
            destLink.Name = "destLink";
            destLink.Size = new Size(421, 27);
            destLink.TabIndex = 3;
            // 
            // sourceButton
            // 
            sourceButton.BackColor = SystemColors.ControlDark;
            sourceButton.Font = new Font("Segoe UI", 9F);
            sourceButton.ForeColor = SystemColors.Desktop;
            sourceButton.Location = new Point(642, 33);
            sourceButton.Name = "sourceButton";
            sourceButton.Size = new Size(44, 29);
            sourceButton.TabIndex = 5;
            sourceButton.Text = "...";
            sourceButton.UseVisualStyleBackColor = false;
            sourceButton.Click += sourceButton_Click;
            // 
            // destButton
            // 
            destButton.BackColor = SystemColors.ControlDark;
            destButton.Font = new Font("Segoe UI", 9F);
            destButton.ForeColor = SystemColors.Desktop;
            destButton.Location = new Point(642, 92);
            destButton.Name = "destButton";
            destButton.Size = new Size(44, 29);
            destButton.TabIndex = 6;
            destButton.Text = "...";
            destButton.UseVisualStyleBackColor = false;
            destButton.Click += destButton_Click;
            // 
            // copyButton
            // 
            copyButton.Anchor = AnchorStyles.Left;
            copyButton.BackColor = SystemColors.AppWorkspace;
            copyButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            copyButton.ForeColor = SystemColors.Desktop;
            copyButton.Location = new Point(215, 176);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(207, 40);
            copyButton.TabIndex = 7;
            copyButton.Text = "Sao chép";
            copyButton.UseVisualStyleBackColor = false;
            copyButton.Click += copyButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(0, 292);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(20, 30, 20, 3);
            groupBox2.Size = new Size(800, 158);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Top;
            progressBar.Location = new Point(20, 50);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(760, 25);
            progressBar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private MaskedTextBox sourceLink;
        private TextBox destLink;
        private Button sourceButton;
        private Button destButton;
        private ProgressBar progressBar;
        private Button copyButton;
    }
}
