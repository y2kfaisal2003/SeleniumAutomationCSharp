using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace AutomationFramework.Utilities.Framework
{
    public class DriverFactory
    {
        private static RemoteWebDriver _driver;

        public RemoteWebDriver GetDriver(DeviceEntity deviceEntity)
        {
            try
            {
                string strEnvironment = "LOCAL";
                switch (strEnvironment)
                {
                    case "LOCAL":
                        _driver = getLocalDriver();
                        return _driver;
                    case "GRID":
                        //try
                        //{
                            //String url = "";
                            //_driver = new RemoteWebDriver(new URL(url), null);
                            _driver = deviceEntity.Driver;  //new RemoteWebDriver(new Uri(url),  null));
                            return _driver;
                        //}
                        //catch (Exception e)
                        //{
                        //    throw new Exception(e.Message);
                        //    //throw new Exception("Grid URL: <B>" + TestEnvironmentConfiguration.getTestConfiguration("GridLink").trim() + "</B> is not reachable");
                        //}
                    case "SAUCELAB":
                        // Sauce Lab configuration needs to be decided 
                        _driver = deviceEntity.Driver;
                        return _driver;
                    default:
                       return _driver = deviceEntity.Driver;
                        //    //throw new Exception("Automation Execution enviroment: <B>" + TestEnvironmentConfiguration.getTestConfiguration("AutomationExecution").trim() + "</B> is not correct");
                }
            }
            catch (Exception e)
            {
                // TODO Auto-generated catch block
                throw new Exception(e.Message);
            }
        }

        public static RemoteWebDriver getLocalDriver()
        {
            try
            {
                string browser = "CHROME";
                switch (browser)
                {
                    case "CHROME":
                        _driver = new ChromeDriver();// need to add code for chrome optisons
                        return _driver;
                    case "FIREFOX":
                        _driver = new FirefoxDriver();// need to add code for FF optisons
                        return _driver;
                    case "IE":
                        _driver = new InternetExplorerDriver();// need to add code for IE optisons
                        return _driver;
                    default:
                        throw new Exception("Browser type: <B>" + browser + "</B> is not correct");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
