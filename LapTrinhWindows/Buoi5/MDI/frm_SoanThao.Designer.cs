namespace LapTrinhWindows.Buoi5.MDI
{
    partial class frm_SoanThao
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.systemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.sizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemMenu,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 33);
            this.menuStrip.TabIndex = 3;
            // 
            // systemMenu
            // 
            this.systemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileItem,
            this.openFileItem,
            this.saveFileItem,
            this.exitItem});
            this.systemMenu.Name = "systemMenu";
            this.systemMenu.Size = new System.Drawing.Size(103, 29);
            this.systemMenu.Text = "Hệ thống";
            // 
            // newFileItem
            // 
            this.newFileItem.Name = "newFileItem";
            this.newFileItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileItem.Size = new System.Drawing.Size(349, 34);
            this.newFileItem.Text = "Tạo văn bản mới";
            // 
            // openFileItem
            // 
            this.openFileItem.Name = "openFileItem";
            this.openFileItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileItem.Size = new System.Drawing.Size(349, 34);
            this.openFileItem.Text = "Mở tập tin";
            // 
            // saveFileItem
            // 
            this.saveFileItem.Name = "saveFileItem";
            this.saveFileItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileItem.Size = new System.Drawing.Size(349, 34);
            this.saveFileItem.Text = "Lưu nội dung văn bản";
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(349, 34);
            this.exitItem.Text = "Thoát";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontComboBox,
            this.sizeComboBox,
            this.boldButton,
            this.italicButton,
            this.underlineButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 33);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 34);
            this.toolStrip.TabIndex = 1;
            // 
            // fontComboBox
            // 
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 34);
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(75, 34);
            // 
            // boldButton
            // 
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(34, 29);
            this.boldButton.Text = "B";
            // 
            // italicButton
            // 
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(34, 29);
            this.italicButton.Text = "I";
            // 
            // underlineButton
            // 
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(34, 29);
            this.underlineButton.Text = "U";
            // 
            // formatMenu
            // 
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(32, 19);
            this.formatMenu.Text = "Định dạng";
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 67);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 383);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.địnhDạngToolStripMenuItem.Text = "Định dạng";
            // 
            // frm_SoanThao
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Name = "frm_SoanThao";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.frm_SoanThao_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.IContainer component = null;
        private System.Windows.Forms.MenuStrip menuStrip;               // Thanh menu
        private System.Windows.Forms.ToolStrip toolStrip;               // Thanh công cụ
        private System.Windows.Forms.ToolStripMenuItem systemMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenu; // Menu "Hệ thống"
        private System.Windows.Forms.ToolStripMenuItem newFileItem;     // Menu item "Tạo văn bản mới"
        private System.Windows.Forms.ToolStripMenuItem openFileItem;    // Menu item "Mở tập tin"
        private System.Windows.Forms.ToolStripMenuItem saveFileItem;    // Menu item "Lưu văn bản"
        private System.Windows.Forms.ToolStripMenuItem exitItem;        // Menu item "Thoát"
        private System.Windows.Forms.ToolStripComboBox fontComboBox;    // Hộp chọn font chữ
        private System.Windows.Forms.ToolStripComboBox sizeComboBox;    // Hộp chọn kích thước chữ
        private System.Windows.Forms.ToolStripButton boldButton;        // Nút in đậm
        private System.Windows.Forms.ToolStripButton italicButton;      // Nút in nghiêng
        private System.Windows.Forms.ToolStripButton underlineButton;   // Nút gạch chân
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
    }
}