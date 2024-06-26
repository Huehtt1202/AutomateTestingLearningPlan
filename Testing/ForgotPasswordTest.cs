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
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            //Go to login page
            driver.Navigate().GoToUrl("https://app.onluyen.vn/login");
            // Set timeouts for each step
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // Set timeouts for page load
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            // extend monitor
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDownTest()
        {
            Thread.Sleep(1000);
            driver.Quit();
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
    }
}
