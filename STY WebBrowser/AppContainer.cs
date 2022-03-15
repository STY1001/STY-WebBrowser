using EasyTabs;
using System;

namespace STY_WebBrowser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            //InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);

        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Main
                {
                    Text = "New Tab"
                }
            };
        }
    }
}
