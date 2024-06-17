using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Init
{
    [TestFixture]
    public class Init1
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUpTest()
        {
            driver = new ChromeDriver();
            //Select browser
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
    }
}
