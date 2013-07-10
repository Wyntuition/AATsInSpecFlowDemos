using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UI.Integration;
using UI.Integration.PageLibrary;

namespace Specs
{
    public class FeatureBase : TestFixtureBase
    {
        /// <summary>
        /// Sets the Current page to the specified value - provided to help readability
        /// </summary>
        protected PageBase NextPage { set { CurrentPage = value; } }

        protected PageBase CurrentPage
        {
            get { return (PageBase)ScenarioContext.Current["CurrentPage"]; }
            set { ScenarioContext.Current["CurrentPage"] = value; }
        }

        [BeforeScenario("UI")]
        public void BeforeScenario()
        {
            if (!ScenarioContext.Current.ContainsKey("CurrentDriver"))
            {
                Test_Setup();
                ScenarioContext.Current.Add("CurrentDriver", CurrentDriver);
            }
            else
            {
                CurrentDriver = (IWebDriver)ScenarioContext.Current["CurrentDriver"];
            }
        }

        [AfterScenario("UI")]
        public void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                try
                {
                    TakeScreenShot(CurrentDriver, ScenarioContext.Current.ScenarioInfo.Title,
                                   ScenarioContext.Current.ScenarioInfo.Tags.ToString());
                }
                catch // it just won't make it to normal tear down if something happens with the screen shot saving
                {
                    CurrentDriver.Quit();
                }
            }

            if (ScenarioContext.Current.ContainsKey("CurrentDriver"))
            {
                Test_Teardown();
                ScenarioContext.Current.Remove("CurrentDriver");
            }
        }

        public void TakeScreenShot(IWebDriver webDriver, string testName, string className)
        {
            string createdFolderLocation = "c:\\logs\\Cera\\AATs\\";

            // Take the screenshot            
            Screenshot ss = ((ITakesScreenshot)webDriver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;

            // Save the screenshot
            ss.SaveAsFile((string.Format("{0}\\{1}", createdFolderLocation, testName + ".Jpeg")), System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
