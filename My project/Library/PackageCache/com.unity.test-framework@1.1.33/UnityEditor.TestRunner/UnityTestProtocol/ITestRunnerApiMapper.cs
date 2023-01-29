<<<<<<< HEAD
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    interface ITestRunnerApiMapper
    {
        string GetRunStateFromResultNunitXml(ITestResultAdaptor result);
        TestState GetTestStateFromResult(ITestResultAdaptor result);
        List<string> FlattenTestNames(ITestAdaptor testsToRun);
        TestPlanMessage MapTestToTestPlanMessage(ITestAdaptor testsToRun);
        TestStartedMessage MapTestToTestStartedMessage(ITestAdaptor test);
        TestFinishedMessage TestResultToTestFinishedMessage(ITestResultAdaptor result);
    }
}
=======
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    interface ITestRunnerApiMapper
    {
        string GetRunStateFromResultNunitXml(ITestResultAdaptor result);
        TestState GetTestStateFromResult(ITestResultAdaptor result);
        List<string> FlattenTestNames(ITestAdaptor testsToRun);
        TestPlanMessage MapTestToTestPlanMessage(ITestAdaptor testsToRun);
        TestStartedMessage MapTestToTestStartedMessage(ITestAdaptor test);
        TestFinishedMessage TestResultToTestFinishedMessage(ITestResultAdaptor result);
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
