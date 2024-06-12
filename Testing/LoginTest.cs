using AutomateTestingLearningPlan.Init;
using AutomateTestingLearningPlan.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Testing
{
    [TestFixture]
    public class LoginTest : Init1
    {
        IWebDriver driver;
        public LoginTest() { }
        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            //Go to login page
            driver.Navigate().GoToUrl("https://app-v3.onluyen.vn/login");
            // Set timeouts for each step
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            // Set timeouts for page load
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3);
            // extend monitor
            driver.Manage().Window.Maximize();
        }
        [Test]
        [TestCase("huehtt34@ed.onluyen.vn", "123123")]
        [TestCase("huehtt70@ed.onluyen.vn", "123123")]
        public void LoginByUser(string inputUserName, string inputPassword)
        {
            User leader = new User(inputUserName, inputPassword);
            Console.WriteLine(inputPassword);
            //1. Enter userName
            SeleniumMethod.EnterText(driver, By.CssSelector("input[type=text]"), leader.userName);
            //2. Enter password
            SeleniumMethod.EnterText(driver, By.CssSelector("input[type=password]"), leader.password);
            //3. Click login
            SeleniumMethod.Click(driver, By.ClassName("btn-login"));
            string urlCurrently = driver.Url.ToString();
            string urlLogin = "https://app-v3.onluyen.vn/login/";
            Assert.IsFalse(urlCurrently.Equals(urlLogin));
        }
        /// <summary>
        /// Happy case forgot password 
        /// </summary>
        /// <param name="inputPhoneNumber"></param>
        [Test]
        [TestCase("0367520724")]
        LoginService.ForgotPassword("0367520724");

        [TestCase("Check remember me")]
        /*public void testRememberMe(User _user)
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
        [TearDown]
        public void Clearup()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }

        private IWebElement GetElement(By by)
        {
            try
            {
                IWebElement result = driver.FindElement(by);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
    public class Register
    {
        public Register() { }
        public Register(string _phoneNumber) 
        {

        }
        void 
    }
}
