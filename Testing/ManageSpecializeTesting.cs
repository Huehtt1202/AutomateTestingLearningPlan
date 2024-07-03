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
    internal class ManageSpecializeTesting
    {
        private IWebDriver driver;
        private BaseSetup _setUp;
        private UICommon _uiCommon;
        private ManageSpecializePage _msPage;
        public ManageSpecializeTesting(IWebDriver driver)
        {
            this.driver = driver;
        }
        [SetUp]
        public void SetUp()
        {
            _setUp.initilizeTestBaseSetup("Chrome", "");
        }
        [TearDown]
        public void CleanUp()
        {
            _setUp.initilizeTestBaseTearDown();
        }
        [Test]
        private void NavigateToFuncOfMSWithLeaderRoleTest_ClickOnTitle_AccessOn() 
        {
            //Arrange
            _uiCommon = new UICommon(driver);
            _msPage = new ManageSpecializePage(driver);
            //Act
            _uiCommon.NavigateToFeatureOfTeacherOnSidebar("Quản lý chuyên môn");
            _msPage.NavigateToFuncOfMSWithLeaderRole2(" Nộp kế hoạch giáo dục của tổ chuyên môn ");
        }
    }
}
