using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TMSTests.Pages;
using TMSTests.Tests;

namespace TMSTests
{
    [TestFixture]
    class CompaniesTest : FixtureSetup
    {
       
        [Test]
        public void AddtoAutomatedExpportTests()
        {

            CompaniesPage companiesPage = dashboardPage.clickButton(dashboardPage.companiesTab);
            companiesPage.ClickButton(companiesPage.checkbox);
            companiesPage.ClickButton(companiesPage.addToAutomatedExport);

            Assert.True(companiesPage.toast.Displayed);

        }
        
    }
}
