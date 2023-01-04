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

             string actualUrl = driver.Url;
            Assert.That(actualUrl,Is.EqualTo("https://opensource-demo.orangehrmlive.com/"));
        }

        public void InvalidLoginTest()
        {
            driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys("username123");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("user@123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();



            string actualerror = driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;
            Console.WriteLine(actualerror.ToUpper());




            //Assert the error ,message Invalid Credential
            Assert.That(actualerror, Is.EqualTo("Invalid credential"), "Assertion on error message");



            Assert.That(true);
        }
    }
}
