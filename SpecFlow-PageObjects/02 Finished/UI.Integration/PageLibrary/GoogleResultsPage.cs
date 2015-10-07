using OpenQA.Selenium;

namespace UI.Integration.PageLibrary
{
    public class GoogleResultsPage : PageBase
    {
        public const string AdvancedSearchLink = "sflas";

        public bool IsWikipediaPageDisplayed()
        {
            return Driver.FindElement(By.PartialLinkText("wikipedia")).Displayed;
        }

        public bool AreOverOneMillionResultsDisplayed()
        {
            return Driver.FindElement(By.PartialLinkText("000,000")).Displayed;
        }
    }
}
