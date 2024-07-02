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
        private UICommon _uiCommon;
        public ManageSpecializePage (IWebDriver driver)
        {
            this.driver = driver;
        }
        /// <summary>
        /// Choosing function on sidebar
        /// </summary>
        public void ManageSpecializeWithMasterRole(string functionName)
        {
            IList<IWebElement> listFunction = _act.GetElements(By.CssSelector("div.list-function>>div"));
            for(int i = 0; i < listFunction.Count; i++)
            {
                IWebElement function = listFunction[i];
                if (functionName.Equals(function.GetCssValue("p"))) function.Click();
            }
        }

    }
}
