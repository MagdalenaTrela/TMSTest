using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TMSTests.Pages
{
    public class CompaniesPage
    {
        private IWebDriver driver;

        public IWebElement checkbox => driver.FindElement(By.XPath("//div[@popover='Click to select BUS COMPANY']"));
        public IWebElement addToAutomatedExport => driver.FindElement(By.XPath("//button[text()='Add to automated export']"));
        public IWebElement toast => driver.FindElement(By.XPath("//div[text()='Company has been added to automated export']"));
        
        public CompaniesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickButton(IWebElement element)
        {
            element.Click();
        }
    }


}
