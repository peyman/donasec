﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace donasec
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            string uri = textBoxLink.Text;
            string browser_path = comboBoxBrowsers.SelectedValue.ToString();

            ProcessStartInfo launcher = new ProcessStartInfo()
            {
                FileName = browser_path,
                Arguments = uri
            };
            Process.Start(launcher);

            Close();
        }
    }
}