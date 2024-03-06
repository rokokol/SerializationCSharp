﻿using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace SerializationCSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Application.Run(new MainForm());
        }
    }
}