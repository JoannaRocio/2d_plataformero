<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
