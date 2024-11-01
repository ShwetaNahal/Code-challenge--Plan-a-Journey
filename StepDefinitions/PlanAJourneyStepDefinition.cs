using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TFLJourneyTestRun.StepDefinitions
{
    [Binding]
    public sealed class PlanAjourneyStepDefinition
    {
        
        private IWebDriver? driver;

        public PlanAjourneyStepDefinition(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I am on the TfL homepage")]
        public void GivenIAmOnTheTfLHomepage()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Url = "https://tfl.gov.uk/plan-a-journey";

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']")).Click();

        }

        [When(@"I enter ""([^""]*)"" as the starting point")]
        public void WhenIEnterAsTheStartingPoint(string p0)
        {
            driver.FindElement(By.XPath("//*[@id='InputFrom']")).SendKeys(p0);
        }

        [When(@"I enter ""([^""]*)"" as the destination")]
        public void WhenIEnterAsTheDestination(string p0)
        {
            driver.FindElement(By.XPath("//*[@id='InputTo']")).SendKeys(p0);
            //driver.FindElement(By.XPath("//*[@id='InputTo']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }

        [When(@"I enter ""([^""]*)"" as the destination1")]
        public void WhenIEnterAsTheDestination1(string p0)
        {
            driver.FindElement(By.XPath("//*[@id='InputTo']")).SendKeys(p0);
            driver.FindElement(By.XPath("//*[@id='InputTo']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }


        [When(@"I select a suggested location from the autocomplete list")]
        public void WhenISelectASuggestedLocationFromTheAutocompleteList()
        {
            var selectElement = new SelectElement(driver.FindElement(By.XPath("//*[@id='InputTo']")));
            selectElement.SelectByText("London");
        }

        [When(@"I choose ""([^""]*)"" as the travel option")]
        public void WhenIChooseAsTheTravelOption(string walking)
        {
            
            
            
            throw new PendingStepException();
        }

        [When(@"I submit the journey")]
        public void WhenISubmitTheJourney()
        {
            driver.FindElement(By.XPath("//*[@id='plan-journey-button'][@type='submit']")).Click();
        }

        [When(@"click on view details")]
        public void WhenClickOnViewDetails()
        {
            driver.FindElement(By.XPath("//*[@id='option-1-content']/div[1]/div[5]/div[2]/button[1]")).Click();
        }


        [Then(@"I should see the journey details")]
        public void ThenIShouldSeeTheJourneyDetails()
        {
            throw new PendingStepException();
        }

        [Then(@"the walking and cycling times should be displayed")]
        public void ThenTheWalkingAndCyclingTimesShouldBeDisplayed()
        {
            throw new PendingStepException();
        }


    }
}

