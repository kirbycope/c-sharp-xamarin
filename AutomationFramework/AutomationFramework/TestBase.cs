using System.Collections.Generic;
using System.Configuration;
using Xamarin.UITest;

namespace AutomationFramework
{
    public class TestBase
    {
        protected static string deviceSerials;
        protected static string path = ConfigurationManager.AppSettings["path"];
        
        /// <summary>
        /// Sets up the App on the appropriate device
        /// </summary>
        /// <param name="deviceId">The Device Serial to install the app</param>
        public void Setup(string deviceSerial)
        {
            App.app = ConfigureApp
                .Android
                .DeviceSerial(deviceSerial)
                .ApkFile(path)
                .StartApp();
        }
        
        /// <summary>
        /// Gets each Device Serial from the App.config
        /// </summary>
        /// <returns>Each Device Serial from the App.config</returns>
        public static IEnumerable<string> GetDevices()
        {
            // Get BaseUrl from App.config
            if (deviceSerials == null)
            {
                deviceSerials = ConfigurationManager.AppSettings["deviceSerials"];
            }
            // Split the list of devices
            string[] deviceSerialsArray = deviceSerials.Split(',');
            // Return each browser
            foreach (string deviceSerial in deviceSerialsArray)
            {
                yield return deviceSerial;
            }
        }
    }
}
