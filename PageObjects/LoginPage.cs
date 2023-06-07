using BBCProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObjects
{
    class LoginPage
    {
        public IWebDriver driver;

        public LoginPage()
        {
            driver = BaseTest.driver;
        }

        private By signInButton = By.XPath("//*[@id=\"submit-button\"]/span");
        private By messageDisplayed = By.XPath(".e19b3odl1>div>div> div>div");


        public void SignInButton()
        {
            driver.FindElement(signInButton).Click();
        }

        public bool MessageDisplayed()
        {
            Thread.Sleep(10000);
            return driver.FindElement(messageDisplayed).Displayed;
        }





    }
}
