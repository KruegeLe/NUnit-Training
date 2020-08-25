using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Source
{
    public class Automation
    {
        public void GotoPage(string url, IWebDriver driver)
        {
            driver.Url = url;
        }

        public IWebElement FindElement(string xPath, IWebDriver driver)
        {
            return driver.FindElement(By.XPath(xPath));
        }

        public void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public void SendKeys(IWebElement element, string input)
        {
            element.SendKeys(input);
        }
    }
}
