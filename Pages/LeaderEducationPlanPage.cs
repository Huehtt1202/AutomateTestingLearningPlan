using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public void CreationNewLEP(string level, string grade, DateTime expiredDate, string subject)
        {
            _manageSpecialize.NavigateToFuncOfMSWithLeaderRole2("Nộp kế hoạch giáo dục của tổ chuyên môn");
            _act.actClick(By.ClassName("btn btn-add ripple"));
            //Switch popup to enter data 
            //Enter name LEP
            _act.actEnterText(By.CssSelector("input[placeholder=Nhập tên kế hoạch giáo dục...]"), "KHGD test");
            // choosing school level for LEP
            _act.SelectByText(By.XPath("//*label[text()=' Khối cấp áp dụng ']//parent::div"), level);
            // Enter expiredDate to improved
            _act.actEnterDateTime(By.CssSelector("input[placeholder=\"Chọn hạn duyệt kế hoạch giáo dục\"]"), expiredDate);
            // choosing subject for LEP by text
            _act.SelectByText(By.XPath("//*[@for='subject']//parent::div"), subject);
            // if subject='tieuhoc' or subject = 'mamnon' => choose grade
            if(subject=="Tiểu học"||subject=="Mầm non")
            {
                _act.SelectByText(By.XPath("//*[@for='grade']//parent::div"), grade);
            }
            // submit form
            _act.actClick(By.TagName("button"));
        }

    }
}
