using AutomateTestingLearningPlan.Init;
using AutomateTestingLearningPlan.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutomateTestingLearningPlan
{
    public class ForgotPassword
    {
        private IWebDriver driver;
        private ActionCommon act;

        public ForgotPassword(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Function forgot password
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public bool FindAccount(string phoneNumber)
        {
            act = new ActionCommon(driver);
            /*IWebElement elementforgotPassword = driver.FindElement(By.XPath("//app-login-form//div[@class='right-field']"));
            elementforgotPassword.Click();*/
            act.actClick(By.XPath("//app-login-form//div[@class='right-field']")); //elementforgotPassword
            /*IWebElement fieldEnterPhonenumber = driver.FindElement(By.CssSelector("input[type=text]"));
            fieldEnterPhonenumber.SendKeys(phoneNumber);*/
            act.actEnterText(By.CssSelector("input[type=text]"), phoneNumber); //Enter Phone number into input field
            /*IWebElement btnSearch = driver.FindElement(By.TagName("button"));
            btnSearch.Click();*/
            act.actClick(By.TagName("button"));
            // Check action search
            try
            {
                IWebElement listAccount = act.GetElement(By.ClassName("list-account"));
                if (listAccount == null)
                    return false;
                //phone number is exist account
                /*IWebElement item = driver.FindElement(By.XPath("//app-forgot-password-form//div[@class='account ng-star-inserted']"));
                item.Click();*/
                act.actClick(By.XPath("//app-forgot-password-form//div[@class='account ng-star-inserted']"));
                IWebElement popupGuid = act.GetElement(By.XPath("//app-modal-common//div[@class='popup-reset-pass ng-star-inserted']"));
                if (popupGuid == null) return false; //không hiện popup hướng dẫn lấy lại pw
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); };
            return false;
        }
    }
}
