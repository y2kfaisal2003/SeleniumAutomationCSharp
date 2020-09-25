using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace AutomationFramework.Test
{
   
    class TestCaseWithExtentReport: TestBase
    {
        [Test]
        public void ExtentReportExample1()
        {
            Test().Info("Step One Test Execution");
            Test().Pass("Step Two Pass assert");
            Test().Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            Test().Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample2()
        {
            Test().Info("Step One Test Execution");
            Test().Pass("Step Two Pass assert");
            //Test().Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            Test().Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample3()
        {
            Test().Info("Step One Test Execution");
            Test().Pass("Step Two Pass assert");
            //Test().Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            Test().Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample4()
        {
            Test().Info("Step One Test Execution");
            Test().Pass("Step Two Pass assert");
            //Test().Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            Test().Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample5()
        {
            Test().Info("Step One Test Execution");
            Test().Pass("Step Two Pass assert");
            //Test().Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            Test().Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }

        [Test]
        public void ExtentReportExample6()
        {
            Test().Info("Step One Test Execution");
            Test().Pass("Step Two Pass assert");
            //Test().Fail("Step Three failed step").AddScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot");
            Test().Pass("Step Four Passed Screen shot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\Hunza\Desktop\failedscreen.png", "Failed Screen Shot").Build());
        }
    }
}
