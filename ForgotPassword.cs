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
        public ForgotPassword(IWebDriver _driver)
        {
            this.driver = _driver;
        }
        public bool FindAccount(string phoneNumber)
        {
            IWebElement elementforgotPassword = driver.FindElement(By.XPath("//app-login-form//div[@class='right-field']"));
            elementforgotPassword.Click();
            IWebElement fieldEnterPhonenumber = driver.FindElement(By.CssSelector("input[type=text]"));
            fieldEnterPhonenumber.SendKeys(phoneNumber);
            IWebElement btnSearch = driver.FindElement(By.TagName("button"));
            btnSearch.Click();
            // Check action search
            try
            {
                IWebElement listAccount = GetElement(By.ClassName("list-account"));
                if (listAccount == null)
                    return false;
                //phone number is exist account
                IWebElement item = driver.FindElement(By.XPath("//app-forgot-password-form//div[@class='account ng-star-inserted']"));
                item.Click();
                IWebElement popupGuid = driver.FindElement(By.XPath("//app-modal-common//div[@class='popup-reset-pass ng-star-inserted']"));
                if (popupGuid == null) return false; //không hiện popup hướng dẫn lấy lại pw
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); };
            return false;
        }
        private IWebElement GetElement(By locator)
        {
            try
            {
                IWebElement result = driver.FindElement(locator);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
