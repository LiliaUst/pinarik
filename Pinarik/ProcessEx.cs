using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Pinarik
{
    internal sealed class ProcessEx
    {
        public static void SetIE9KeyforWebBrowserControl(string appName)
        {
            RegistryKey Regkey = null;
            try
            {

                //For 64 bit Machine 
                if (Environment.Is64BitOperatingSystem)
                    Regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                else  //For 32 bit Machine 
                    Regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);

                //If the path is not correct or 
                //If user't have priviledges to access registry 
                if (Regkey == null)
                {
                    throw new Exception("Application Settings Failed - Address Not found");
                }

                string FindAppkey = Convert.ToString(Regkey.GetValue(appName));

                //Check if key is already present 
                if (FindAppkey == "9000")
                {
                    Regkey.Close();
                    return;
                }

                //If key is not present add the key , Kev value 8000-Decimal 
                if (string.IsNullOrEmpty(FindAppkey))
                    Regkey.SetValue(appName, unchecked((int)0x2328), RegistryValueKind.DWord);

                //check for the key after adding 
                FindAppkey = Convert.ToString(Regkey.GetValue(appName));

                if (FindAppkey != "9000")
                    throw new Exception("Application Settings Failed, Ref: " + FindAppkey);
            }
            catch (Exception ex)
            {
                throw new Exception("Application Settings Failed. " + ex.Message);
            }
            finally
            {
                //Close the Registry 
                if (Regkey != null)
                    Regkey.Close();
            }
        }

    }
}
