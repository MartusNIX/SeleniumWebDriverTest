using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumWebDriverTest
{
    public class Tests
    {
        protected IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        [Test]
        public void GetListLinkText()
        {
                                  
            IList<IWebElement> linkList = driver.FindElements(By.CssSelector("#block_top_menu >ul > li > a"));
            foreach (IWebElement link in linkList)
            {
                System.Console.WriteLine(link.Text);
            }

        }
    }
}