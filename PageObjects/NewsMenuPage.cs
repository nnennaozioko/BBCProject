using AngleSharp.Dom;
using BBCProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BBCProject.PageObjects
{
    public class NewsMenuPage
    {
        public IWebDriver driver;

        public NewsMenuPage() 
        {
            driver = BaseTest.driver;
        }



        private By newsMenu = By.XPath("//*[@id=\"header-content\"]/nav/div[1]/div/div[2]/ul[2]/li[2]/a/span");
        private By newsMenuItem(string newsMenuItem) { return By.XPath($"//span[contains(@class,'ssrcss')][normalize-space(text())='{newsMenuItem}']"); }
        private By newsMenuButtonsDisplayed = By.XPath("");
        private By homeNewsPage = By.XPath("");
        private By costOfLivingNewsPage = By.Id("main-heading");
        private By warInUkraineNewsPage = By.XPath("");
        private By climateNewsPage = By.XPath("");
        private By ukNewsPage = By.XPath("");
        private By worldNewsPage = By.XPath("");
        private By businessNewsPage = By.XPath("");
        private By politicsNewsPage = By.XPath("");
        private By cultureNewsPage = By.XPath("");
        private By scienceNewsPage = By.XPath("");
        private By healthNewsPage = By.XPath("");
        private By familyAndEducationNewsPage = By.XPath("");
        private By inPicturesNewsPage = By.XPath("");
        private By moreDropdownNewsPage = By.XPath("");
        private By newsbeatNewsPage = By.XPath("");
        private By realityCheckNewsPage = By.XPath("");
        private By disabilityNewsPage = By.XPath("");
        
        public void NewsMenu()
        {
             driver.FindElement(newsMenu).Click();
        }

        public bool NewsMenuButtonsDisplayed()
        {
            return driver.FindElement(newsMenuButtonsDisplayed).Displayed;
        }

        public bool HomeNewsPageShouldDisplayed()
        {
            return driver.FindElement(homeNewsPage).Displayed;
        }

        public bool CostOfLivingNewsPageShouldDisplayed()
        {
           return driver.FindElement(costOfLivingNewsPage).Displayed;
        }

        public bool WarInUkraineShouldDisplayed()
        {
            return driver.FindElement(warInUkraineNewsPage).Displayed;
        }

        public bool ClimateShouldDisplayed()
        {
            return driver.FindElement(climateNewsPage).Displayed;
        }

        public bool UkShouldDisplayed()
        {
            return driver.FindElement(ukNewsPage).Displayed;
        }

        public bool WorldShoulddisplayed()
        {
           return driver.FindElement(worldNewsPage).Displayed;

        }
        public bool BusinessShouldDisplayed()
        {
           return driver.FindElement(businessNewsPage).Displayed;
        }

        public bool PoliticsShouldDisplayed()

        {
           return driver.FindElement(politicsNewsPage).Displayed;
        }
        public bool CultureShouldDisplayed()

        {
           return driver.FindElement(cultureNewsPage).Displayed;
        } 
        
        public bool ScienceShouldDisplayed()

        {
           return driver.FindElement(scienceNewsPage).Displayed;
        }
        
        public bool HealthShouldDisplayed()

        {
             return driver.FindElement(healthNewsPage).Displayed;
        }

        public bool FamilyAndEducationShouldDisplayed()

        {
           return driver.FindElement(familyAndEducationNewsPage).Displayed;
        }
        
        public bool InPictureShouldDisplayed()

        {
           return driver.FindElement(inPicturesNewsPage).Displayed;
        }
        
        public bool MoreDropdownShouldDisplayed()

        {
           return driver.FindElement(moreDropdownNewsPage).Displayed;
        }
        
                
        public bool NewsbeatShouldDisplayed()

        {
           return driver.FindElement(newsbeatNewsPage).Displayed;
        }
        
        public bool RealityCheckShouldDisplayed()

        {
           return driver.FindElement(realityCheckNewsPage).Displayed;
        }
        public bool DisabiltyShouldDisplayed()

        {
           return driver.FindElement(disabilityNewsPage).Displayed;
        }


       




    }
}
