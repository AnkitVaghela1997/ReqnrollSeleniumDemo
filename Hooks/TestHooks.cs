using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using Reqnroll.BoDi;

namespace ReqnrollSeleniumDemo.Hooks
{
    [Binding]
    public class TestHooks
    {
        private readonly IObjectContainer _container;
        private IWebDriver? _driver;

        public TestHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless"); 
            _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();

            // Register WebDriver for dependency injection
            _container.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}
