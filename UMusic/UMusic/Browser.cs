﻿using CefSharp;
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

namespace UMusic
{
    public partial class Browser : Form
    {
        public string url;

        public Browser(string url)
        {
            InitializeComponent();

            WebBrowser.Url = new Uri(url);
        }

        private void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            AddressBar.Text = WebBrowser.Url.ToString();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

            url = WebBrowser.Url.ToString();

            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            WebBrowser.Url = new Uri(AddressBar.Text);
        }
    }
}
