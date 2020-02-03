using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TMSTests.Pages
{
    public class LoginPage

    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement emailInput => driver.FindElement(By.Id("email"));
        IWebElement passwordInput => driver.FindElement(By.Id("password"));
        IWebElement submitButton => driver.FindElement(By.ClassName("sign-in"));
        IWebElement advancedButton => driver.FindElement(By.Id("details-button"));
        IWebElement proceedLink => driver.FindElement(By.Id("proceed-link"));


        public void WaitForElementLoad(IWebElement element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
             wait.Until(drv => element.Displayed);
        }

        public DashboardPage Login(string email, string password)
        {
            try
            {
                if (advancedButton.Enabled)
                {
                    advancedButton.Click();
                    proceedLink.Click();
                }
                emailInput.Clear();
                emailInput.SendKeys(email);
                passwordInput.Clear();
                passwordInput.SendKeys(password);
                submitButton.Click();
            }
            catch
            {
                emailInput.Clear();
                emailInput.SendKeys(email);
                passwordInput.Clear();
                passwordInput.SendKeys(password);
                submitButton.Click();
            }
            
            

            return new DashboardPage(driver);
        }
    }
}
