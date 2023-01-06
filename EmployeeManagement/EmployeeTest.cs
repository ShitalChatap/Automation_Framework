using EmployeeManagement.Base;
using EmployeeManagement.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeTest : AutomationWrapper
    {
        [Test, TestCaseSource(typeof(DataSource), (nameof(DataSource.AddEmployeeTestData1)))]
        public void AddEmployeeTest(string userName, string password, string firstname, string middlename, string lastname,  string expetedresult)
        {
            driver.FindElement(By.Name("username")).SendKeys(userName);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();

            driver.FindElement(By.XPath("//input[@name='firstName']")).SendKeys(firstname);
            driver.FindElement(By.XPath("//input[@name='middleName']")).SendKeys(middlename);
            driver.FindElement(By.XPath("//input[@name='lastName']")).SendKeys(lastname);

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string headerLocatorXpath = "h6[contains(normalize-space(),@@@@@')]";
            headerLocatorXpath = headerLocatorXpath.Replace("@@@@@", "peter");

            string actualEmpRecord=driver.FindElement(By.XPath(headerLocatorXpath)).Text;
            Assert.That(actualEmpRecord, Is.EqualTo("john wick"));
           












        }
    }
}
