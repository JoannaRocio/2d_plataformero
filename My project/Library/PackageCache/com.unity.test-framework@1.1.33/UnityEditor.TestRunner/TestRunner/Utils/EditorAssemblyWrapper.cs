<<<<<<< HEAD
using System.Reflection;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssemblyWrapper : AssemblyWrapper
    {
        public EditorAssemblyWrapper(Assembly assembly)
            : base(assembly) {}

        public override AssemblyName[] GetReferencedAssemblies()
        {
            return Assembly.GetReferencedAssemblies();
        }

        public override string Location { get { return Assembly.Location; } }
    }
}
=======
using System.Reflection;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssemblyWrapper : AssemblyWrapper
    {
        public EditorAssemblyWrapper(Assembly assembly)
            : base(assembly) {}

        public override AssemblyName[] GetReferencedAssemblies()
        {
            return Assembly.GetReferencedAssemblies();
        }

        public override string Location { get { return Assembly.Location; } }
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
