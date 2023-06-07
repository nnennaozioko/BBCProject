using BBCProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V110.Debugger;
using System;
using TechTalk.SpecFlow;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class MenuStepDefinitions

    {
        MenuPage menuPage = new MenuPage();

        [Given(@"user navigates to ""([^""]*)""")]
        public void GivenUserNavigatesTo(string url)
        {
            menuPage.Navigate(url);
        }

        [When(@"user clicks on ""([^""]*)""")]
        public void WhenUserClicksOn(string menuitemtxt)
        {
            menuPage.ClickMenuItem(menuitemtxt);
        }
        [Then(@"land page should display ""([^""]*)""")]
        public void ThenLandPageShouldDisplay(string pageTitle)
        {
            switch (pageTitle)
            {
                case "Home":
                    Assert.IsTrue(menuPage.LandingPageShouldDisplayed(), "Welcome to the BBC");   
                    break;
                case "News":
                    Assert.IsTrue(menuPage.NewsPageShouldDisplayed(), "NEWS");
                    break;
                case "Sport":
                    Assert.IsTrue(menuPage.SportPageShouldDisplayed(), "SPORT");
                    break;
                case "Weather":
                    Assert.IsTrue(menuPage.WeatherPageShouldDisplayed(), "WEATHER");
                    break;
                case "iPlayer":
                    Assert.IsTrue(menuPage.IPlayerPageShouldDisplayed(), "iPLAYER");
                    break;
                case "Sounds":
                    Assert.IsTrue(menuPage.SoundsPageShouldDisplayed(), "SOUNDS");
                    break;
                case "Bitesize":
                    Assert.IsTrue(menuPage.BitesizePageShouldDisplayed(), "BITESIZE");
                    break;
                default:
                    break;

            }
        }


        //[Then(@"landing page should displayed")]
        //public void ThenLandingPageShouldDisplayed()
        //{
        //    string = "menuItem";
        //    switch (menuItem)
        //    { 
        //        case "";
        //            break;
        //        case "";
        //            break;
        //            default:
        //            break;

        //    }

    }





}

