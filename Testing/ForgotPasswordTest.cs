using AutomateTestingLearningPlan.Init;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Testing
{
    [TestFixture]
    public class ForgotPasswordTest
    {
        private IWebDriver driver;
        private ForgotPassword _forgotPassword;
        private BaseSetup _setup;
        public ForgotPasswordTest(IWebDriver driver)
        {
            this.driver = driver;
        }

        [SetUp]
        private void SetUp()
        {
            _setup.initilizeTestBaseSetup("Chrome", "https://app.onluyen.vn/login");

        }
        [TearDown]
        public void TearDown()
        {
            _setup.initilizeTestBaseTearDown();
        }
        [Test]
        public void FindAccountTest_PhoneNumberExist_FoundAccount()
        {
            //Arrange
            _forgotPassword = new ForgotPassword(driver);
            //Act
            bool result = _forgotPassword.FindAccount("0367520724");
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void FindAccountTest_PhoneNumberNotExist_FoundAccount()
        {
            //Arrange
            _forgotPassword = new ForgotPassword(driver);
            //Act
            bool result = _forgotPassword.FindAccount("0123456789");
            //Assert
            Assert.IsFalse(result);
        }
    }
}
