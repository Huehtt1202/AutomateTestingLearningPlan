using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Init
{
    public class BaseSetup
    {
        private IWebDriver driver;
        private void setDriver(string browserType, string webUrl) 
        { 
            switch (browserType)
            {
                case "Chrome":
                    initChromeDriver(webUrl); break;
                default: throw new ArgumentException();
            }
        }
        private IWebDriver initChromeDriver(string webUrl)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(webUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            return driver;
        }
        public void initilizeTestBaseSetup(string browserType, string webUrl)
        {
            setDriver(browserType, webUrl);
        }
        public void initilizeTestBaseTearDown()
        {
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
