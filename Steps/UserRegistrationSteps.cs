using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using AngularjsRealworld.Utils;
using AngularjsRealworld.Pages;
using NUnit.Framework;

namespace AngularjsRealworld.Steps
{
    [Binding]
    public class UserRegistrationSteps
    {
        public IWebDriver driver { get; set; }
        HomePage homePage = new HomePage();
        Registrationpage registrationPage = new Registrationpage();
        UserPage userPage = new UserPage();

        [Given(@"I have new user details")]
        public void GivenIHaveNewUserDetails()
        {
            driver = SharedwebDriver.driver;
            driver.Navigate().GoToUrl(SharedwebDriver.url);
        }
        
        [Given(@"I have not logged in")]
        public void GivenIHaveNotLoggedIn()
        {
            homePage.click(ObjectRpository.signuppageButton);
        }
        
        [When(@"I complete the sign up form")]
        public void WhenICompleteTheSignUpForm()
        {
            registrationPage.EnterUserName();
            registrationPage.EnterEmail();
            registrationPage.EnterPassword();
            registrationPage.submitSignup();
               
        }
                
        [Then(@"my username must be displayed")]
        public void ThenMyUsernameMustBeDisplayed()
        {
            userPage.CheckUserName();
        }
    }
}
