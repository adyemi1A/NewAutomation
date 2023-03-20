using DataDrivenWithExample.ObjectPage;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithExample.StepDefinitions
{
    [Binding]
    public class DataDrivenWithExampleStepDefinitions
    {
        DataDrivenWithExamplePage dataDrivenWithExamplePage;
        public DataDrivenWithExampleStepDefinitions()
        {
            dataDrivenWithExamplePage= new DataDrivenWithExamplePage();
        }
        





        [Given(@"I navigate to the Website")]
        public void GivenINavigateToTheWebsite()
        {
            dataDrivenWithExamplePage.NavigateToWebsite("https://angularjs.realworld.io/#/");
        }

        [Given(@"I click on Sign Up")]
        public void GivenIClickOnSignUp()
        {
            dataDrivenWithExamplePage.ClickOnSignUp();
        }

        [Given(@"I enter Username text ""([^""]*)""")]
        public void GivenIEnterUsernameText(string username)
        {
            dataDrivenWithExamplePage.enterUsername(username);
        }

        [Given(@"I enter Email text ""([^""]*)""")]
        public void GivenIEnterEmailText(string email)
        {
            dataDrivenWithExamplePage.enterEmail(email);
        }

        [Given(@"I enter Password text ""([^""]*)""")]
        public void GivenIEnterPasswordText(string password)
        {
            dataDrivenWithExamplePage.enterPassword(password);
        }

        [When(@"I click on Sign up botton")]
        public void WhenIClickOnSignUpBotton()
        {
            dataDrivenWithExamplePage.ClickOnSignUpbotton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            
            Assert.That(dataDrivenWithExamplePage.IsHomeDisplayed);
        }
    }
}
