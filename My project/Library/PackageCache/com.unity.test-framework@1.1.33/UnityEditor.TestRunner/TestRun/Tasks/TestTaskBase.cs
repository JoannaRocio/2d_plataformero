<<<<<<< HEAD
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class TestTaskBase
    {
        public bool SupportsResumingEnumerator;

        protected TestTaskBase(bool supportsResumingEnumerator = false)
        {
            SupportsResumingEnumerator = supportsResumingEnumerator;
        }

        public abstract IEnumerator Execute(TestJobData testJobData);
    }
=======
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class TestTaskBase
    {
        public bool SupportsResumingEnumerator;

        protected TestTaskBase(bool supportsResumingEnumerator = false)
        {
            SupportsResumingEnumerator = supportsResumingEnumerator;
        }

        public abstract IEnumerator Execute(TestJobData testJobData);
    }
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
}