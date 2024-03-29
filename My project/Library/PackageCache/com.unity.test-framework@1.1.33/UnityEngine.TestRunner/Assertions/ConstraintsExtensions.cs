<<<<<<< HEAD
using NUnit.Framework.Constraints;

namespace UnityEngine.TestTools.Constraints
{
    /// <summary>
    /// An NUnit test constraint class to test whether a given block of code makes any GC allocations.
    /// </summary>
    public static class ConstraintExtensions
    {
        /// <summary>
        /// Use this with NUnit's Assert.That() method to make assertions about the GC behaviour of your code. The constraint executes the delegate you provide, and checks if it caused any GC memory to be allocated. If any GC memory was allocated, the constraint passes; otherwise, the constraint fails.
        /// See https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/api/UnityEngine.TestTools.Constraints.AllocatingGCMemoryConstraint.html for an example.
        /// </summary>
        /// <param name="chain"></param>
        /// <returns></returns>
        public static AllocatingGCMemoryConstraint AllocatingGCMemory(this ConstraintExpression chain)
        {
            var constraint = new AllocatingGCMemoryConstraint();
            chain.Append(constraint);
            return constraint;
        }
    }
}
=======
using NUnit.Framework.Constraints;

namespace UnityEngine.TestTools.Constraints
{
    /// <summary>
    /// An NUnit test constraint class to test whether a given block of code makes any GC allocations.
    /// </summary>
    public static class ConstraintExtensions
    {
        /// <summary>
        /// Use this with NUnit's Assert.That() method to make assertions about the GC behaviour of your code. The constraint executes the delegate you provide, and checks if it caused any GC memory to be allocated. If any GC memory was allocated, the constraint passes; otherwise, the constraint fails.
        /// See https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/api/UnityEngine.TestTools.Constraints.AllocatingGCMemoryConstraint.html for an example.
        /// </summary>
        /// <param name="chain"></param>
        /// <returns></returns>
        public static AllocatingGCMemoryConstraint AllocatingGCMemory(this ConstraintExpression chain)
        {
            var constraint = new AllocatingGCMemoryConstraint();
            chain.Append(constraint);
            return constraint;
        }
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
