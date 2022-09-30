using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriverTest
{
    public class DriverManager
    {
        private readonly IWebDriver driver;

        public IWebDriver GetWebDriver()
        {
            return driver;
        }

        public DriverManager()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
        }       
    }
}