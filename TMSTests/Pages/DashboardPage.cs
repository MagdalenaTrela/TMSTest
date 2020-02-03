using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TMSTests.Pages
{
    public class DashboardPage
    {
        private IWebDriver driver;
        public IWebElement welcomeTittle => driver.FindElement(By.XPath("//span[text()='Adjust']"));
        public IWebElement companiesTab => driver.FindElement(By.XPath("//a[@href='#/admin/companies']"));
        

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public CompaniesPage clickButton(IWebElement element)
        {
            element.Click();

            return new CompaniesPage(driver);
        }

        
    }
}
