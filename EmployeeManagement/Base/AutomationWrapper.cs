using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Base
{
    public class AutomationWrapper
    {
        protected IWebDriver driver;
        [SetUp]
        public void BeforeMethod()
        {
            string browserName = "chro";
            if (browserName.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver();
            }

            else if (browserName.ToLower().Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                driver = new ChromeDriver();
            }

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
        }
    }
