<<<<<<< HEAD
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
=======
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
