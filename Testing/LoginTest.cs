using AutomateTestingLearningPlan.Init;
using AutomateTestingLearningPlan.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Testing
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver driver;
        private BaseSetup _setUp;
        private LoginPage _login;
        public LoginTest(IWebDriver driver)
        {
            this.driver = driver;
        }
        [SetUp]
        public void SetUp()
        {
            _setUp.initilizeTestBaseSetup("Chrome", "https://app.onluyen.vn/login");
        }
        [TearDown]
        public void CleanUp()
        {
            _setUp.initilizeTestBaseTearDown();
        }
        public class LoginDataTest
        {
            public static IEnumerable userTest
            {
                get
                {
                    yield return new TestCaseData("huehtt34@ed.onluyen.vn", "123123");
                    yield return new TestCaseData("huehtt70@ed.onluyen.vn", "123123");
                }
            }
        }
        [Test]
        [TestCaseSource(typeof(LoginDataTest), nameof(LoginDataTest.userTest))]
        public void LoginByUserTest_ValidAccount_LoginSuccessfully(string inputUserName, string inputPassword)
        {
            //Arrange
            _login = new LoginPage(driver);
            // Act
            _login.LoginByUser(inputUserName, inputPassword);
            //Assert
            string urlCurrently = driver.Url.ToString();
            string urlLogin = "https://app-v3.onluyen.vn/login/";
            Assert.IsFalse(urlCurrently.Equals(urlLogin));
        }/*
        //[TestCase("Check remember me")]
        public void testRememberMe(User _user)
        {
            //1. Enter userName
            SeleniumMethod.EnterText(driver, By.CssSelector("[type='text'][placeholder='Tên đăng nhập hoặc số điện thoại']"), _user.userName);
            //2. Enter password
            SeleniumMethod.EnterText(driver, By.CssSelector("[type='password'][placeholder='Mật khẩu']"), _user.password);
            // Select rememnber me
            IWebElement rememberMe = driver.FindElement(By.Id("remember"));
            rememberMe.Click();
            // Login
            SeleniumMethod.Click(driver, By.ClassName("btn-login"));
        }*/
    }
}
