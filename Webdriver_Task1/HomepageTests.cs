using MainPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Webdriver_Task1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void SetupBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Paste_Creation_Test()
        {
            HomePage hp = new HomePage(driver);
            driver.Url = "https://pastebin.com";
            hp.Paste("Hello from WebDriver", "10 Minutes", "helloweb");
 
        }
    }
}