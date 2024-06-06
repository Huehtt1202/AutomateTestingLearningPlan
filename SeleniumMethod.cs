using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace AutomateTestingLearningPlan
{
    public class SeleniumMethod
    {
        public static void Click(IWebDriver driver, By locator)
        { 
            driver.FindElement(locator).Click();
        }
        public static void EnterText(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).Click();
            driver.FindElement(locator).SendKeys(text);
        }
        public static void EnterNumber(IWebDriver driver, By locator, int text)
        {
            driver.FindElement(locator).Click();
            driver.FindElement(locator).SendKeys(text);
        }
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
