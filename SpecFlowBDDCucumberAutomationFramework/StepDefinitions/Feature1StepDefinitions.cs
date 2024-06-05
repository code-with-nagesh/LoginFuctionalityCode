using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SpecFlowBDDCucumberAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class Feature1StepDefinitions
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private IWebDriver driver;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [Given(@"Open the browser")]
        public void OpenBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

       

        [When(@"user is on login page")]
        public void EnterUrl()
        {
            driver.Url = "https://practice.expandtesting.com/login";
            Thread.Sleep(5000);
        }

        [When(@"When user enters username and password")]
        public void EnterUsernameAndPassword()
        {
            driver.FindElement(By.Id("username")).SendKeys("practice");
            driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");

            Thread.Sleep(5000);

        }

        [When(@"user clicks on login")]
        public void ClickOnLoginButton()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            Thread.Sleep(5000); 
        }

        [Then(@"user is navigated to the home page")]
        public void HomePageDisplayed()
        {
            bool IsDisplay = driver.FindElement(By.XPath("//i[text()=' Logout']")).Displayed;
            Assert.IsTrue(IsDisplay);

            driver.Quit();
            Thread.Sleep(5000);
        }
    }
}
