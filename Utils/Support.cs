using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AngularjsRealworld.Utils
{
    public class Support
    {
        static string browser = ConfigurationManager.AppSettings.Get("browser");

        public static void wait_for_element_exists(string obj)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(SharedwebDriver.driver, TimeSpan.FromSeconds(10));

                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(obj)));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("element not present on the page");
            }
            catch (TimeoutException)
            {
                Console.WriteLine("element not present on the page");
            }
        }

        public static bool element_exists(string element)
        {
            try
            {
                Thread.Sleep(3000);
                SharedwebDriver.driver.FindElement(By.XPath(element));
                return true;
            }
            catch(Exception e)
            {
                string msg = e.Message;
                return false;

            }
        }
    }
}
