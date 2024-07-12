using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
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
        /// Access to a function of the manage specialize feature which is selected by Account has one role
        /// </summary>
        public void NavigateToEachFuncOfMS()
        {
            string urlMS = driver.Url;
            //IWebElement FunctionsOfMaster = _act.GetElement(By.ClassName("manage-leader ng-star-inserted"));
            IWebElement contents = _act.GetElement(By.ClassName("manage-specialize"));
            IList<IWebElement> listFunction = contents.FindElements(By.CssSelector("div.list-function>div"));
            foreach(var func in listFunction)
            {
                func.Click();
                string url = driver.Url;
                if (url != urlMS)
                {
                    driver.Navigate().Back();
                }
                else Console.WriteLine("function died: + {func}");
            }
        }
        /// <summary>
        /// Access to a function of the manage specialize feature which is selected by Account has multiple role
        /// </summary>
        /// <param name="functionTitle"></param>
        public void NavigateToFuncOf(string trigger)
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
        /// <summary>
        /// Access to a function of the manage specialize feature which is selected by Account has multiple role
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
