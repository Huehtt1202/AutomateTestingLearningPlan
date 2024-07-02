using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V122.DOM;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Pages
{
    internal class UICommon
    {
        private IWebDriver driver;
        private ActionCommon _act;
        private string homePgae;
        public UICommon(IWebDriver driver) { this.driver = driver; }

        public bool GetFeatureOnNavbar()
        {
            IList<IWebElement> listFeatures = _act.GetElements(By.CssSelector("div.list-features>>div"));
            foreach (var item in listFeatures)
            {
                try
                {
                    item.Click();
                    string featureName = item.GetAttribute("data-title");
                    Console.WriteLine(featureName);
                    driver.Navigate().Back();
                }catch (Exception ex) { Console.WriteLine(item); }
            }
            return true;
        }
        public void NavigateOnFeatureOfTeacherOnSidebar(string featureTitle)
        {
            switch (featureTitle)
            {
                case "Lớp học số":
                    {
                        IWebElement menuElement = driver.FindElement(By.CssSelector("div[data-title=Lớp học số"));
                        menuElement.Click();
                    }
                    break;
                case "Xây dựng học liệu số":
                    {
                        IWebElement menuElement = driver.FindElement(By.CssSelector("div[data-title=Xây dựng học liệu số"));
                        menuElement.Click();
                    }
                    break;
                case "Kiểm tra, đánh giá":
                    {
                        IWebElement menuElement = driver.FindElement(By.CssSelector("div[data-title=Kiểm tra, đánh giá"));
                        menuElement.Click();
                    }
                    break;
                case "Luyện thi IELTS":
                    {
                        IWebElement menuElement = driver.FindElement(By.CssSelector("div[data-title=Luyện thi IELTS"));
                        menuElement.Click();
                    }
                    break;
                case "Quản lý chuyên môn":
                    {
                        IWebElement menuElement = driver.FindElement(By.CssSelector("div[data-title=Quản lý chuyên môn"));
                        menuElement.Click();
                    }
                    break;
            }
        }
    }
}
}
