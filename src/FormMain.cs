using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class FormMain : Form
    {
        private readonly ChromiumWebBrowser m_Grammarly;
        private readonly ChromiumWebBrowser m_Translate;

        public FormMain()
        {
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;

            m_Grammarly = new ChromiumWebBrowser("https://app.grammarly.com/ddocs/817940203");
            splitContainer1.Panel1.Controls.Add(m_Grammarly);

            m_Translate = new ChromiumWebBrowser("https://translate.google.com.vn/?hl=en&tab=rT&authuser=0#view=home&op=translate&sl=en&tl=vi&text=fortunately");
            splitContainer1.Panel2.Controls.Add(m_Translate);


            this.Shown += (se, ev) => {
                this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            };
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

    }
}
