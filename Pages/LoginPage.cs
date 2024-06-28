using AutomateTestingLearningPlan.Init;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Pages
{

    public class LoginPage
    {
        private IWebDriver driver;
        private ActionCommon act;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void LoginByUser(string username, string password)
        {
            act.actEnterText(By.CssSelector("input[type=text]"), username); //enter username into input field
            act.actEnterText(By.CssSelector("input[type=password]"), password); //enter pw into input field
            act.actClick(By.ClassName("btn-login"));
        }
    }
}
