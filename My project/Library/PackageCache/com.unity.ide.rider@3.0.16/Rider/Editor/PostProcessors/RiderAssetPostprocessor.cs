<<<<<<< HEAD
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  internal class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderInstallation(path))
        return !ProjectGeneration.ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
=======
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  internal class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderInstallation(path))
        return !ProjectGeneration.ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
}