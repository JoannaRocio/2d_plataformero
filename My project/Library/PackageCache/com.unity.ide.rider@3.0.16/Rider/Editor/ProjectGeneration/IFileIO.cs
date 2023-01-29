<<<<<<< HEAD
namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IFileIO
  {
    bool Exists(string fileName);

    string ReadAllText(string fileName);
    void WriteAllText(string path, string content);

    string EscapedRelativePathFor(string file, string projectDirectory);
  }
=======
namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IFileIO
  {
    bool Exists(string fileName);

    string ReadAllText(string fileName);
    void WriteAllText(string path, string content);

    string EscapedRelativePathFor(string file, string projectDirectory);
  }
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
}