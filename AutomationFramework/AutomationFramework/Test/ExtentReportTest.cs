using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

namespace AutomationFramework.Test
{
    [TestFixture]
    class ExtentReportTest
    {
        ExtentHtmlReporter htmlReporter;
        ExtentReports extent;
        [OneTimeSetUp]
        public void BeforeTestSuite()
        {
            htmlReporter = new ExtentHtmlReporter("C:/Project/CSharp/AutomationFramework/AutomationFramework/Output/");
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Test Environment", "Test 01");
            extent.AddSystemInfo("Execution Environment", "Local");
            extent.AddSystemInfo("Execution Browser", "Chrome");
            extent.AddSystemInfo("Browser's Version", "80.00");
            extent.AddSystemInfo("Operating System", "Windows");
        }

        [OneTimeTearDown]
        public void AfterTestSuite()
        {
            extent.Flush();
        }

        [SetUp]
        public void BeforeTest()
        {

        }

        [TearDown]
        public void AfterTest()
        {
            extent.Flush();
        }



        [Test]
        public void ExtentReportMethod1()
        {
            var test = extent.CreateTest("Test Name 1", "Test Modue and Test Name 1");
            test.Info("Step One Test Execution");
            test.Pass("Step Two Pass assert");
            test.Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png","Failed Screen Shot");
            test.Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportMethod2()
        {
            var test = extent.CreateTest("Test Name 2", "Test Modue and Test Name 2");
            test.Info("Step One Test Execution");
            test.Pass("Step Two Pass assert");
            //test.Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            test.Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }
    }
}
