using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace AutomationFramework.Test
{
    [TestFixture]
    class ExtentReportExample
    {
        //Instance of extents reports
        //public static ExtentHtmlReporter htmlReporter;
        //public static ExtentReports extent;
        //public static ExtentTest test;
        public  ExtentHtmlReporter htmlReporter;
        public  ExtentReports extent;
        public  ExtentTest test;

        [OneTimeSetUp]
        public void BeforeClass()
        {
            //To obtain the current solution path/project path
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
           
            //Append the html report file to current project path
            string reportPath = projectPath + "Report\\TestRunReport.html";

            //Boolean value for replacing exisisting report
            htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            //Add QA system info to html report
            extent.AddSystemInfo("Test Environment", "Test 01");
            extent.AddSystemInfo("Execution Environment", "Local");
            extent.AddSystemInfo("Execution Browser", "Chrome");
            extent.AddSystemInfo("Browser's Version", "80.00");
            extent.AddSystemInfo("Operating System", "Windows");

            ////Adding config.xml file
            //extent.LoadConfig(projectPath + "Extent-Config.xml");
        }
        [OneTimeTearDown]
        public void AfterClass()
        {
            //End Report
            extent.Flush();
        }

        [SetUp]
        public void BeforeTest()
        {
            test= extent.CreateTest(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.Test.Name+" Description");
        }


        [TearDown]
        public void AfterTest()
        {
            //StackTrace details for failed Testcases
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
            {
                test.Log(Status.Fail, status + errorMessage);
            }

            extent.Flush();
        }

       


        [Test]
        public void ExtentReportExample1()
        {
          //  var test = extent.CreateTest("Test Name 1", "Test Modue and Test Name 1");
            test.Info("Step One Test Execution");
            test.Pass("Step Two Pass assert");
            test.Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            test.Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample2()
        {
            //var test = extent.CreateTest("Test Name 2", "Test Modue and Test Name 2");
            test.Info("Step One Test Execution");
            test.Pass("Step Two Pass assert");
            //test.Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            test.Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample3()
        {
            //var test = extent.CreateTest("Test Name 2", "Test Modue and Test Name 2");
            test.Info("Step One Test Execution");
            test.Pass("Step Two Pass assert");
            //test.Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            test.Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample4()
        {
            //var test = extent.CreateTest("Test Name 2", "Test Modue and Test Name 2");
            test.Info("Step One Test Execution");
            test.Pass("Step Two Pass assert");
            //test.Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            test.Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample5()
        {
            //var test = extent.CreateTest("Test Name 2", "Test Modue and Test Name 2");
            test.Info("Step One Test Execution");
            test.Pass("Step Two Pass assert");
            //test.Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            test.Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample6()
        {
            //var test = extent.CreateTest("Test Name 2", "Test Modue and Test Name 2");
            test.Info("Step One Test Execution");
            test.Pass("Step Two Pass assert");
            //test.Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            test.Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }
    }
}
