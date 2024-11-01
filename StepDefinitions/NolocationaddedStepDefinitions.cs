using Docker.DotNet.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace TFLJourneyTestRun.StepDefinitions
{
    [Binding]
    public class NolocationaddedStepDefinitions
    {


        private IWebDriver driver;
        public NolocationaddedStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        } 

        [Then(@"field validation error message should appear")]
        public void ThenFieldValidationErrorMessageShouldAppear()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var suggestionsList = wait.Until(d => d.FindElements(By.XPath("//*[@id='search-filter-form-0']/div/span[@class='field-validation-error']")));


        }
    }
}
