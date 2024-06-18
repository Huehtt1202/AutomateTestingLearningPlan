using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;
using AutomateTestingLearningPlan.Init;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AutomateTestingLearningPlan
{
    public class SeleniumMethod
    {
        IWebDriver driver;
        public static void Click(IWebDriver driver, By locator)
        {
            try
            {
                IWebElement element = driver.FindElement(locator);
                element.Click();
            }
            catch(Exception ex) { };
        }
        public static void EnterText(IWebDriver driver, By locator, string text)
        {
            IWebElement element = driver.FindElement(locator);
            element.Click();

            element.SendKeys(text);
        }
        /* public static void EnterNumber(IWebDriver driver, By locator, int number)
         {
             driver.FindElement(locator).Click();
             driver.FindElement(locator).SendKeys(int.Parse(number));
         }*/
        /*public static void SelectedCheckBox(IWebDriver driver, By locator)
        {
            // one field checkbox
            driver.FindElement(locator).Click();
        }*/
        public static void SelectByIndex(IWebDriver driver, By locator, int no)
        {
            SelectElement selectOption = new SelectElement(driver.FindElement(locator));
            selectOption.SelectByIndex(no);
        }
    }
}
