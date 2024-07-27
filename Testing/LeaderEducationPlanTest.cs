using AutomateTestingLearningPlan.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomateTestingLearningPlan.Init;

namespace AutomateTestingLearningPlan.Testing
{
    [TestFixture]
    internal class LeaderEducationPlanTest
    {
        private IWebDriver driver;
        private LeaderEducationPlanPage _lep;
        private BaseSetup _setup;
        private LoginPage _login;
        private WebDriverWait _wait;
        public LeaderEducationPlanTest(IWebDriver driver)
        {
            this.driver = driver;
        }
        [SetUp]
        public void SetUp()
        {
            _setup.initilizeTestBaseSetup("Chrome", "https://app.onluyen.vn/login");
        }
        [Test]
        public void CreationLEPforTieuHocTest_TemPlateTieuHoc_CreateSuccessfully(/*string username, string password*/)
        {
            //Arrange
            _login = new LoginPage(driver);
            _lep = new LeaderEducationPlanPage(driver);
            //act
            _login.LoginByUser(/*username, password*/"huehtt34@ed.onluyen.vn", "123123");  //Đăng nhập chức năng trưởng bộ môn
            DateTime dateTime = DateTime.Now;
            _lep.CreationNewLEP("0", "2", dateTime, "Tiểu Học"); //Tạo KHGD tổ chuyên môn
            //assert
            var successMessage = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("toast-success")));
            Assert.IsNotNull(successMessage); // Kiểm tra xem phần tử thông báo thành công có tồn tại không
            Assert.AreEqual("Tạo kế hoạch giáo dục thành công. Vui lòng thêm chương trình giáo dục lên", successMessage.Text); // Kiểm tra nội dung của thông báo thành công
        }
    }
}
