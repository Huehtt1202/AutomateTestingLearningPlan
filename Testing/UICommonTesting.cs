using AutomateTestingLearningPlan.Init;
using AutomateTestingLearningPlan.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Testing
{
    internal class UICommonTesting
    {
        private IWebDriver driver;
        private BaseSetup _setUp;
        private LoginPage _login;
        private UICommon _uiCommon;
        public UICommonTesting(IWebDriver driver)
        {
            this.driver = driver;
        }
        [SetUp]
        public void SetUp(string username, string password)
        {
            _setUp.initilizeTestBaseSetup("Chrome", "");
            _login.LoginByUser(username, password);
        }
        [TearDown]
        public void CleanUp()
        {
            _setUp.initilizeTestBaseTearDown();
        }
        [Test]
        public void NavigateToFunctionTest_NavigateOnSidebar_Successfully(string title)
        {
            //Arrange
            _uiCommon = new UICommon(driver);
            //act
            _uiCommon.SidebarTeacher();
            //Assert
            Assert.

        }
    }
}
