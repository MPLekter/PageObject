using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    public class SteamPage : PageObject
    {
        private static IWebDriver driver;
        public IWebElement privacyPolicyButton = Singleton.Driver().FindElement(By.XPath("//*[@id=\"footer_text\"]/div[2]/a[1]"));

        public SteamPage(IWebDriver Driver) : base(Driver)
        {
            driver = Driver;
        }
    }
}
