using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace facebookStatusUpdate.Pages
{
    class HomePage
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Page")]
        [CacheLookup]
        public IWebElement Stories{ get; set; }

        public void ClickStories()
        {
            Stories.Click();
        }
    }
}
