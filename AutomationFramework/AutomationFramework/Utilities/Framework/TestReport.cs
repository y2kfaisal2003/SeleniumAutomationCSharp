using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace AutomationFramework.Utilities.Framework
{
    public class TestReport
    {
        //Instance of extents reports
        //public static ExtentHtmlReporter htmlReporter;
        //public static ExtentReports extent;
        //public static ExtentTest test;

        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;
        private string strTestName;
        private string strTestDescription;

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
            extent.AddSystemInfo("Name", "Ali Faisal");
            extent.AddSystemInfo("Test Environment", "Test 01");
            extent.AddSystemInfo("Execution Environment", "Local");
            extent.AddSystemInfo("Execution Browser", "Chrome");
            extent.AddSystemInfo("Browser's Version", "80.00");
            extent.AddSystemInfo("Operating System", "Windows");
            
            ////Adding config.xml file
            //extent.LoadConfig(projectPath + "Extent-Config.xml");
        }

        public void AfterClass()
        {
            //End Report
            extent.Flush();
        }
       
        public void BeforeTest(TestContext testCase)
        {
               test = extent.CreateTest(testCase.Test.Name, testCase.Test.Name + " Description");
        }

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

        public TestReport(string strTestName, string strTestDescription)
        {
            this.strTestName = strTestName;
            this.strTestDescription = strTestDescription;
        }

        public TestReport()
        {
        }

        internal static void FlushMainReport()
        {
            throw new NotImplementedException();
        }

        internal static void FlustSkipReport()
        {
            throw new NotImplementedException();
        }
    }
}
