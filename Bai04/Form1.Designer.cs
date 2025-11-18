namespace Bai04
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
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tạoVănBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            mởTậpTinToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            lưuNộiDungVănBảnCtrlSToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            newStripButton = new ToolStripButton();
            saveStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            fontToolStrip = new ToolStripComboBox();
            toolStripSeparator5 = new ToolStripSeparator();
            sizeToolStrip = new ToolStripComboBox();
            toolStripSeparator6 = new ToolStripSeparator();
            boldStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            italicStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            underlineStripButton = new ToolStripButton();
            editorText = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnMớiToolStripMenuItem, mởTậpTinToolStripMenuItem, toolStripSeparator1, lưuNộiDungVănBảnCtrlSToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            tạoVănBảnMớiToolStripMenuItem.Image = Properties.Resources.createFile;
            tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            tạoVănBảnMớiToolStripMenuItem.Size = new Size(285, 26);
            tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            tạoVănBảnMớiToolStripMenuItem.Click += tạoVănBảnMớiToolStripMenuItem_Click;
            // 
            // mởTậpTinToolStripMenuItem
            // 
            mởTậpTinToolStripMenuItem.Image = Properties.Resources.openFile;
            mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            mởTậpTinToolStripMenuItem.Size = new Size(285, 26);
            mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            mởTậpTinToolStripMenuItem.Click += mởTậpTinToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = SystemColors.Highlight;
            toolStripSeparator1.ForeColor = SystemColors.ActiveCaption;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(282, 6);
            // 
            // lưuNộiDungVănBảnCtrlSToolStripMenuItem
            // 
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.Image = Properties.Resources.saveFile;
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.Name = "lưuNộiDungVănBảnCtrlSToolStripMenuItem";
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.Size = new Size(285, 26);
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.Text = "Lưu nội dung văn bản";
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.Click += lưuNộiDungVănBảnCtrlSToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(285, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(92, 24);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            địnhDạngToolStripMenuItem.Click += địnhDạngToolStripMenuItem_Click;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { newStripButton, saveStripButton, toolStripSeparator4, fontToolStrip, toolStripSeparator5, sizeToolStrip, toolStripSeparator6, boldStripButton, toolStripSeparator2, italicStripButton, toolStripSeparator3, underlineStripButton });
            toolStrip.Location = new Point(0, 28);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 28);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip1";
            // 
            // newStripButton
            // 
            newStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newStripButton.Image = Properties.Resources.createFile;
            newStripButton.ImageTransparentColor = Color.Magenta;
            newStripButton.Name = "newStripButton";
            newStripButton.Size = new Size(29, 25);
            newStripButton.Text = "toolStripButton1";
            newStripButton.Click += newStripButton_Click;
            // 
            // saveStripButton
            // 
            saveStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveStripButton.Image = Properties.Resources.saveFile;
            saveStripButton.ImageTransparentColor = Color.Magenta;
            saveStripButton.Name = "saveStripButton";
            saveStripButton.Size = new Size(29, 25);
            saveStripButton.Text = "toolStripButton2";
            saveStripButton.Click += saveStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 28);
            // 
            // fontToolStrip
            // 
            fontToolStrip.Name = "fontToolStrip";
            fontToolStrip.Size = new Size(121, 28);
            fontToolStrip.SelectedIndexChanged += fontToolStrip_SelectedIndexChanged;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 28);
            // 
            // sizeToolStrip
            // 
            sizeToolStrip.Name = "sizeToolStrip";
            sizeToolStrip.Size = new Size(121, 28);
            sizeToolStrip.SelectedIndexChanged += sizeToolStrip_SelectedIndexChanged;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 28);
            // 
            // boldStripButton
            // 
            boldStripButton.BackColor = SystemColors.AppWorkspace;
            boldStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            boldStripButton.Image = Properties.Resources.boldButton;
            boldStripButton.ImageTransparentColor = Color.Magenta;
            boldStripButton.Name = "boldStripButton";
            boldStripButton.Size = new Size(29, 25);
            boldStripButton.Text = "toolStripButton3";
            boldStripButton.Click += boldStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = SystemColors.ActiveCaptionText;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // italicStripButton
            // 
            italicStripButton.BackColor = SystemColors.AppWorkspace;
            italicStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            italicStripButton.Image = Properties.Resources.italicButton;
            italicStripButton.ImageTransparentColor = Color.Magenta;
            italicStripButton.Name = "italicStripButton";
            italicStripButton.Size = new Size(29, 25);
            italicStripButton.Text = "toolStripButton4";
            italicStripButton.Click += italicStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.BackColor = SystemColors.ActiveCaptionText;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // underlineStripButton
            // 
            underlineStripButton.BackColor = SystemColors.AppWorkspace;
            underlineStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            underlineStripButton.Image = Properties.Resources.underlineButton;
            underlineStripButton.ImageTransparentColor = Color.Magenta;
            underlineStripButton.Name = "underlineStripButton";
            underlineStripButton.Size = new Size(29, 25);
            underlineStripButton.Text = "toolStripButton5";
            underlineStripButton.Click += underlineStripButton_Click;
            // 
            // editorText
            // 
            editorText.Dock = DockStyle.Fill;
            editorText.Location = new Point(0, 56);
            editorText.Name = "editorText";
            editorText.Size = new Size(800, 394);
            editorText.TabIndex = 3;
            editorText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editorText);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Soạn thảo văn bản";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private ToolStripMenuItem lưuNộiDungVănBảnCtrlSToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripButton newStripButton;
        private ToolStripButton saveStripButton;
        private ToolStripComboBox fontToolStrip;
        private ToolStripComboBox sizeToolStrip;
        private ToolStripButton boldStripButton;
        private ToolStripButton italicStripButton;
        private ToolStripButton underlineStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private RichTextBox editorText;
    }
}
