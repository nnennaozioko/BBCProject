using BBCProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObjects
{
    internal class SearchButtonPage
    {
      public IWebDriver driver;

      public SearchButtonPage()
        {
            driver = BaseTest.driver;
        }

        private By searchBBCButton = By.CssSelector("div.ssrcss-1j3alh1-GlobalNavigationItem.e1gviwgp23 > a");
        private By foodAndDrink = By.CssSelector("#search-input");
        private By foodAndDrinkSeries= By.CssSelector(".enjd40x0 > div > div > ul > li:nth-child(1) > div > div > div.ssrcss-tq7xfh-PromoContent.e1f5wbog8 > div.ssrcss-1f3bvyz-Stack.e1y4nx260 > a");
        private By messageDisplayed= By.CssSelector(".map-grid__item > div > div > div > div > div.island > h2");
        private By episode = By.CssSelector("#br-nav-programme > ul:nth-child(2) > li:nth-child(2) > a");
        private By germanWineMakes = By.CssSelector("");
        private By listenNow = By.CssSelector("#episode-playout-p0344spz > a > div > div > span.playout__messagetext");
        private By audioButton = By.CssSelector("#msi-modal-overlay > div");
        private By videoButton = By.CssSelector("#p_audioui_playpause_pauseIcon > rect:nth-child(1)");
        //private By soundShouldPlay = By.CssSelector("");



      public void SearchButton()
        {
            driver.FindElement(searchBBCButton).Click();
        }

      public void FoodAndDrink()
        {
            driver.FindElement(foodAndDrink).Click();
        }








    }
}
