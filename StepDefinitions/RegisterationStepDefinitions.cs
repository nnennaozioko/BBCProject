using BBCProject.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class RegisterationStepDefinitions
    {
        RegistrationPage registrationPage = new RegistrationPage();

        [When(@"user clicks sign in")]
        public void WhenUserClicksSignIn()
        {
            registrationPage.SignIn();
        }

        [When(@"user clicks register now")]
        public void WhenUserClicksRegisterNow()
        {
            registrationPage.RegisterNow();
        }

        [When(@"user clicks thirteenOrOver")]
        public void WhenUserClicksThirteenOrOver()
        {
            registrationPage.ThirteenOrOver();
        }


        [When(@"user enters day ""([^""]*)""")]
        public void WhenUserEntersDay(string daytxt)
        {
            registrationPage.Day(daytxt);
        }

        [When(@"user enters month ""([^""]*)""")]
        public void WhenUserEntersMonth(string monttxt)
        {
            registrationPage.Month(monttxt);
        }

        [When(@"user enters year ""([^""]*)""")]
        public void WhenUserEntersYear(string yeartxt)
        {
            registrationPage.Year(yeartxt);
        }

        [When(@"user clicks continue button")]
        public void WhenUserClicksContinueButton()
        {
            registrationPage.ContinueButton();
        }

        [When(@"user enters email address ""([^""]*)""")]
        public void WhenUserEntersEmailAddress(string emailtxt)
        {
            registrationPage.EmailAddress(emailtxt);
        }

        [When(@"user enters password ""([^""]*)""")]
        public void WhenUserEntersPassword(string passwordtxt)
        {
            registrationPage.Password(passwordtxt);
        }

        [When(@"user enters postcode ""([^""]*)""")]
        public void WhenUserEntersPostcode(string postcodetxt)
        {
            registrationPage.Postcode(postcodetxt);
        }

        [When(@"user selects gender")]
        public void WhenUserSelectsGender()
        {
           registrationPage.SelectGender();
        }

        [When(@"user clicks register button")]
        public void WhenUserClicksRegisterButton()
        {
            registrationPage.RegisterButton();
        }

        [Then(@"OK you’re signed in\. Now, want to keep up to date\?")]
        public void ThenOKYouReSignedIn_NowWantToKeepUpToDate()
        {
            Assert.IsTrue(registrationPage.SuccessfulMessageDisplayed());
        }




    }
}
