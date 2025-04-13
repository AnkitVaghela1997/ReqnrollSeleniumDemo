using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using ReqnrollSeleniumDemo.Pages;

namespace ReqnrollSeleniumDemo.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"the user navigates to the login page")]
        public void GivenUserNavigatesToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/index.html");
        }

        [When(@"the user enters valid credentials")]
        public void WhenUserEntersValidCredentials()
        {
            _loginPage.Login("standard_user", "secret_sauce");
        }

        [Then(@"the user should be redirected to the products page")]
        public void ThenUserShouldBeRedirected()
        {
            Assert.That(_driver.Url.Contains("inventory.html"), "User was not redirected to the products page.");
        }
    }
}
