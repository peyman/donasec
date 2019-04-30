using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace donasec
{
    static class Helper
    {
        // TODO: improved DB - just POC for now
        private static List<KeyValuePair<string, string>> sponsors =
            new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Donasec","donasec.com"),
                new KeyValuePair<string, string>("Donasec","www.donasec.com"),
                new KeyValuePair<string, string>("Paypal","www.paypal.com"),
                new KeyValuePair<string, string>("Paypal","paypal.com")
            };

        public static string getSponsor(string uri)
        {
            string result = "";
            KeyValuePair<string, string> sponsor = sponsors.SingleOrDefault(x => x.Value == uri);
            if (! String.IsNullOrEmpty(sponsor.Key))
            {
                result = sponsor.Key;
            }
            return result;
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

            // Add MS-EDGE manually
            browsers.Add(new KeyValuePair<string, string>("Open with MS-Edge", ""));

            return browsers;
        }
    }
}
