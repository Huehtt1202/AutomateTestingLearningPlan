using AutomateTestingLearningPlan.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomateTestingLearningPlan.Init;

namespace AutomateTestingLearningPlan.Testing
{
    internal class LeaderEducationPlaning
    {
        private IWebDriver driver;
        private LeaderEducationPlanPage _lep;
        private BaseSetup _setup;
        private LoginPage _login;
        public LeaderEducationPlaning(IWebDriver driver)
        {
            this.driver = driver;
        }
        [SetUp]
        public void Init()
        {
            _setup.initilizeTestBaseSetup("Chrome", "https://app.onluyen.vn/login");
        }
        [Test]
        public void CreationLEPforTieuHocTest_TemPlateTieuHoc_CreateSuccessfully(string username, string password)
        {
            //Arrange
            _lep = new LeaderEducationPlanPage(driver);
            //act
            _login.LoginByUser(username, password);
            DateTime dateTime = DateTime.Now;
            _lep.CreationNewLEP("0", "2", dateTime, "Tiểu Học");
            //assert
            IWebElement messageRespone = driver.FindElement(By.)
            string respone = driver.
        }
    }
}
