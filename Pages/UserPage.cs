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
    class UserPage
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

        public UserPage()
        {
            _driver = SharedwebDriver.driver;
            PageFactory.InitElements(_driver, typeof(Support));
        }

        public void CheckUserName()
        {
            _driver.FindElement(By.XPath(ObjectRpository.accountName));
            Support.wait_for_element_exists(ObjectRpository.accountName);
        }
    }
}
