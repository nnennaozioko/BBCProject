using BBCProject.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class NewsMenuStepDefinitions
    {
        NewsMenuPage newsMenuPage = new NewsMenuPage();

        [When(@"user clicks News menu")]
        public void WhenUserClicksNewsMenu()
        {
            newsMenuPage.NewsMenu();
        }


        [When(@"user clicks on more dropdown")]
        public void WhenUserClicksOnMoreDropdown()
        {
            newsMenuPage.MoreDropdownShouldDisplayed();
        }

        [Then(@"news page should display ""([^""]*)""")]
        public void ThenNewsPageShouldDisplay(string newsMenuPageTitle)
        {
            switch (newsMenuPageTitle)
            {
                case "Home":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Cost of living");  
                   break;

                case "CostOfLiving":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Cost of living");
                    break;

                case "WarInUkraine":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "War in Ukraine");
                    break;

                case "Climate":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Climate");
                    break;

                case "UK":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "UK");
                    break;

                case "World":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Worldselected\r\n");
                    break;

                case "Business":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Business");
                    break;

                case "Politics":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Politics");
                    break;

                case "Culture":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Culture");
                    break;

                case "Tech":
                    Assert.IsTrue(newsMenuPage.DisabiltyShouldDisplayed(), "Technology");
                    break;

                case "Science":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Science & Environment");
                    break;

                case "FamilyAndEducation":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Family & Education");
                    break;

                case "InPicture":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "In Pictures");
                    break;

               // case "MoreDropdown":
                  //  Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "");
                  //  break;

                case "Newsbeat":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Newsbeat");
                    break;

                case "RealityCheck":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "Reality Check");
                    break;

                case "Disability":
                    Assert.IsTrue(newsMenuPage.HomeNewsPageShouldDisplayed(), "");
                    break;
                    default:
                    break;

                


            }  
            
                










        }












    }
}
