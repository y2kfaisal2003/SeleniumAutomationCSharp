using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;

namespace AutomationFramework.Utilities.Framework.ExtentReport
{
    class ExtentService
    {
        private static readonly Lazy<ExtentReports> _lazy =
        new Lazy<ExtentReports>(() => new ExtentReports());

        public static ExtentReports Instance { get { return _lazy.Value; } }

        static ExtentService()
        {
            var reporter = new ExtentHtmlReporter(TestContext.CurrentContext.TestDirectory);
            reporter.Config.Theme = Theme.Standard;
            Instance.AttachReporter(reporter);
        }

        private ExtentService()
        {
        }
    }
}
