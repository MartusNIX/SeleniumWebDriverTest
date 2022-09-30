using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumWebDriverTest
{
    public class Tests
    {
        protected DriverManager driverManager;

        [SetUp]
        public void Setup()
        {
            driverManager = new DriverManager();
        }

        [Test]
        public void GetPageTitle()
        {
            Console.WriteLine(driverManager.GetWebDriver().Title);
        }

        [Test]
        public void GetListLinkText()
        {
            var linksList = driverManager.GetWebDriver().FindElements(By.CssSelector("#block_top_menu >ul > li > a"));
            foreach (IWebElement link in linksList)
            {
                Console.WriteLine(link.Text);
            }
        }

        [Test]
        public void GetNameAttribute()
        {
            var element = driverManager.GetWebDriver().FindElement(By.Name("search_query"));
            Console.WriteLine(element.GetAttribute("name"));
        }

        [Test]
        public void ClikOnTab()
        {
            var tabButton = driverManager.GetWebDriver().FindElement(By.ClassName("blockbestsellers"));
            tabButton.Click();
        }

        [Test]
        public void InsertTextInSearchField()
        {
            var inputText = driverManager.GetWebDriver().FindElement(By.Id("search_query_top"));
            inputText.SendKeys("Summer");
            var pressSearchBtn = driverManager.GetWebDriver().FindElement(By.Name("submit_search"));
        }
        
        [TearDown]
        public void QuitDriver()
        {
            driverManager.GetWebDriver().Close();
            driverManager.GetWebDriver().Quit();
        }
    }
}