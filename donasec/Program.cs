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
                    ;
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
            else   // Run mode - proceed if args[0] is a URI and discard the other args
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
