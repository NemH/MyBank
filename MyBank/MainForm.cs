using MyBank.Repository;
using MyBank.User_View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyBank
{
    internal class MainForm : Form
    {
        public static MainForm instance;

        public static MainForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new MainForm();
                }

                return instance;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }
        public void SetContent(UserControl content)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(content);
            content.Dock = DockStyle.Fill;
            content.Show();
        }

        private void InitializeComponent()
        {
            panelContent = new Panel();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.Location = new Point(12, 12);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1240, 657);
            panelContent.TabIndex = 0;
            // 
            // MainForm
            // 
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelContent);
            Name = "MainForm";
            Text = "MyBank";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
        }

        private Panel panelContent;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserRepository.GetInstance().Save();
            DepositeTypeRepository.GetInstance().Save();
        }
    }
}