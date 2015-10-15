using System;
using TechTalk.SpecFlow;

namespace Specs
{
    using UI.Integration.PageLibrary;

    [Binding]
    public class SearchGoogleSteps : FeatureBase
    {
        [Given(@"I am on the Google Home Page")]
        public void GivenIAmOnTheGoogleHomePage()
        {
            CurrentPage = GoogleHomepage.LoadIndexPage(CurrentDriver, "http://www.google.com");
        }

        [When(@"I search for ”ALT\.NET""")]
        public void WhenISearchForALT_NET()
        {
            NextPage = CurrentPage.As<GoogleHomepage>().EnterSearchQuery("ALT.NET");
        }

        [Then(@"I should see results")]
        public void ThenIShouldSeeResults()
        {
            //CurrentPage.As<GoogleResultsPage>().ClickAdvancedSearch();

            //Assert.That(CurrentPage.Is.Null);
        }
    }
}
