using AutomateTestingLearningPlan.Init;
using AutomateTestingLearningPlan.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Testing
{
    internal class ManageSpecializeTesting
    {
        private IWebDriver driver;
        private BaseSetup _setUp;
        public ManageSpecializeTesting(IWebDriver driver)
        {
            this.driver = driver;
        }
        [SetUp]
        public void SetUp()
        {
            _setUp.initilizeTestBaseSetup("Chrome", "");
        }
        [TearDown]
        public void CleanUp()
        {
            _setUp.initilizeTestBaseTearDown();
        }
    }
}
