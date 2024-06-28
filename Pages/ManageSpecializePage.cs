using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Pages
{
    internal class ManageSpecializePage
    {
        private IWebDriver driver;
        private ActionCommon _act;
        private LoginPage _login;
        public ManageSpecializePage (IWebDriver driver)
        {
            this.driver = driver;
        }
        /// <summary>
        /// Choosing function on sidebar
        /// </summary>
        public void NavigateToManageSpecializePage()
        {
            //Extend sidebar after login successfully

            //Navigate to function 

        }
        public void NavigateTo_LeaderEducationPage() { }

    }
}
