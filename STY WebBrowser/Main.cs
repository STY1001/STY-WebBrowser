using CefSharp;
using CefSharp.WinForms;
using EasyTabs;
using System;
using System.Windows.Forms;
namespace STY_WebBrowser
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            InitializeChromium();
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }


        public ChromiumWebBrowser chromeBrowser;


        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            if (!Cef.IsInitialized)
            {
                Cef.Initialize(settings);
            }
            chromeBrowser = new ChromiumWebBrowser("https://google.com");
            browserpanel.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;
            
        }

        private void ChromeBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                loadingimg.Visible = e.IsLoading;
                stopbtn.Visible = e.IsLoading;
                urlbox.Text = chromeBrowser.Address;
                secimg.Image = chromeBrowser.Address.StartsWith("https") ? seclist.Images[0] : seclist.Images[1];
            });

        }

        private void urlbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadUrl(urlbox.Text.Trim());
            }
        }

        void LoadUrl(string url)
        {
            if (url.Contains("."))
            {
                chromeBrowser.Load(url);
            }
            else
            {
                chromeBrowser.Load($"https://www.google.com/search?q={url}");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoBack)
            {
                chromeBrowser.Back();
            }
        }

        private void forbtn_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoForward)
            {
                chromeBrowser.Forward();
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://www.google.com/");
        }

        private void ChromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                this.FindForm().Text = e.Title;
            });
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            chromeBrowser.Stop();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            About afrm = new About();
            afrm.Show();
        }
    }
}
