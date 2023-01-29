<<<<<<< HEAD
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyLoadProxy : IAssemblyLoadProxy
    {
        public IAssemblyWrapper Load(string assemblyString)
        {
            return new AssemblyWrapper(Assembly.Load(assemblyString));
        }
    }
}
=======
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyLoadProxy : IAssemblyLoadProxy
    {
        public IAssemblyWrapper Load(string assemblyString)
        {
            return new AssemblyWrapper(Assembly.Load(assemblyString));
        }
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
