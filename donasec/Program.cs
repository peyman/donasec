using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace donasec
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 0)
            { 
                string uri = args[0];
                if (Helper.IsUri(uri) && Helper.IsHttpUri(uri))  // Make sure we have an URI to pass to a browser
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    MainForm mainForm = new MainForm();

                    // Show the URI to the user
                    mainForm.textBoxLink.Text = uri.ToLower();
                    mainForm.textBoxLink.SelectionStart = 0;

                    // Is the URI an IDN? Let the user know
                    string uriIdnHost = (new Uri(uri)).IdnHost.ToLower();
                    string uriHost = (new Uri(uri)).Host.ToLower();
                    if (! uriIdnHost.Equals(uriHost))
                    {
                        mainForm.labelNote.Visible = true;
                        mainForm.labelNote.Text = "Warning: international domain name - domain is actually: " + uriIdnHost.ToLower();
                        mainForm.labelNote.SelectionStart = 0;
                        mainForm.labelNote.BackColor = mainForm.labelNote.BackColor;
                    }
                    
                    // Provide the list of installed browsers
                    var browsers = Helper.ListOfInstalledBrowsers();
                    mainForm.comboBoxBrowsers.DataSource = browsers;
                    mainForm.comboBoxBrowsers.ValueMember = "Value";
                    mainForm.comboBoxBrowsers.DisplayMember = "Key";

                    // Select user preference for browser
                    string default_browser = Properties.Settings.Default["DefaultBrowser"].ToString();
                    if (default_browser != "")
                    {
                        mainForm.comboBoxBrowsers.Text = default_browser;
                    }

                    // Select Abord button by default
                    mainForm.buttonAbort.Select();

                    Application.Run(mainForm);
                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
