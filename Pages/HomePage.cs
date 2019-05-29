using AngularjsRealworld.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularjsRealworld.Pages
{
    public class HomePage
    {
        public static IWebDriver _driver;

        public static new IWebDriver driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }

        public HomePage()
        {
            _driver = SharedwebDriver.driver;
            PageFactory.InitElements(_driver, typeof(Support));
        }

        public void click(string element)
        {
            for(int i=0; i<=1; i++)
            {
                if (Support.element_exists(element))
                {
                    _driver.FindElement(By.XPath(element)).Click();
                }
                else
                {
                    break;
                }
            }
        
        }
    }
}
