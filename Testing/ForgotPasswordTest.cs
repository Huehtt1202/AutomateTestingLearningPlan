using AutomateTestingLearningPlan.Init;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Testing
{
    [TestFixture]
    public class ForgotPasswordTest : Init1
    {
        [SetUp]
        public void SetUp()
        {
            //Go to login page
            driver.Navigate().GoToUrl("https://app-v3.onluyen.vn/login");
            // Set timeouts for each step
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // Set timeouts for page load
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            // extend monitor
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void FindAccountTest_PhoneNumberExist_FoundAccount()
        {
            //Arrange
            ForgotPassword forgotPassword = new ForgotPassword();
            //Act
            bool result = forgotPassword.FindAccount("0367520724");
            //Assert
            Assert.IsFalse(result);
        }
    }
}
