<<<<<<< HEAD
using UnityEngine;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    [InitializeOnLoad]
    static class RerunCallbackInitializer
    {
        static RerunCallbackInitializer()
        {
            var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();

            var rerunCallback = ScriptableObject.CreateInstance<RerunCallback>();
            testRunnerApi.RegisterCallbacks<RerunCallback>(rerunCallback);
        }
    }
}
=======
using UnityEngine;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    [InitializeOnLoad]
    static class RerunCallbackInitializer
    {
        static RerunCallbackInitializer()
        {
            var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();

            var rerunCallback = ScriptableObject.CreateInstance<RerunCallback>();
            testRunnerApi.RegisterCallbacks<RerunCallback>(rerunCallback);
        }
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
