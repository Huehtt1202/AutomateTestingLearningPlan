using AutomateTestingLearningPlan.Init;
using AutomateTestingLearningPlan.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomateTestingLearningPlan.Testing.LoginTest;

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
            _setUp.initilizeTestBaseSetup("Chrome", "https://app.onluyen.vn/login");            
        }
        [TearDown]
        public void CleanUp()
        {
            _setUp.initilizeTestBaseTearDown();
        }
        public class UserDataTest
        {
            public static IEnumerable teacher
            {
                get
                {
                    yield return new TestCaseData("huehtt34@ed.onluyen.vn", "123123");
                    yield return new TestCaseData("hieupho@ed.onluyen.vn", "123123");
                    yield return new TestCaseData("hieutruong@ed.onluyen.vn", "123123");
                }
            }
            public static IEnumerable student
            {
                get
                {
                    yield return new TestCaseData("huehtt70@ed.onluyen.vn", "123123"); //student on school
                }
            }
        }
        /// <summary>
        /// Check navigate to features on the menu successfully
        /// </summary>
        /// <param name="title"></param>
        [Test]
        [TestCaseSource(typeof(UserDataTest), nameof(UserDataTest.teacher))]
        public void NavigateToFunctionTest_NavigateOnSidebar_Successfully(string username, string password)
        {

            //Arrange
            _uiCommon = new UICommon(driver);
            _login.LoginByUser(username,password);
            //act
            bool resultTest = _uiCommon.GetFeatureOnNavbar();
            //Assert
            Assert.IsTrue(resultTest);

        }
    }
}
