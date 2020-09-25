using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace AutomationFramework.Utilities.Framework
{
    public class BasePage
    {
        protected static ThreadLocal<RemoteWebDriver> tlWebDriver = new ThreadLocal<RemoteWebDriver>();
        //protected static ThreadLocal<AppiumDriver<IWebDriver>> tlAppiumDriver = new ThreadLocal<AppiumDriver<IWebDriver>>();
        protected static RemoteWebDriver webDriver= tlWebDriver.Value;
        public BasePage() { }
        public BasePage(RemoteWebDriver _driver)
        {
            tlWebDriver.Value = _driver;
            webDriver = tlWebDriver.Value;
            LaunchApplication();
        }

        private void LaunchApplication()
        {
            string applicationLink = "https://www.google.com/";
            webDriver.Navigate().GoToUrl(applicationLink);
        }
    }
}
