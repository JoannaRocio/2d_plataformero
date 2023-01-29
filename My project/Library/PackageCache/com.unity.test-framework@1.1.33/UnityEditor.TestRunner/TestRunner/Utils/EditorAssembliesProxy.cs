<<<<<<< HEAD
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
=======
using System.Linq;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditorAssembliesProxy : IEditorAssembliesProxy
    {
        public IAssemblyWrapper[] loadedAssemblies
        {
            get { return EditorAssemblies.loadedAssemblies.OrderBy(a => a.FullName).Select(x => new EditorAssemblyWrapper(x)).ToArray(); }
        }
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
