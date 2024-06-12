using AutomateTestingLearningPlan.Init;
using AutomateTestingLearningPlan.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;

namespace AutomateTestingLearningPlan
{
    public class LoginService : Init1
    {
        public void ForgotPassword(string inputPhoneNumber)
        {
            SeleniumMethod.Click(driver, By.ClassName("right-field"));
            string url = driver.Url.ToString();
            User user = new User(inputPhoneNumber);
            // enter phone number into field
            SeleniumMethod.EnterText(driver, By.TagName("input"), inputPhoneNumber);
            // search account
            SeleniumMethod.Click(driver, By.TagName("button"));
            // Check action search
            try
            {
                IWebElement listAccount = GetElement(By.ClassName("list-account"));
                if (listAccount == null)
                    return;
                //phone number is exist account
                IWebElement item = GetElement(By.TagName("div"));
                if (item == null)
                    return;
                item.Click();
                IWebElement popupGuid = driver.FindElement(By.TagName("app-modal-common"));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); };
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
