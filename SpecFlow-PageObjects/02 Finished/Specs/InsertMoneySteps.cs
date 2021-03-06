﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace Specs
{
    [Binding]
    public class InsertMoneySteps 
    {
        private FirefoxDriver driver = new FirefoxDriver(new FirefoxBinary(), new FirefoxProfile()); 

        [Given(@"I have a coin to submit to the register")]
        public void GivenIHaveACoinToSubmitToTheRegister()
        {
            driver.Navigate().GoToUrl("http://localhost:31809/");
        }

        [When(@"I submit the moeny")]
        public void WhenISubmitTheMoeny()
        {
            var tb = driver.FindElement(By.Id("amountBox"));
            tb.Clear();
            tb.SendKeys("25");

            var button = driver.FindElement(By.Id("submitAmount"));
            button.Click();
        }

        [Then(@"the register should show how much I gave")]
        public void ThenTheRegisterShouldShowHowMuchIGave()
        {
            var amount = driver.FindElement(By.Id("totalAmount"));
            Assert.That(amount.Text.Contains("25"));

            driver.Close();
        }
    }
}
