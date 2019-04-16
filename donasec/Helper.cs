using System;
using Microsoft.Win32;
using System.Security.Principal;
using System.Collections.Generic;
using System.ComponentModel;

namespace donasec
{
    static class Helper
    {
        public static bool IsCurrentUserElevated()
        {
            WindowsIdentity userIdentity = WindowsIdentity.GetCurrent();
            WindowsPrincipal user = new WindowsPrincipal(userIdentity);
            bool isUserAdmin = user.IsInRole(WindowsBuiltInRole.Administrator);
            return isUserAdmin;
        }

        public static void RegisterApplication()
        {
            // CLASSES_ROOT
            RegistryKey uriclass_key = Registry.ClassesRoot.OpenSubKey("Donasec", true);
            if (uriclass_key == null)
            {
                uriclass_key = Registry.ClassesRoot.CreateSubKey("Donasec", true);
            }

            uriclass_key.SetValue(string.Empty, "URL: Donasec, an anti-phishing tool.");

            RegistryKey icon_key = uriclass_key.OpenSubKey("DefaultIcon", true);
            if (icon_key == null)
            {
                icon_key = uriclass_key.CreateSubKey("DefaultIcon");
            }

            string exec_path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            icon_key.SetValue(string.Empty, exec_path + ",0");
            icon_key.Close();

            RegistryKey shellcmd_key = uriclass_key.OpenSubKey(@"shell\open\command", true);
            if (shellcmd_key == null)
            {
                shellcmd_key = uriclass_key.CreateSubKey(@"shell\open\command");
            }
            shellcmd_key.SetValue(string.Empty, exec_path + " \"%1\"");
            shellcmd_key.Close();

            uriclass_key.SetValue("URL Protocol", string.Empty);
            uriclass_key.Close();

            // LOCAL_MACHINE\SOFTWARE\CLIENTS
            RegistryKey software_key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Clients\Donasec", true);
            if (software_key == null)
            {
                software_key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Clients\Donasec", true);
            }

            RegistryKey capability_key = software_key.OpenSubKey("Capabilities", true);
            if (capability_key == null)
            {
                capability_key = software_key.CreateSubKey("Capabilities", true);
            }

            capability_key.SetValue("ApplicationDescription", "Helps reducing email phishing by giving a second change to the user.");
            capability_key.SetValue("ApplicationName", "Donasec");

            RegistryKey urlass_key = capability_key.OpenSubKey("UrlAssociations", true);
            if (urlass_key == null)
            {
                urlass_key = capability_key.CreateSubKey("UrlAssociations", true);
            }

            urlass_key.SetValue("http", "Donasec");
            urlass_key.SetValue("https", "Donasec");
            urlass_key.Close();

            capability_key.Close();
            software_key.Close();

            // LOCAL_MACHINE\SOFTWARE\REGISTEREDAPPLICATIONS
            RegistryKey registeredapps_key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\RegisteredApplications", true);
            registeredapps_key.SetValue("Donasec", @"SOFTWARE\Clients\Donasec\Capabilities");
            registeredapps_key.Close();
        }

        public static bool IsUri(string uristring)
        {
            try
            {
                Uri uri = new Uri(uristring);
                return uri.IsWellFormedOriginalString();
            }
            catch (System.UriFormatException)
            {
                return false;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public static bool IsHttpUri(string uri)
        {
            uri = uri.ToLower();
            return uri.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
                uri.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
        }

        public static BindingList<KeyValuePair<string, string>> ListOfInstalledBrowsers()
        {
            var browsers = new BindingList<KeyValuePair<string, string>>();

            RegistryKey registeredapps_key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Clients\StartMenuInternet", false);
            foreach (var key in registeredapps_key.GetSubKeyNames())
            {
                RegistryKey browser_key = registeredapps_key.OpenSubKey(key);
                if (browser_key != null)
                {
                    RegistryKey browser_command = browser_key.OpenSubKey(@"shell\open\command");
                    if (browser_command != null)
                    {
                        string browser_path = Convert.ToString(browser_command.GetValue(""));
                        browsers.Add(new KeyValuePair<string, string>("Open with " + key.ToString(), browser_path));
                    }
                }
            }

            return browsers;
        }
    }
}
