using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan.Pages
{
    internal class LeaderEducationPlanPage
    {
        private IWebDriver driver;
        private ActionCommon _act;
        private LoginPage _login;
        private ManageSpecializePage _manageSpecialize;
        private UICommon _uiCommon;
        public LeaderEducationPlanPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CreationNewLEP(string grade)
        {
            _manageSpecialize.NavigateToFuncOfMSWithLeaderRole2("Nộp kế hoạch giáo dục của tổ chuyên môn");
            _act.actClick(By.ClassName("btn btn-add ripple"));
            //Switch popup to enter data 
            //Enter name LEP
            _act.actEnterText(By.CssSelector("input[placeholder=Nhập tên kế hoạch giáo dục...]"), "KHGD test");
            //Enter grade
            _act.actEnterText(By.CssSelector("input[]"), grade);
        }
    }
}
