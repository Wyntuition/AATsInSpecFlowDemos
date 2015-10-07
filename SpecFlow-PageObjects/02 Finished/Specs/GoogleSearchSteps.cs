using NUnit.Framework;
using TechTalk.SpecFlow;
using UI.Integration.PageLibrary;

namespace Specs
{
    [Binding]
    public class GoogleSearchSteps : FeatureBase
    {
        [Given(@"I am on the Google Home Page")]
        public void GivenIAmOnTheGoogleHomePage()
        {
            CurrentPage = GoogleHomepage.LoadIndexPage(CurrentDriver, "http://www.google.com");
        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string p0)
        {
            NextPage = CurrentPage.As<GoogleHomepage>().EnterSearchQuery(p0);
        }

        [Then(@"I should see the wikipedia page")]
        public void ThenIShouldSeeTheWikipediaPage()
        {
            Assert.That(CurrentPage.As<GoogleResultsPage>().IsWikipediaPageDisplayed());
        }

        [Then(@"I should see over (.*) results")]
        public void ThenIShouldSeeOverResults(decimal p0)
        {
            Assert.That(CurrentPage.As<GoogleResultsPage>().AreOverOneMillionResultsDisplayed());
        }

    }
}
