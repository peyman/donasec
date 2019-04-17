using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace donasec
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)   // Setup mode
            {
                if (Helper.IsCurrentUserElevated())     // Admin privileges, proceed with Install
                {
                    // Add the registry keys required
                    Helper.RegisterApplication();

                    // Trigger the first link to bring up the Win 10 default application pop-up
                    ProcessStartInfo launcher = new ProcessStartInfo()
                    {
                        FileName = "http://www.donasec.com/thank-you",
                        UseShellExecute = true
                    };
                    Process.Start(launcher);
                }
                else    // Not admin, raise privileges
                {
                    Process.Start(
                        new ProcessStartInfo()
                        {
                            FileName = System.Reflection.Assembly.GetExecutingAssembly().Location,
                            UseShellExecute = true,
                            Verb = "runas"
                        }
                    );
                }
            }
            else if (args[0] == "uninstall") // Uninstall mode, assumes elevated privilege
            {
                // Remove the registry keys
                Helper.DeregisterApplication();

                // Say godbye.
                ProcessStartInfo launcher = new ProcessStartInfo()
                {
                    FileName = "http://www.donasec.com/thank-you-uninstall",
                    UseShellExecute = true
                };
                Process.Start(launcher);
            }
            else   // Run mode - proceed if args[0] is a URI and discard the other args
            {
                string uri = args[0];
                if (Helper.IsUri(uri) && Helper.IsHttpUri(uri))  // Make sure we have an URI to pass to a browser
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    MainForm mainForm = new MainForm();

                    // Show the URI to the user
                    mainForm.textBoxLink.Text = uri;
                    mainForm.textBoxLink.SelectionStart = 0;

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
