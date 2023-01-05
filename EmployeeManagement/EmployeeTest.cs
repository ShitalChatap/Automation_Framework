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
        [Test, TestCaseSource(typeof(DataSource), (nameof(DataSource.AddEmployeeTestData)))]
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


            //validate entered data 
            // string nameValidation = driver.FindElement(By.XPath("//h6[@class='oxd-text oxd-text--h6 --strong']")).Text;
            //Console.WriteLine( nameValidation.ToCharArray());
            // Assert.That(expetedresult.Contains(nameValidation));
            // Console.WriteLine(expetedresult);

            // driver.FindElement(By.XPath("//div[@class='orangehrm-edit-employee-name']/h6")).Text;
           // driver.FindElement(By.XPath(headerLocattorXpath)).Text;
           // Assert.That












        }
    }
}
