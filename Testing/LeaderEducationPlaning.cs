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

namespace AutomateTestingLearningPlan.Testing
{
    internal class LeaderEducationPlaning
    {
        IWebDriver driver = new ChromeDriver();
        private Login login;
        private User user;
        [SetUp]
        public void Init()
        {
            Login login = new Login();
            login.ExercuteLogin(user);
            this.user = new User();
            user.userName = "huehtt34@ed.onluyen.vn";
            user.password = "123123";
            //Go to LEP page
            driver.Navigate().GoToUrl("https://app-v3.onluyen.vn/manage-specialize");
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
            // Go to Create-LEP page
            SeleniumMethod.Click(driver, By.PartialLinkText(" Nộp kế hoạch giáo dục của tổ chuyên môn "));
            // Open creation LEP Model
            SeleniumMethod.Click(driver, By.CssSelector("a.btn btn-add ripple"));
            // Enter plan name
            SeleniumMethod.EnterText(driver, By.CssSelector("input.planName"), "lEP of the Math");
            // Click to droplist field
            SeleniumMethod.Click(driver, By.CssSelector("div[role=combobox]"));
            // Enter keyword into input field
            IWebElement combobobox = driver.FindElement(By.CssSelector("div[role=combobox]"));
            combobobox.Click();
            //IWebElement inputArea = combobobox.FindElement(By.TagName("input"));
            SeleniumMethod.EnterText(driver, By.TagName("input"), "TIENG ANH");
            // Select option on droplist suggest
            SeleniumMethod.SelectByIndex(driver, By.CssSelector("dev[role=listbox]"), 0);

        }
    }
}
