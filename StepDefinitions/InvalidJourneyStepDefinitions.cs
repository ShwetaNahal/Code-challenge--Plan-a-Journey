using Docker.DotNet.Models;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TFLJourneyTestRun.StepDefinitions
{
    [Binding]
    public class InvalidJourneyStepDefinitions
    {
        private IWebDriver? driver;

        public InvalidJourneyStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [When(@"I enter an invalid starting point and destination")]
        public void WhenIEnterAnInvalidStartingPointAndDestination()
        {
            driver.FindElement(By.XPath("//*[@id='InputFrom']")).SendKeys("London Bridge");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='InputTo']")).SendKeys("ok3456");
        }

        [Then(@"I should see no journey results")]
        public void ThenIShouldSeeNoJourneyResults()
        {
            //IWebElement element = driver.FindElement(By.XPath("//*[@id='full-width-content']/div/div[@class='r']/div[@class='main results-wrapper publictransport']/div/ul/li[@class='field-validation-error']"));
            //SelectElement select = new SelectElement(element);
            //select.SelectByText("Sorry, we can't find a journey matching your criteria");

            var accessInfo = driver.FindElement(By.XPath("//*[@id='full-width-content']/div/div[@class='r']/div[@class='main results-wrapper publictransport']/div/ul/li[@class='field-validation-error']"));
            Assert.IsTrue(accessInfo.Displayed, "Sorry, we can't find a journey matching your criteria.");
        }
    }
}
