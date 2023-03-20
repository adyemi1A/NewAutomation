using DataDrivenWithExample.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenWithExample.ObjectPage
{
     class DataDrivenWithExamplePage
    {
        public DataDrivenWithExamplePage()

        {
            driver = Hooks1.driver; 
        }
            
                 IWebDriver driver;



        IWebElement SingUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement SignUpBotton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
        IWebElement Home => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[1]/a"));


        public void ClickOnSignUp()
        {
            SingUp.Click();
        }

        public  void enterUsername(string username)
        {
            Username.SendKeys(username);
        }

        public void enterEmail (string email)
        {
            Email.SendKeys(email);
        }


        public void enterPassword(string password)
        {
            Password.SendKeys(password);
        }


        public void ClickOnSignUpbotton()
        {
            SignUpBotton.Click();
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool IsHomeDisplayed()
        {
            return Home.Displayed;
        }









    }
}
