using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ReqnrollSeleniumDemo.Utilities
{
    public static class DriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless"); 
            return new ChromeDriver();
        }
    }
}
