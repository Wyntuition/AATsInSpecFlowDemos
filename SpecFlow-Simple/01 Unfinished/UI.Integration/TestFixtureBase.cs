using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace UI.Integration
{
    public class TestFixtureBase : Steps
    {
        protected IWebDriver CurrentDriver { get; set; }

        [SetUp]
        public void Test_Setup()
        {
            //if (ConfigurationManager.AppSettings["SpecFlowDriver"] == "Firefox")
            CurrentDriver = new FirefoxDriver(new FirefoxBinary(), new FirefoxProfile());
            //else
            //    CurrentDriver = new PhantomJSDriver();

            CurrentDriver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
        }

        [TearDown]
        public void Test_Teardown()
        {
            CurrentDriver.Quit();
        }

    }
}
