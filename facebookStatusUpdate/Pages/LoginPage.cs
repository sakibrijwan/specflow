using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace facebookStatusUpdate.Pages
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "pass")]
        [CacheLookup]
        public IWebElement Password { get; set; }


        [FindsBy(How = How.Id, Using = "loginbutton")]
        [CacheLookup]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "_4-u2 _1-ib _2tyk _20os _4-u8")]
        [CacheLookup]
        public IWebElement BirthdayBox { get; set; }
        

        public void InputUserName(string u0)
        {
            Email.SendKeys(u0);
        }

        public void InputPassword(string p0)
        {
            Password.SendKeys(p0);
        }

        public void ClickSignInButton()
        {
            LoginButton.Click();
        }

        public void SetBirthdayMessage()
        {
            BirthdayBox.Click();
                //SendKeys("Heepy Birthday! :)");
        }


        //public void SignIn()
        //{
        //    InputUserName();
        //    InputPassword();
        //    ClickSignInButton();
        //    if (BirthdayBox.Displayed)
        //    {
        //        SetBirthdayMessage();
        //    }


        //}

    }


}
