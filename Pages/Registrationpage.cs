using AngularjsRealworld.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularjsRealworld.Pages
{
    class Registrationpage
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

        public Registrationpage()
        {
            _driver = SharedwebDriver.driver;
            PageFactory.InitElements(_driver, typeof(Support));
        }

        public void EnterUserName()
        {
            Support.wait_for_element_exists(ObjectRpository.accountName);
            _driver.FindElement(By.XPath(ObjectRpository.accountName)).SendKeys(ConfigurationManager.AppSettings.Get("UserName"));

        }

        public void EnterEmail()
        {
            Support.wait_for_element_exists(ObjectRpository.email);
            _driver.FindElement(By.XPath(ObjectRpository.email)).SendKeys(ConfigurationManager.AppSettings.Get("Email"));
        }

        public void EnterPassword()
        {
            Support.wait_for_element_exists(ObjectRpository.password);
            _driver.FindElement(By.XPath(ObjectRpository.password)).SendKeys(ConfigurationManager.AppSettings.Get("Password"));
        }

        public void submitSignup()
        {
            _driver.FindElement(By.XPath(ObjectRpository.signupButton)).Click();
        }
    }
}
