<<<<<<< HEAD
using JetBrains.Annotations;
using Packages.Rider.Editor;
using Unity.CodeEditor;

// ReSharper disable once CheckNamespace 
namespace JetBrains.Rider.Unity.Editor
{
  /// <summary>
  /// Is called via commandline from Rider Notification after checking out from source control.
  /// </summary>
  [UsedImplicitly]
  public static class RiderMenu
  {
    /// <summary>
    /// Is called via commandline from Rider Notification after checking out from source control.
    /// </summary>
    [UsedImplicitly]
    public static void MenuOpenProject()
    {
      if (RiderScriptEditor.IsRiderInstallation(RiderScriptEditor.CurrentEditor))
      {
        // Force the project files to be sync
        CodeEditor.CurrentEditor.SyncAll();

        // Load Project
        CodeEditor.CurrentEditor.OpenProject();
      }
    }
  }
=======
using JetBrains.Annotations;
using Packages.Rider.Editor;
using Unity.CodeEditor;

// ReSharper disable once CheckNamespace 
namespace JetBrains.Rider.Unity.Editor
{
  /// <summary>
  /// Is called via commandline from Rider Notification after checking out from source control.
  /// </summary>
  [UsedImplicitly]
  public static class RiderMenu
  {
    /// <summary>
    /// Is called via commandline from Rider Notification after checking out from source control.
    /// </summary>
    [UsedImplicitly]
    public static void MenuOpenProject()
    {
      if (RiderScriptEditor.IsRiderInstallation(RiderScriptEditor.CurrentEditor))
      {
        // Force the project files to be sync
        CodeEditor.CurrentEditor.SyncAll();

        // Load Project
        CodeEditor.CurrentEditor.OpenProject();
      }
    }
  }
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
}