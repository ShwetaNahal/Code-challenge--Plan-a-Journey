using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TFLJourneyTestRun.StepDefinitions
{
    [Binding]
    public sealed class AutocmpltStepDefinition
    {
        private IWebDriver driver;
        public AutocmpltStepDefinition(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"I found matching suggestion")]
        public void WhenIFoundMatchingSuggestion()

        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var suggestionsList = wait.Until(d => d.FindElements(By.XPath("//div[@class='tt-suggestion']//span[@class='stop-name']")));
          
        }



        [When(@"I found matching suggestion for ""([^""]*)"" as ""([^""]*)""")]
        public void WhenIFoundMatchingSuggestionForAs(string p0, string p1)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var suggestionsList = wait.Until(d => d.FindElements(By.XPath("//div[@class='tt-suggestion']//span[@class='stop-name']")));

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //var suggestionsList = wait.Until(d => d.FindElements(By.XPath("//div[@class='tt-suggestion']//span[@class='stop-name']")));
            ////var suggestionsList = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("//*[@id="InputTo"][@aria-autocomplete='list']")));
            //var suggestionsList = wait.Until(d =>
            //{
            //    var elements = d.FindElements(By.XPath("//div[@class='tt-suggestion']//span[@class='stop-name']"));
            //    //*[@id='InputFrom-feedback']")); //div[@class='tt-suggestion']//span[@class='stop-name']
            //    return elements.Count > 0 ? elements : null; // Return null if no elements found
            //});

            //if (suggestionsList == null)
            //{
            //    throw new Exception("Autocomplete suggestions not found.");
            //}

            foreach (var suggestion in suggestionsList)
            {
                if (suggestion.Text.Contains(p1)) // Check for partial match in suggestion text
                {
                    suggestion.Click(); // Select the suggestion
                    break;
                }
            }

        }
        [When(@"I click on edit journey")]
        public void WhenIClickOnEditJourney()
        {
            driver.FindElement(By.XPath("//*[@id='plan-a-journey']/div[1]/div[3]/a/span")).Click();
        }

        [When(@"I select walking")]
        public void WhenISelectWalking()
        {
            driver.FindElement(By.XPath("//*[@id='walking']/span")).Click();
        }

        [When(@"I select cycling")]
        public void WhenISelectCyclinging()
        {
            driver.FindElement(By.XPath("//*[@id='cycling']/span")).Click();
        }







    }
}

