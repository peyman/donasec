using System;
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
            // Get the URI and browser path
            string uri = textBoxLink.Text;
            string browser_path = comboBoxBrowsers.SelectedValue.ToString();

            // Update user prefered browser
            if (Properties.Settings.Default["DefaultBrowser"].ToString() != comboBoxBrowsers.Text)
            {
                Properties.Settings.Default["DefaultBrowser"] = comboBoxBrowsers.Text;
                Properties.Settings.Default.Save();
            }

            // Launch the browser
            if (comboBoxBrowsers.Text == "Open with MS-Edge")    // MS-EDGE case
            {
                Process.Start("microsoft-edge:" + uri);
            }
            else        // All other browsers
            {
                ProcessStartInfo launcher = new ProcessStartInfo()
                {
                    FileName = browser_path,
                    Arguments = uri
                };
                Process.Start(launcher);
            }

            // Finish
            Close();
        }
    }
}
