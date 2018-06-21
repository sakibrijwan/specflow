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

        [Given(@"Hit the URL")]
        public void GivenHitTheURL()
        {
            driver.Url = "http://www.facebook.com";
        }


        [Given(@"I have entered userame (.*)")]
        public void GivenIHaveEnteredUserame(string u0)
        {
            
            login.InputUserName(u0);
        }

        [Given(@"I have entered password (.*)")]
        public void GivenIHaveEnteredPassword(string p0)
        {
            login.InputPassword(p0);
        }


        //[Given(@"I have entered userame '(.*)'")]
        //public void GivenIHaveEntered(string u0)
        //{
        //    driver.Url = "http://www.facebook.com";

        //    login.InputUserName(u0);
        //}

        //[Given(@"I have entered password '(.*)'")]
        //public void GivenIHaveEnteredPassword(string p0)
        //{
        //    login.InputPassword(p0);
        //}
     
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
