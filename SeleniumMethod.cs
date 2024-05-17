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
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);
        }
        /*public static void SelectedCheckBox(IWebDriver driver, By locator)
        {
            // one field checkbox
            driver.FindElement(locator).Click();
        }*/
        public static void SingleSelectDynamicDropdown(IWebDriver driver, By locator, string text)
        {
            //Click on combobox to open dropdown-pandel
            driver.FindElement(locator).Click();
            //Enter keyword on input field
            driver.FindElement(locator).SendKeys(text);
            //Select a options on drop-list
            Dri
        }
    }
}
