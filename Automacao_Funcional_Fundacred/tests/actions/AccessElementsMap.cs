using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomacaoFuncional.tests.steps
{
    class AccessElementsMap
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='header_logo']/a/img")]
        [CacheLookup]
        public IWebElement YourLogo { get; set; }
    }
}
