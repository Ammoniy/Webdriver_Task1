using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using static System.Net.Mime.MediaTypeNames;
namespace MainPage
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly string url = "https://pastebin.com";

        
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            
        }
        public void Paste(string paste_text, string exp_text, string title_text)
        {
            // click on paste button
            driver.FindElement(By.XPath("//A[@class='header__btn']")).Click();
            // fill paste field
            driver.FindElement(By.XPath("//TEXTAREA[@id='postform-text']")).SendKeys(paste_text);
            // scroll
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,700)");
            // chose element from dropdown
            var dropdown = driver.FindElement(By.XPath("//*[contains(@class, 'field-postform-expiration')]//span"));
            dropdown.Click();
            var dropdownOption = driver.FindElements(By.XPath("//li[@class='select2-results__option']"));
            dropdownOption.FirstOrDefault(x => x.Text.Equals(exp_text)).Click();
            // fill Paste Name / Title
            driver.FindElement(By.XPath("//INPUT[@id='postform-name']")).SendKeys(title_text);
            // create new paste
            driver.FindElement(By.XPath("//BUTTON[@type='submit'][text()='Create New Paste']")).Click();
            
        }
    }
}
