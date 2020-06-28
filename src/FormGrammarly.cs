using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public class FormGrammarly: Form
    {
        private readonly ChromiumWebBrowser m_browser;
        private readonly ToolStripContainer m_container;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Name = "FormGrammarly";
            this.ResumeLayout(false);
        }

        public FormGrammarly() {
            InitializeComponent();

            m_container = new ToolStripContainer() { Dock = DockStyle.Fill };
            this.Controls.Add(m_container);

            m_browser = new ChromiumWebBrowser("https://app.grammarly.com/ddocs/817940203");
            m_container.ContentPanel.Controls.Add(m_browser);

            this.Shown += (se, ev) => {
                this.Top = 0;
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width; 
            };
        }

    }
}
