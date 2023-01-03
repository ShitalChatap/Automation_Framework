using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Base;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {
       // IWebDriver driver;
       
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--main orangehrm-login-button']")).Click();
        }
    }
}
