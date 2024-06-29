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

        public void SidebarTeacher(string feature)
        {
            
            List<IWebElement> listFeatures = (List<IWebElement>)_act.GetElements(By.CssSelector("div.list-features>>div"));
            foreach (var item in listFeatures)
            {
                item.GetCssValue();
                switch (item.)
                {
                    case feature.menu1: 
                }
            }
        }
        enum feature
        {
            menu1 = 'Lớp học số',


        }
    }
}
