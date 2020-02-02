using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TMSTests.Pages;

namespace TMSTests
{
    [TestFixture]
    class LoginTests
    {
        IWebDriver driver;
        string email = "admin@test.com";
        string password = "test";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Navigate().GoToUrl("https://cphtest.btskyrise.com/PV_test/PayVend.CphTaxi.Web/#/login/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void LoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);  
            DashboardPage dashboardPage = loginPage.Login(email, password);
            
            Assert.True(dashboardPage.welcomeTittle.Displayed);
            
        }

        [Test]
        public void LoginTest2()
        {
            LoginPage loginPage = new LoginPage(driver);
            DashboardPage dashboardPage = loginPage.Login(email, password);

            Assert.True(dashboardPage.welcomeTittle.Displayed);

        }
    }
}
