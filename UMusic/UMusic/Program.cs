﻿using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMusic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var settings = new CefSettings()
            {
                //By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
                CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache")
            };

            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
