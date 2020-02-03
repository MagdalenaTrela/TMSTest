using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TMSTests.Pages;

namespace TMSTests.Tests
{
    [SetUpFixture]
    public class FixtureSetup: OneTimeFixtureSetup
    {
        string email = "admin@test.com";
        string password = "test";
        public DashboardPage dashboardPage;
        
        [SetUp]
        public void SetUp()
        {
            LoginPage loginPage = new LoginPage(driver);
            dashboardPage = loginPage.Login(email, password);
        }

        [TearDown]
        public void TearDown()
        {
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7));
            //wait.Until(driver => !(driver.FindElement(By.XPath("//div[text()='Company has been added to automated export']")).Displayed));
            Thread.Sleep(5000);
            driver.FindElement(By.ClassName("icon-logout")).Click();
        }
        
    }
}
