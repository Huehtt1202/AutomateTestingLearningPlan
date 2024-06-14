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
    public class ForgotPassword : Init1
    {
        public bool FindAccount(string inputPhoneNumber)
        {
            SeleniumMethod.Click(driver, By.ClassName("right-field"));
            string url = driver.Url.ToString();
            LoginScreen user = new LoginScreen(inputPhoneNumber);
            // enter phone number into field
            SeleniumMethod.EnterText(driver, By.TagName("input"), inputPhoneNumber);
            // search account
            SeleniumMethod.Click(driver, By.TagName("button"));
            // Check action search
            try
            {
                IWebElement listAccount = GetElement(By.ClassName("list-account"));
                if (listAccount == null)
                    return false;
                //phone number is exist account               
                SeleniumMethod.Click(driver, By.TagName("div"));
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
