using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationFramework.Utilities.Entities;
using AutomationFramework.Utilities.Framework;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace AutomationFramework.Utilities.Framework
{
   public class TestFactory
    {
        public static ThreadLocal<TestEntity> tlTestEntity = new ThreadLocal<TestEntity>();
        public static ThreadLocal<DeviceEntity> tlDeviceEntity = new ThreadLocal<DeviceEntity>();
        public static ThreadLocal<BasePage> tlBasePage = new ThreadLocal<BasePage>();
        public static ThreadLocal<TestReport> tlTestReport = new ThreadLocal<TestReport>();

        [SetUp]
        public void BeforeMethod()
        {
            tlTestEntity.Value = (TestEntity)TestContext.CurrentContext.Test.Arguments[0];
            CreateDevice();
            CreateDriver();
            CreateTest();
            CreateBasePage();
        }

        [TearDown]
        public void AfterMethod()
        {
            LogTestResult();
            TestReport.FlushMainReport();
            TestReport.FlustSkipReport();
            GetDriver().Quit();
        }

        public static RemoteWebDriver  GetDriver()
        {
            return tlDeviceEntity.Value.Driver;
        }

        private void LogTestResult()
        {
            throw new NotImplementedException();
        }

        private void CreateBasePage()
        {
            tlBasePage.Value = new BasePage(GetDriver());
        }

        private void CreateTest()
        {
            TestEntity testEntity = tlTestEntity.Value;
            tlTestReport.Value = new TestReport(testEntity.TestName, testEntity.TestCatagory+" "+ testEntity.TestName+" "+testEntity.Browser);
        }

        

        private void CreateDriver()
        {
            tlDeviceEntity.Value.Driver = new DriverFactory().GetDriver(tlDeviceEntity.Value);
        }

        private void CreateDevice()
        {

            DeviceEntity device = new DeviceEntity("TestOne", "https://link.com","Windows","Chrome", tlTestEntity.Value.Model, tlTestEntity.Value.Name);
            tlDeviceEntity.Value = device;
            //throw new NotImplementedException();
        }

        public TestReport Report()
        {
            return tlTestReport.Value;
        }

    }
}
