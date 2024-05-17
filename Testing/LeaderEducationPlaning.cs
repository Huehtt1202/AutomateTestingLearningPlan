using AutomateTestingLearningPlan.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Testing
{
    internal class LeaderEducationPlaning
    {
        IWebDriver driver = new ChromeDriver();
        private Login login;
        [SetUp]
        public void Init()
        {
            // Set timeouts for each step
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            // Set timeouts for page load
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3);
            // extend monitor
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void CreateLEP()
        {
            login.ExercuteLogin(new User());
            //Go to LEP page
            driver.Navigate().GoToUrl("https://app-v3.onluyen.vn/manage-specialize");
        }
    }
}
