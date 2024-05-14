using AutomateTestingLearningPlan.Init;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan
{
    [TestFixture]
    public class Login : Init1
    {
        public class User
        {
            public string userName { get; set; }
            public string password { get; set; }
        }
        public void FindElementOnLoginScreen()
        {
            User _user = new User();
            //Go to login page
            driver.Navigate().GoToUrl("https://app-v3.onluyen.vn/login");
            //Check title of page is correct 
            Console.Write(driver.Title);
            //StringAssert.Contains(driver.Title, "Onluyen");
            //Find element userName             
            IWebElement _userName = driver.FindElement(By.CssSelector("[type='text'][placeholder='Tên đăng nhập hoặc số điện thoại']"));
            _userName.SendKeys(_user.userName);
            //find element password
            IWebElement password = driver.FindElement(By.CssSelector("[type='password'][placeholder='Mật khẩu']"));
            password.SendKeys(_user.password);
            //find element btn_login
            IWebElement _loginbtn = driver.FindElement(By.ClassName("btn-login"));
            _loginbtn.Click();
            //Find field remember or forgot
            IWebElement field_remember_forgot = driver.FindElement(By.ClassName("field-remember-forgot"));
            //find field remember login
            IWebElement remember_login = field_remember_forgot.FindElement(By.ClassName("left-field"));
            //find field forgot password
            IWebElement forgot_password = field_remember_forgot.FindElement(By.ClassName("right-field"));

        }
        [Test]
        void testLogin()
        {
            User teacher = new User();
            teacher.userName = "huehtt34@ed.onluyen.vn";
            teacher.password = "123123";
            FindElementOnLoginScreen();
            _loginbtn.Click();
        }
        /*[Test]*/
        void testForgetPassword()
        {
            forgot_password.Click();
        }
    }
}
