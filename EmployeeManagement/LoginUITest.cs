using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest
    {
        IWebDriver driver;
        [SetUp]
        public void BeforeMethod()
        {
            //browser launch
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://opensource-demo.orangehrmlive.com/";

        }
        [TearDown]
        public void AfterMethod()
        {
            //close browser
            driver.Quit();
        }
        [Test]
        public void ValidateTitleTest()
        {
            
            
            string actualTitle= driver.Title;
            Assert.That(actualTitle,Is.EqualTo("OrangeHRM"));
           
        }

        [Test]
        public void ValidatePlaceholderTest()
        {
           
            string actualUsernamePlaceholder=driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            string actualPasswordPlaceholder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(actualPasswordPlaceholder,Is.EqualTo("Password"));

        }
    }
}