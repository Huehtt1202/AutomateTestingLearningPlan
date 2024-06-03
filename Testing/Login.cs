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
    public class Login
    {
        IWebDriver driver = new ChromeDriver();
        public Login() { }
        [SetUp]
        public void Init()
        {
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
        public void ExercuteLogin()
        {
            User leader = new User();
            leader.userName = "huehtt34@ed.onluyen.vn";
            leader.password = "123123";
            //1. Enter userName
            SeleniumMethod.EnterText(driver, By.CssSelector("[type='text'][placeholder='Tên đăng nhập hoặc số điện thoại']"), leader.userName);
            //2. Enter password
            SeleniumMethod.EnterText(driver, By.CssSelector("[type='text'][placeholder='Tên đăng nhập hoặc số điện thoại']"), leader.password);
            //3. Click login
            SeleniumMethod.Click(driver, By.ClassName("btn-login"));
            string url = driver.Url.ToString();
            Assert.AreEqual("https://app-v3.onluyen.vn/school-teacher", url);
        }
        [TestCase("0367520724")]
        public void FieldForgotPassword(string phoneNumber)
        {
            //Go to login page
            driver.Navigate().GoToUrl("https://app-v3.onluyen.vn/login");
            //find field forgot password
            IWebElement forgot_password = driver.FindElement(By.ClassName("right-field"));
            forgot_password.Click();
            // Check navigate to forgot-password page
            string url = driver.Url;
            StringAssert.Contains (url, "https://app-v3.onluyen.vn/login/forgot-password");
            /*if (url.Contains("fotgot-password"))*/
            if (url.Contains("https://app-v3.onluyen.vn/login/forgot-password"))
            {
                // enter phone number
                SeleniumMethod.EnterText(driver, By.TagName("input"), phoneNumber);
                // search account
                SeleniumMethod.Click(driver, By.TagName("button"));
                // Check action search
                try
                {
                    IWebElement listAccount = driver.FindElement(By.ClassName("list-account"));
                    Console.Write("Exist Account");
                } catch (Exception ex) { Console.WriteLine(ex.Message); };
            }
            else Console.WriteLine("Can not fotgot-password");
        }
        [TestCase("Check remember me")]
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
        }
        [TearDown]
        public void Clearup()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
