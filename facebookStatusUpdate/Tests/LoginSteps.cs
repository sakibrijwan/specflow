using System;
using System.Security.Cryptography.X509Certificates;
using facebookStatusUpdate.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace facebookStatusUpdate
{
    [Binding]
    public class LoginSteps
    {
        //private IWebDriver driver=null;
        static IWebDriver  driver = new ChromeDriver();

        LoginPage login = new LoginPage(driver);
        [Given(@"I have entered username")]
        public void GivenIHaveEnteredUsername()
        {
            
            driver.Url="http://www.facebook.com";
            
            login.InputUserName();
        }
        
        [Given(@"I have entered password")]
        public void GivenIHaveEnteredPassword()
        {
           login.InputPassword();
        }
        
        [When(@"I press Login button")]
        public void WhenIPressLoginButton()
        {
            login.ClickSignInButton();
        }
        
        [Then(@"the home page appears")]
        public void ThenTheHomePageAppears()
        {
            driver.Quit();
        }
    }
}
