using NUnit.Framework;
using Selenium.Source;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Tests
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        Automation automationScript;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            automationScript = new Automation();
        }

        [TestCase("https://duckduckgo.com", "//*[@id=\"search_form_input_homepage\"]")]
        public void Test1(string url, string xPath)
        {
            automationScript.GotoPage(url, driver);

            IWebElement element = automationScript.FindElement(xPath, driver);
            automationScript.SendKeys(element, "Hello world");

            element = automationScript.FindElement("//*[@id=\"search_button_homepage\"]", driver);
            automationScript.ClickElement(element);
        }



        [OneTimeTearDown]
        public void close()
        {
            //driver.Close();
        }
    }
}