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
        public void GetPageTitle()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            Console.WriteLine(driver.Title);
            driver.Close();
        }

        [Test]
        public void GetListLinkText()
        {                     
            IList<IWebElement> linksList = driver.FindElements(By.CssSelector("#block_top_menu >ul > li > a"));
            foreach (IWebElement link in linksList)
            {
                Console.WriteLine(link.Text);
            }
            driver.Close();
        }

        [Test]
        public void GetNameAttribute()
        {
            IWebElement element = driver.FindElement(By.Name("search_query"));
            Console.WriteLine(element.GetAttribute("name"));
        }

        [Test]
        public void ClikOnTab()
        {
            IWebElement tabButton = driver.FindElement(By.ClassName("blockbestsellers"));
            tabButton.Click();
            driver.Close();
        }

        [Test]
        public void InsertTextInSearchField()
        {
            IWebElement inputText = driver.FindElement(By.Id("search_query_top"));
            inputText.SendKeys("Summer");
            IWebElement pressSearchBtn = driver.FindElement(By.Name("submit_search"));
            pressSearchBtn.Click();
            driver.Close();
        }
        
        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}