<<<<<<< HEAD
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    interface ITestListCache
    {
        void CacheTest(TestPlatform platform, ITest test);
        IEnumerator<ITestAdaptor> GetTestFromCacheAsync(TestPlatform platform);
    }
}
=======
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    interface ITestListCache
    {
        void CacheTest(TestPlatform platform, ITest test);
        IEnumerator<ITestAdaptor> GetTestFromCacheAsync(TestPlatform platform);
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
