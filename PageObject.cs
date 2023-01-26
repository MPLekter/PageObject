using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Here all common actions that can be used on any page are stored.
//TODO: think about refactoring this so it can be inherited by any PageObject? 
namespace Task2._1
{
    public class PageObject
    {
        private static IWebDriver driver = Singleton.Driver();
        private Actions actions = new Actions(Singleton.Driver());

        public PageObject()
        {
        }

        public string GetCurrentURL()
        {
            return driver.Url;
        }
        public string GetCurrentWindowHandle()
        {
            return driver.CurrentWindowHandle;
        }
        public void MoveToElement(IWebElement element)
        {
            actions.MoveToElement(element).Perform();
        }

        public void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public void ChangeWindow(string originalWindow)
        {
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
        }

    }
}

