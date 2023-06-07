using BBCProject.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        LoginPage loginPage = new LoginPage();


        [When(@"user clicks sign in button")]
        public void WhenUserClicksSignInButton()
        {
            loginPage.SignInButton();
        }

        [Then(@"message displayed")]
        public void ThenHomePageDisplayed()
        {
            Assert.IsTrue(loginPage.MessageDisplayed());
        }
    }
}
