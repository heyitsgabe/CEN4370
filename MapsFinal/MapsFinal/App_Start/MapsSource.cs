using System.Web.Http;
using DotNetBrowser;
using DotNetBrowser.WinForms;
using System;
using System.Windows.Forms;

namespace MapsFinal
{
    public partial class MapsForm: MapsForm {
        private BrowserView browserview;

        public MainForm() {
            InitializeComponent();
            browserview = new WinFormsBrowserView();
            this.controls.Add((control)browserview.GetComponent());
            browserview.Browser.LoadURL("http://maps.google.com");
        }
    }
}
