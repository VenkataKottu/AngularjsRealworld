using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AngularjsRealworld.Utils
{
    public class SharedwebDriver : EventFiringWebDriver
    {
        public static IWebDriver driver { get; set; }
        public static string url { get; set; }
        public SharedwebDriver () : base(driver)
        {
            Initialize();
        }

        public static void Initialize()
        {
            try
            {
                var browser = ConfigurationManager.AppSettings.Get("browser");
                url = ConfigurationManager.AppSettings.Get("produrl");
            }
            catch (Exception e)
            {
                e.StackTrace.ToString();
            }
        }
    }
}
