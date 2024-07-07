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
        /// Access to a function of the manage specialize feature which is selected by principal role
        /// </summary>
        /// <param name="functionTitle">Enter title need to navigate</param>
        public void NavigateToFuncOfMSWithMasterRole(string functionTitle)
        {
            //IWebElement FunctionsOfMaster = _act.GetElement(By.ClassName("manage-leader ng-star-inserted"));
            IWebElement FunctionsOfMaster = _act.GetElement(By.CssSelector("div.manage-specialize div:nth-of-type(1)"));
            IList<IWebElement> listFunction = FunctionsOfMaster.FindElements(By.CssSelector("div.list-function>div"));
            for(int i = 0; i < listFunction.Count; i++)
            {
                IWebElement titleFunction = listFunction[i];
                if (functionTitle.Equals(titleFunction.Text))
                {
                    titleFunction.Click();
                    return;
                }
            }
        }
        /// <summary>
        /// Access to a function of the manage specialize feature which is selected by leader role
        /// </summary>
        /// <param name="functionTitle">Enter title need to navigate</param>
        public void NavigateToFuncOfMSWithLeaderRole1(string functionTitle)
        {
            IWebElement FunctionsOfMaster = _act.GetElement(By.CssSelector("div.manage-specialize div:nth-of-type(2)"));
            IList<IWebElement> listFunction = FunctionsOfMaster.FindElements(By.CssSelector("div.list-function>div"));
            for (int i = 0; i < listFunction.Count; i++)
            {
                IWebElement function = listFunction[i];
                string[] titleFunctionGetAttribute;
                if (functionTitle.Equals(function.GetCssValue("p")))
                {
                    function.Click();
                    return;
                }
            }
        }
        public void NavigateToFuncOfMSWithLeaderRole2(string functionTitle)
        {
            switch (functionTitle)
            {
                case " Nộp kế hoạch giáo dục của tổ chuyên môn ":
                    {
                        IWebElement groupFunction = _act.GetElement(By.XPath("//"));
                        IWebElement Function = _act.GetElement(By.XPath("//p[Text()= ' Nộp kế hoạch giáo dục của tổ chuyên môn '"));
                        break;
                    } 
                case " Duyệt Kế hoạch giáo dục của giáo viên ":
                    {
                        IWebElement Function = _act.GetElement(By.XPath("//p[Text()= ' Duyệt Kế hoạch giáo dục của giáo viên '"));
                        break;
                    }
            }
        }
    }
}
