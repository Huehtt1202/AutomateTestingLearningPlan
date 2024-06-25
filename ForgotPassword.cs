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
        IWebDriver driver;
        public bool FindAccount(string PhoneNumber)
        {
            IWebElement forgotPassword = driver.FindElement(By.CssSelector("div[class='right-field']"));
            forgotPassword.Click();
            IWebElement fieldEnterPhonenumber = driver.FindElement(By.CssSelector("input[type='text']"));
            fieldEnterPhonenumber.SendKeys(PhoneNumber);
            IWebElement btnSearch = driver.FindElement(By.TagName("button"));
            SeleniumMethod.Click(driver, By.TagName("button"));
            // Check action search
            try
            {
                IWebElement listAccount = GetElement(By.ClassName("list-account"));
                if (listAccount == null)
                    return false;
                //phone number is exist account
                IWebElement item = driver.FindElement(By.TagName("div"));
                item.Clear();
                IWebElement popupGuid = driver.FindElement(By.TagName("app-modal-common"));
                if (popupGuid == null) return false; //không hiện popup hướng dẫn lấy lại pw
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
