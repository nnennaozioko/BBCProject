using BBCProject.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObjects
{
    public class MenuPage
    {
        public IWebDriver driver;

        public MenuPage()
        {

            driver = BaseTest.driver;
        }

        private By menuItem(string menuItem) { return By.XPath($"//span[contains(@class,'ssrcss')][normalize-space(text())='{menuItem}']"); }
        private By homePage = By.XPath("//*[@id=\"header-content\"]/div[2]/div/div/div/div");
        private By newsPage = By.XPath("//*[@id=\"brand\"]");
        private By sportPage = By.XPath("//*[@id=\"header-content\"]/div[2]/div/div/div/a");
        private By weatherPage = By.XPath("//*[@id=\"site-container\"]/div[2]/div/div/div[1]/a");
        private By iplayerPage = By.XPath("//*[@id=\"main\"]/nav/div/div[2]/div/a");
        private By soundsPage = By.XPath("//*[@id=\"main\"]/div/div/nav/div/div");
        private By bitesizePage = By.XPath("//*[@id=\"u5552798595531092\"]/div/div[2]/header/div/span/a");

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public void ClickMenuItem(string menu)
        {
            driver.FindElement(menuItem(menu)).Click();
        }

        //public bool LandingPageShouldDisplayed(string menuItem)
        //{
        //    //string result = "pageHeader";

        //    if(menuItem == "HOME")
        //    {
        //        return driver.FindElement(homePage).Displayed;
        //    }
        //    else if (menuItem == "News")
        //    {
        //        return driver.FindElement(newsPage).Displayed;

        //    }
        //    else if (menuItem == "Sport")
        //    {
        //        return driver.FindElement(sportPage).Displayed;
        //    }
        //    else if (menuItem == "Weather")
        //    {
        //        return driver.FindElement(weatherPage).Displayed;
        //    }
        //    else if(menuItem == "iPlayer")
        //    {
        //        return driver.FindElement(iplayerPage).Displayed;
        //    }
        //    else if(menuItem == "Sounds")
        //    {
        //        return driver.FindElement(iplayerPage).Displayed;
        //    }

        //    else
        //    {
        //        return driver.FindElement(bitesizePage).Displayed;
        //    }

        //    //return true;
        //    //return driver.FindElement(homePage).Displayed;
        //    // return driver.Url.Contains("co.uk");


        //}
        public bool LandingPageShouldDisplayed()
        {
            return driver.FindElement(homePage).Displayed;
        }
        public bool NewsPageShouldDisplayed()
        {
            return driver.FindElement(newsPage).Displayed;

        }

        public bool SportPageShouldDisplayed()
        {
            return driver.FindElement(sportPage).Displayed;

        }


        public bool WeatherPageShouldDisplayed()
        {
            return driver.FindElement(weatherPage).Displayed;

        }

        public bool IPlayerPageShouldDisplayed()
        {
            return driver.FindElement(iplayerPage).Displayed;

        }

        public bool SoundsPageShouldDisplayed()
        {
            return driver.FindElement(soundsPage).Displayed;

        }

        public bool BitesizePageShouldDisplayed()
        {
            return driver.FindElement(bitesizePage).Displayed;

        }










        // public bool


        //public void ClickOnFeaturesItem(string menuItem)
        //{

        //    switch (menuItem)
        //    {
        //        case "Home":
        //            driver.FindElement(home).Click();
        //            break;
        //        case "News":
        //            driver.FindElement(news).Click();
        //            break;
        //        case "Sport":
        //            driver.FindElement(sports).Click();
        //            break;
        //        case "Weather":
        //            driver.FindElement(weather).Click();
        //            break;
        //        case "iPlayer":
        //            driver.FindElement(iPlayer).Click();
        //            break;
        //        case "Sounds":
        //            driver.FindElement(sounds).Click();
        //            break;
        //        case "Bitesize":
        //            driver.FindElement(bitesize).Click();
        //            break;
        //        default:
        //            throw new Exception();


        //    }







    }
}