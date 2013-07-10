using OpenQA.Selenium;

namespace UI.Integration.PageLibrary
{
    public class GoogleResultsPage : PageBase
    {
        public const string AdvancedSearchLink = "sflas";

        public void ClickAdvancedSearch()
        {
            Driver.FindElement(By.Id(AdvancedSearchLink)).Click();
        }
    }
}
