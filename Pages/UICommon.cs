using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V122.DOM;
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

        public void SidebarTeacher()
        {
            
            List<IWebElement> listFeatures = (List<IWebElement>)_act.GetElements(By.CssSelector("div.list-features>>div"));
            foreach (var item in listFeatures)
            {
                string value = item.GetAttribute("data-title");
                switch (value)
                {
                    case "Lớp học số":
                        {

                        } 
                        break;
                    case "Xây dựng học liệu số":
                        {

                        }
                        break;
                    case "Kiểm tra, đánh giá":
                        {

                        }
                        break;
                    case "Luyện thi IELTS":
                        {

                        }
                        break;
                    case "Quản lý chuyên môn":
                        {
                            IWebElement menuElement = driver.FindElement(By.CssSelector("div[data-title=Quản lý chuyên môn"));
                            menuElement.Click();
                            IWebElement result = _act.GetElement(By.TagName("app-manage-specialize"));
                        }
                        break;
                }
            }
        }
    }
}
