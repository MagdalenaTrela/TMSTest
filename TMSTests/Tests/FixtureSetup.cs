using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TMSTests.Pages;

namespace TMSTests.Tests
{
    public class FixtureSetup
    {
        IWebDriver driver;
        string email = "admin@test.com";
        string password = "test";
        public DashboardPage dashboardPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Navigate().GoToUrl("https://cphtest.btskyrise.com/PV_test/PayVend.CphTaxi.Web/#/login/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            LoginPage loginPage = new LoginPage(driver);
            dashboardPage = loginPage.Login(email, password);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        
    }
}
