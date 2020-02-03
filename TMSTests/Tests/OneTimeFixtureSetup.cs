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
    public class OneTimeFixtureSetup
    {
        public IWebDriver driver;
        public DashboardPage dashboardPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Navigate().GoToUrl("https://cphtest.btskyrise.com/PV_test/PayVend.CphTaxi.Web/#/login/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }

    }
}
