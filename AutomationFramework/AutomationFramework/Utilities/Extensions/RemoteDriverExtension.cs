using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.Utilities.Extensions
{
    public static class RemoteDriverExtension
    {
        public static IWebElement WaitFindElementByCssSelector(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IWebElement targetElement = wait.Until(new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
            {
                IWebElement element = Web.FindElement(By.CssSelector(elementLocator));
                //if (element.Displayed)
                //{
                //    return element;
                //}
                //return null;
                return element.Displayed ? element : null;
            }));
            return targetElement;
        }

        public static IWebElement WaitToFindElementByXPath(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IWebElement targetElement = wait.Until(new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
            {
                IWebElement element = Web.FindElement(By.XPath(elementLocator));
                return element.Displayed ? element : null;
            }));
            return targetElement;
        }

        public static IWebElement WaitToFindElementById(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IWebElement targetElement = wait.Until(new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
            {
                IWebElement element = Web.FindElement(By.Id(elementLocator));
                return element.Displayed ? element : null;
            }));
            return targetElement;
        }

        public static IWebElement WaitToFindElementByLinkText(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IWebElement targetElement = wait.Until(new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
            {
                IWebElement element = Web.FindElement(By.LinkText(elementLocator));
                return element.Displayed? element:null;
            }));
            return targetElement;
        }

        public static IWebElement WaitToFindElementByPartialLinkText(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IWebElement targetElement = wait.Until(new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
            {
                IWebElement element = Web.FindElement(By.PartialLinkText(elementLocator));
                return element.Displayed ? element : null;
            }));
            return targetElement;
        }

        public static IWebElement WaitToFindElementByName(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IWebElement targetElement = wait.Until(new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
            {
                IWebElement element = Web.FindElement(By.Name(elementLocator));
                return element.Displayed ? element : null;
            }));
            return targetElement;
        }

        public static IWebElement WaitToFindElementByClassName(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IWebElement targetElement = wait.Until(new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
            {
                IWebElement element = Web.FindElement(By.ClassName(elementLocator));
                return element.Displayed ? element : null;
            }));
            return targetElement;
        }

        public static IWebElement WaitToFindElementByTagName(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IWebElement targetElement = wait.Until(new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
            {
                IWebElement element = Web.FindElement(By.TagName(elementLocator));
                return element.Displayed ? element : null;
            }));
            return targetElement;
        }

        public static IList<IWebElement> WaitToFindElementsByCssSelector(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IList<IWebElement> targetElements = wait.Until(new Func<IWebDriver, IList<IWebElement>>((IWebDriver Web) =>
            {
                //IList< IWebElement> elements = Web.FindElements(By.CssSelector(elementLocator));
                return Web.FindElements(By.CssSelector(elementLocator));
                //if (elements.Count>0)
                //{
                //    return elements;
                //}
            }));
            return targetElements;
        }

        public static IList<IWebElement> WaitToFindElementsByXPath(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            IList<IWebElement> targetElements = wait.Until(new Func<IWebDriver, IList<IWebElement>>((IWebDriver Web) =>
            {
                return Web.FindElements(By.XPath(elementLocator));
            }));
            return targetElements;
        }

        public static IList<IWebElement> WaitToFindElementsById(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            return wait.Until(new Func<IWebDriver, IList<IWebElement>>((IWebDriver Web) =>
            {
                return Web.FindElements(By.Id(elementLocator));
            }));
        }

        public static IList<IWebElement> WaitToFindElementsByLinkText(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            return wait.Until(new Func<IWebDriver, IList<IWebElement>>((IWebDriver Web) =>
            {
                return Web.FindElements(By.LinkText(elementLocator));
            }));
        }

        public static IList<IWebElement> WaitToFindElementsByName(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            return wait.Until(new Func<IWebDriver, IList<IWebElement>>((IWebDriver Web) =>
            {
                return Web.FindElements(By.Name(elementLocator));
            }));
        }

        public static IList<IWebElement> WaitToFindElementsByPartialLinkText(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            return wait.Until(new Func<IWebDriver, IList<IWebElement>>((IWebDriver Web) =>
            {
                return Web.FindElements(By.PartialLinkText(elementLocator));
            }));
        }

        public static IList<IWebElement> WaitToFindElementsByTagName(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            return wait.Until(new Func<IWebDriver, IList<IWebElement>>((IWebDriver Web) =>
            {
                return Web.FindElements(By.TagName(elementLocator));
            }));
        }

        public static IList<IWebElement> WaitToFindElementsByClassName(this RemoteWebDriver _driver, string elementLocator, int waitTime = 15)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
            return wait.Until(new Func<IWebDriver, IList<IWebElement>>((IWebDriver Web) =>
            {
                return Web.FindElements(By.ClassName(elementLocator));
            }));
        }
    }
}
