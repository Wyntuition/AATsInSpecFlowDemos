using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace Specs
{
    [Binding]
    public class InsertMoneyDemoSteps
    {
        private FirefoxDriver driver = 
            new FirefoxDriver(
                new FirefoxBinary(), new FirefoxProfile()); 

        [Given(@"I have a quarter")]
        public void GivenIHaveAQuarter()
        {
            driver.Navigate().GoToUrl("http://localhost:31809/");
        }

        [When(@"I insert it into the register")]
        public void WhenIInsertItIntoTheRegister()
        {
            var tb = driver.FindElement(By.Id("amountBox"));
            tb.Clear();
            tb.SendKeys("25");

            var button = driver.FindElement(By.Id("submitAmount"));
            button.Click();
			
        }

        [Then(@"I should see the amount I entered")]
        public void ThenIShouldSeeTheAmountIEntered()
        {
            var amount = driver.FindElement(By.Id("totalAmount"));
            Assert.That(amount.Text.Contains("25"));

            driver.Close();
        }
    }
}
