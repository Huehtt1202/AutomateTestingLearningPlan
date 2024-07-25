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
using static System.Net.Mime.MediaTypeNames;

namespace AutomateTestingLearningPlan
{
    public class ActionCommon
    {
        private IWebDriver driver;
        public ActionCommon(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void actClick(By locator)
        {
            try
            {
                IWebElement element = driver.FindElement(locator);
                element.Click();
            }
            catch (Exception ex) { };
        }
        public void actEnterText(By locator, string text)
        {
            try
            {
                IWebElement element = driver.FindElement(locator);
                element.Click();
                string dataElenment = element.GetAttribute("Value");
                if (dataElenment != null) { element.Clear(); }
                element.SendKeys(text);
            } catch (Exception ex) { };
        }
        public void actEnterNumber(By locator, int number)
        {
            try
            {
                IWebElement element = driver.FindElement(locator);
                element.Click();
                string dataElenment = element.GetAttribute("Value");
                if (dataElenment != null) { element.Clear(); }
                element.SendKeys(number.ToString());
            }
            catch (Exception ex) { };
        }
        public void actEnterDateTime(By locator, DateTime date)
        {
            try
            {
                IWebElement element = driver.FindElement(locator);
                element.Click();
                string dataElenment = element.GetAttribute("Value");
                if (dataElenment != null) { element.Clear(); }
                element.SendKeys(number.ToString());
            }
            catch (Exception ex) { };
        }
        public IWebElement GetElement(By locator)
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
        public IList<IWebElement> GetElements(By locator)
        {
            try
            {
                IList<IWebElement> listElement = driver.FindElements(locator);
                return listElement;
            }
            catch (Exception ex) { return null; }
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
