<<<<<<< HEAD
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal interface IUtpMessageReporter
    {
        void ReportTestFinished(ITestResultAdaptor result);
        void ReportTestRunStarted(ITestAdaptor testsToRun);
        void ReportTestStarted(ITestAdaptor test);
    }
}
=======
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal interface IUtpMessageReporter
    {
        void ReportTestFinished(ITestResultAdaptor result);
        void ReportTestRunStarted(ITestAdaptor testsToRun);
        void ReportTestStarted(ITestAdaptor test);
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
