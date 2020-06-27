
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class BrowserForm : Form
    {
        private readonly ChromiumWebBrowser m_browserSkype;
        private readonly ChromiumWebBrowser m_browserTranslate;
        private readonly ChromiumWebBrowser m_browserFBMessager;

        public BrowserForm()
        {
            InitializeComponent();

            Text = "CefSharp";
            WindowState = FormWindowState.Maximized;

            m_browserSkype = new ChromiumWebBrowser("https://web.skype.com/");
            toolStripContainer.ContentPanel.Controls.Add(m_browserSkype);

            m_browserFBMessager = new ChromiumWebBrowser("https://www.facebook.com/messages");
            toolStripContainer.ContentPanel.Controls.Add(m_browserFBMessager);

            m_browserTranslate = new ChromiumWebBrowser("https://translate.google.com.vn/?hl=en&tab=rT&authuser=0#view=home&op=translate&sl=en&tl=vi&text=fortunately");
            toolStripContainer.ContentPanel.Controls.Add(m_browserTranslate);

            m_browserSkype.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
            m_browserSkype.LoadingStateChanged += OnLoadingStateChanged;
            m_browserSkype.ConsoleMessage += OnBrowserConsoleMessage;
            m_browserSkype.StatusMessage += OnBrowserStatusMessage;
            m_browserSkype.TitleChanged += OnBrowserTitleChanged;
            m_browserSkype.AddressChanged += OnBrowserAddressChanged;

            var version = string.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}",
               Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion);

            var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var environment = String.Format("Environment: {0}", bitness);

            DisplayOutput(string.Format("{0}, {1}", version, environment));
        }

        private void OnIsBrowserInitializedChanged(object sender, EventArgs e)
        {
            var b = ((ChromiumWebBrowser)sender);

            this.InvokeOnUiThreadIfRequired(() => b.Focus());
        }

        private void OnBrowserConsoleMessage(object sender, ConsoleMessageEventArgs args)
        {
            DisplayOutput(string.Format("Line: {0}, Source: {1}, Message: {2}", args.Line, args.Source, args.Message));
        }

        private void OnBrowserStatusMessage(object sender, StatusMessageEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => statusLabel.Text = args.Value);
        }

        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            SetCanGoBack(args.CanGoBack);
            SetCanGoForward(args.CanGoForward);

            this.InvokeOnUiThreadIfRequired(() => SetIsLoading(!args.CanReload));
        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = args.Title);
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => urlTextBox.Text = args.Address);
        }

        private void SetCanGoBack(bool canGoBack)
        {
            this.InvokeOnUiThreadIfRequired(() => backButton.Enabled = canGoBack);
        }

        private void SetCanGoForward(bool canGoForward)
        {
            this.InvokeOnUiThreadIfRequired(() => forwardButton.Enabled = canGoForward);
        }

        private void SetIsLoading(bool isLoading)
        {
            goButton.Text = isLoading ? "Stop" : "Go";
            goButton.Image = isLoading ? Properties.Resources.nav_plain_red : Properties.Resources.nav_plain_green;
            HandleToolStripLayout();
        }

        public void DisplayOutput(string output)
        {
            this.InvokeOnUiThreadIfRequired(() => outputLabel.Text = output);
        }

        private void HandleToolStripLayout(object sender, LayoutEventArgs e)
        {
            HandleToolStripLayout();
        }

        private void HandleToolStripLayout()
        {
            var width = toolStrip1.Width;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item != urlTextBox)
                {
                    width -= item.Width - item.Margin.Horizontal;
                }
            }
            urlTextBox.Width = Math.Max(0, width - urlTextBox.Margin.Horizontal - 18);
        }

        private void ExitMenuItemClick(object sender, EventArgs e)
        {
            m_browserSkype.Dispose();
            Cef.Shutdown();
            Close();
        }

        private void GoButtonClick(object sender, EventArgs e)
        {
            LoadUrl(urlTextBox.Text);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            m_browserSkype.Back();
        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            m_browserSkype.Forward();
        }

        private void UrlTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            LoadUrl(urlTextBox.Text);
        }

        private void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                m_browserSkype.Load(url);
            }
        }

        private void ShowDevToolsMenuItemClick(object sender, EventArgs e)
        {
            m_browserSkype.ShowDevTools();
        }

        private void btnGoogleTranslate_Click(object sender, EventArgs e)
        {
            m_browserSkype.Visible = false;
            btnGoSkype.Checked = m_browserSkype.Visible;
            m_browserTranslate.Visible = true;
            btnGoogleTranslate.Checked = m_browserTranslate.Visible;
        }

        private void btnGoSkype_Click(object sender, EventArgs e)
        {
            m_browserSkype.Visible = true;
            btnGoSkype.Checked = m_browserSkype.Visible;
            m_browserTranslate.Visible = false;
            btnGoogleTranslate.Checked = m_browserTranslate.Visible;
        }

        private void btnShowDevTools_Click(object sender, EventArgs e)
        {
            m_browserSkype.ShowDevTools();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            m_browserSkype.Dispose();
            Cef.Shutdown();
            Close();
        }

        private void btnFBMessager_Click(object sender, EventArgs e)
        {

        }
    }
}
