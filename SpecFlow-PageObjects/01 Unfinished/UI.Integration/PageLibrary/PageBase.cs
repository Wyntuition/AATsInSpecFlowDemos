using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UI.Integration.PageLibrary
{
    public abstract partial class PageBase
    {
        protected IWebDriver Driver;
        public string BaseURL { get; set; }
        public virtual string DefaultTitle { get { return ""; } }

        protected TPage GetInstance<TPage>(IWebDriver driver = null, string expectedTitle = "") where TPage : PageBase, new()
        {
            return GetInstance<TPage>(driver ?? Driver, BaseURL, expectedTitle);
        }

        protected static TPage GetInstance<TPage>(IWebDriver driver, string baseUrl, string expectedTitle = "") where TPage : PageBase, new()
        {
            var pageInstance = new TPage()
            {
                Driver = driver,
                BaseURL = baseUrl
            };
            PageFactory.InitElements(driver, pageInstance);

            if (string.IsNullOrWhiteSpace(expectedTitle)) expectedTitle = pageInstance.DefaultTitle;

            //wait up to 5s for an actual page title since Selenium no longer waits for page to load after 2.21
            new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(5))
                                            .Until<OpenQA.Selenium.IWebElement>((d) =>
                                            {
                                                return d.FindElement(ByChained.TagName("body"));
                                            });

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : PageBase, new()
        {
            return (TPage)this;
        }

        //public static GoogleHome LoadIndexPage(IWebDriver driver, string baseUrl)
        //{
        //    driver.Navigate().GoToUrl(baseUrl.TrimEnd(new char[] { '/' }) + IndexPage.URL);
        //    return GetInstance<LogInPage>(driver, baseUrl, "");
        //}

    }
}
