using BBCProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObjects
{
    class RegistrationPage
    {
        public IWebDriver driver;

        public RegistrationPage()
        {
            driver = BaseTest.driver;
        }

        private By signIn = By.XPath("//*[@id=\"header-content\"]/nav/div[1]/div/div[2]/ul[1]/li[1]/a/span[2]");
        private By registerNow = By.XPath("//*[@id=\"signin-page\"]/div[2]/div/div[2]/a/span");
        private By thirteenOrOver = By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[3]/div[2]/fieldset/div[1]/a[2]/span");
        private By day = By.Id("day-input");
        private By month = By.Id("month-input");
        private By year = By.Id("year-input");
        private By continueButton = By.Id("submit-button");
        private By emailAddress = By.XPath("//*[@id=\"user-identifier-input\"]");
        private By password = By.Id("password-input");
        private By postcode = By.Id("postcode-input");
        private By selectGender = By.XPath("//*[@id=\"gender-input\"]");
        private By registerButton = By.Id("submit-button");
        private By successfullMessageDisplayed = By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/h1/span");

        public void SignIn()
        {
            driver.FindElement(signIn).Click();
        }

        public void RegisterNow()
        {
            driver.FindElement(registerNow).Click();
        }

        public void ThirteenOrOver()
        {
            //Thread.Sleep(5000);
            driver.FindElement(thirteenOrOver).Click();
        }

        public void Day(string daytxt)
        {
            //Thread.Sleep(5000);
            driver.FindElement(day).SendKeys(daytxt);
        }

        public void Month(string monthtxt)
        {
            driver.FindElement(month).SendKeys(monthtxt);
        }

        public void Year(string yeartxt)
        {
            driver.FindElement(year).SendKeys(yeartxt);
        }

        public void ContinueButton()
        {
            driver.FindElement(continueButton).Click();
        }

        public void EmailAddress(string emailtxt)
        {
            driver.FindElement(emailAddress).SendKeys(emailtxt);
        }

        public void Password(string passwordtxt)
        {
            driver.FindElement(password).SendKeys(passwordtxt);
        }
        
        public void Postcode(string postcodetxt)
        {
            driver.FindElement(postcode).SendKeys(postcodetxt);
        }

        public void SelectGender()
        {
            SelectElement select = new SelectElement(driver.FindElement(selectGender));
            select.SelectByValue("female");
        }
            
        public void RegisterButton()
        {
            driver.FindElement(registerButton).Click();
        }

        public bool SuccessfulMessageDisplayed()
        {
            return driver.FindElement(successfullMessageDisplayed).Displayed;        }






    }
}
