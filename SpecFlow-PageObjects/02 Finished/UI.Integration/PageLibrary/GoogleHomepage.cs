using OpenQA.Selenium;

namespace UI.Integration.PageLibrary
{
    public class GoogleHomepage : PageBase
    {
        public const string GoogleSearchBoxId = "lst-ib";

        public static GoogleHomepage LoadIndexPage(IWebDriver driver, string baseUrl)
        {
            driver.Navigate().GoToUrl(baseUrl.TrimEnd(new char[] { '/' }));
            return GetInstance<GoogleHomepage>(driver, "", "");
        }

        public GoogleResultsPage EnterSearchQuery(string query)
        {
            var tb = Driver.FindElement(By.Id(GoogleSearchBoxId));
            tb.Clear();
            tb.SendKeys("alt.net");
            tb.Click();

            return GetInstance<GoogleResultsPage>(Driver);
        }

    }
}
