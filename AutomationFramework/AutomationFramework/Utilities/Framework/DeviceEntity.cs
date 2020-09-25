using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace AutomationFramework.Utilities.Framework
{
    public class DeviceEntity
    {
        public RemoteWebDriver Driver { get; set; }
        public string DeviceName { get; set; }
        public string MobileDeviceName { get; set; }
        public string MobiledeviceVersion { get; set; }
        public string MobileDeviceUDID { get; set; }
        public string MobileDeviceOS { get; set; }
        public string Plateform { get; set; }
        public string TestCatagory { get; set; }
        public string TestCaseName { get; set; }
        public string TestApplication { get; set; }
        public string TestEnvironment { get; set; }
        public string GenericTestExecutionEnv { get; set; }
        public string AutomationName { get; set; }
        public string AppiumVersion { get; set; }
        public string Browser { get; set; }
        public Object Report { get; set; }

        public DeviceEntity(string genericTestExecutionEnv, string executionEnv, string plateform, string browser, string testCatagory, string testCaseName)
        {
            this.GenericTestExecutionEnv = genericTestExecutionEnv;
            this.TestEnvironment = executionEnv;
            this.Plateform = plateform;
            this.Browser = browser;
            this.TestCatagory = testCatagory;
            this.TestCaseName = testCaseName;
        }
    }
}
