using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace TFLJourneyTestRun.StepDefinitions
{
    [Binding]
    public class EditPreferencesStepDefinitions
    {
        private IWebDriver driver;
        public EditPreferencesStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [When(@"scroll up to the webpage")]
        public void WhenScrollUpToTheWebpage()

        {

            //Actions actions = new Actions(driver);


            //actions.SendKeys(Keys.PageUp).Perform();
            //Thread.Sleep(1000);
            //actions.SendKeys(Keys.PageUp).Perform();

            driver.FindElement((By.XPath("//*[@id='plan-a-journey']/div[3]/div[4]/button"))).SendKeys(Keys.PageUp);

            
        }


        [When(@"Click on edit preference")]
        public void WhenClickOnEditPreference()
        {
            driver.FindElement(By.XPath("//*[@id='plan-a-journey']/div[3]/div[4]/button")).Click();
        }

        [When(@"Select Routes with least walking")]
        public void WhenSelectRoutesWithLeastWalking()
        {
            driver.FindElement(By.XPath("//*[@id='more-journey-options']/div/fieldset/ul[2]/li[1]/fieldset/div/div/div[1]/label[3]")).Click();

        }

        [When(@"Update journey")]
        public void WhenUpdateJourney()
        {
            driver.FindElement(By.XPath("//*[@id='more-journey-options']/div/fieldset/div[2]/div/input[2]")).Click();
        }

    }
}
