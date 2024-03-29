<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class UtpMessageReporter : IUtpMessageReporter
    {
        public ITestRunnerApiMapper TestRunnerApiMapper;
        public IUtpLogger Logger;

        public UtpMessageReporter(IUtpLogger utpLogger, string projectRepoPath)
        {
            TestRunnerApiMapper = new TestRunnerApiMapper(projectRepoPath);
            Logger = utpLogger;
        }

        public void ReportTestRunStarted(ITestAdaptor testsToRun)
        {
            var msg = TestRunnerApiMapper.MapTestToTestPlanMessage(testsToRun);

            Logger.Log(msg);
        }

        public void ReportTestStarted(ITestAdaptor test)
        {
            if (test.IsSuite)
                return;

            var msg = TestRunnerApiMapper.MapTestToTestStartedMessage(test);

            Logger.Log(msg);
        }

        public void ReportTestFinished(ITestResultAdaptor result)
        {
            if (result.Test.IsSuite)
                return;

            var msg = TestRunnerApiMapper.TestResultToTestFinishedMessage(result);

            Logger.Log(msg);
        }
    }
}
=======
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class UtpMessageReporter : IUtpMessageReporter
    {
        public ITestRunnerApiMapper TestRunnerApiMapper;
        public IUtpLogger Logger;

        public UtpMessageReporter(IUtpLogger utpLogger, string projectRepoPath)
        {
            TestRunnerApiMapper = new TestRunnerApiMapper(projectRepoPath);
            Logger = utpLogger;
        }

        public void ReportTestRunStarted(ITestAdaptor testsToRun)
        {
            var msg = TestRunnerApiMapper.MapTestToTestPlanMessage(testsToRun);

            Logger.Log(msg);
        }

        public void ReportTestStarted(ITestAdaptor test)
        {
            if (test.IsSuite)
                return;

            var msg = TestRunnerApiMapper.MapTestToTestStartedMessage(test);

            Logger.Log(msg);
        }

        public void ReportTestFinished(ITestResultAdaptor result)
        {
            if (result.Test.IsSuite)
                return;

            var msg = TestRunnerApiMapper.TestResultToTestFinishedMessage(result);

            Logger.Log(msg);
        }
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
