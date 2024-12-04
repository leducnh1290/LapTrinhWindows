using System;
using System.Drawing;
using System.Windows.Forms;

namespace LapTrinhWindows.Buoi5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            CreateUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Tạo giao diện
            CreateUI();
        }

        private void CreateUI()
        {
            // Tạo MenuStrip
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem systemMenu = new ToolStripMenuItem("Hệ thống");
            ToolStripMenuItem formatMenu = new ToolStripMenuItem("Định dạng");
            menuStrip.Items.Add(systemMenu);
            menuStrip.Items.Add(formatMenu);
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;

            // Tạo ToolStrip
            ToolStrip toolStrip = new ToolStrip();
            ToolStripComboBox fontComboBox = new ToolStripComboBox();
            fontComboBox.Items.AddRange(new string[] { "Arial", "Tahoma", "Verdana" });
            fontComboBox.SelectedIndexChanged += (s, e) => ChangeFont(fontComboBox.Text);

            ToolStripComboBox sizeComboBox = new ToolStripComboBox();
            sizeComboBox.Items.AddRange(new string[] { "10", "12", "14", "16", "18", "20" });
            sizeComboBox.SelectedIndexChanged += (s, e) => ChangeFontSize(Convert.ToInt32(sizeComboBox.Text));

            ToolStripButton boldButton = new ToolStripButton("B");
            boldButton.Click += (s, e) => ToggleBold();

            ToolStripButton italicButton = new ToolStripButton("I");
            italicButton.Click += (s, e) => ToggleItalic();

            ToolStripButton underlineButton = new ToolStripButton("U");
            underlineButton.Click += (s, e) => ToggleUnderline();

            toolStrip.Items.Add(fontComboBox);
            toolStrip.Items.Add(sizeComboBox);
            toolStrip.Items.Add(boldButton);
            toolStrip.Items.Add(italicButton);
            toolStrip.Items.Add(underlineButton);
            this.Controls.Add(toolStrip);

            // Tạo RichTextBox
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            this.Controls.Add(richTextBox);

            // Lưu RichTextBox vào thuộc tính
            this.richTextBox = richTextBox;
        }

        private RichTextBox richTextBox;

        private void ChangeFont(string fontName)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                Font newFont = new Font(fontName, currentFont.Size, currentFont.Style);
                richTextBox.SelectionFont = newFont;
            }
        }

        private void ChangeFontSize(int fontSize)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                Font newFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
                richTextBox.SelectionFont = newFont;
            }
        }

        private void ToggleBold()
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void ToggleItalic()
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void ToggleUnderline()
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }
    }
}
