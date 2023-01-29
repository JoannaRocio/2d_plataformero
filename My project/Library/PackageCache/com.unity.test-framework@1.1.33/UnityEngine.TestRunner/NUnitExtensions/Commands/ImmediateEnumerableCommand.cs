<<<<<<< HEAD
﻿using System;
using System.Collections;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEngine.TestTools
{
    internal class ImmediateEnumerableCommand : DelegatingTestCommand
    {
        public ImmediateEnumerableCommand(TestCommand innerCommand)
            : base(innerCommand) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            if (innerCommand is IEnumerableTestMethodCommand)
            {
                var executeEnumerable = ((IEnumerableTestMethodCommand)innerCommand).ExecuteEnumerable(context);
                foreach (var iterator in executeEnumerable)
                {
                    if (iterator != null)
                    {
                        throw new Exception("Only null can be yielded at this point.");
                    }
                }
                return context.CurrentResult;
            }

            return innerCommand.Execute(context);
        }
    }
}
=======
﻿using System;
using System.Collections;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEngine.TestTools
{
    internal class ImmediateEnumerableCommand : DelegatingTestCommand
    {
        public ImmediateEnumerableCommand(TestCommand innerCommand)
            : base(innerCommand) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            if (innerCommand is IEnumerableTestMethodCommand)
            {
                var executeEnumerable = ((IEnumerableTestMethodCommand)innerCommand).ExecuteEnumerable(context);
                foreach (var iterator in executeEnumerable)
                {
                    if (iterator != null)
                    {
                        throw new Exception("Only null can be yielded at this point.");
                    }
                }
                return context.CurrentResult;
            }

            return innerCommand.Execute(context);
        }
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
