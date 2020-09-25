using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Utilities.Framework;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace AutomationFramework.Test
{
    [TestFixture]
    class TestBase
    {
        protected TestReport test = new TestReport();

        [OneTimeSetUp]
        public void BeforeTestClass()
        {
            test.BeforeClass();
        }
        [OneTimeTearDown]
        public void AfterTestClass()
        {
            test.AfterClass();
        }

        [SetUp]
        public void BeforeTestMethod()
        {
            test.BeforeTest(TestContext.CurrentContext);
        }
        [TearDown]
        public void AfterTestMethod()
        {
            test.AfterTest();
        }

        public ExtentTest Test()
        {
            return test.test;
        }
    }
}
