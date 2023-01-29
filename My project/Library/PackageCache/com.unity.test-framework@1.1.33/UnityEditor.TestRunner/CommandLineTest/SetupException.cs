<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class SetupException : Exception
    {
        public ExceptionType Type { get; }
        public object[] Details { get; }

        public SetupException(ExceptionType type, params object[] details)
        {
            Type = type;
            Details = details;
        }

        public enum ExceptionType
        {
            ScriptCompilationFailed,
            PlatformNotFound,
            TestSettingsFileNotFound,
            OrderedTestListFileNotFound,
        }
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class SetupException : Exception
    {
        public ExceptionType Type { get; }
        public object[] Details { get; }

        public SetupException(ExceptionType type, params object[] details)
        {
            Type = type;
            Details = details;
        }

        public enum ExceptionType
        {
            ScriptCompilationFailed,
            PlatformNotFound,
            TestSettingsFileNotFound,
            OrderedTestListFileNotFound,
        }
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
