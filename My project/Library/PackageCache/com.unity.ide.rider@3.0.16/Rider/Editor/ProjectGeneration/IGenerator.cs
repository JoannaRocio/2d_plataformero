<<<<<<< HEAD
using System.Collections.Generic;

namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IGenerator
  {
    bool SyncIfNeeded(IEnumerable<string> affectedFiles, IEnumerable<string> reimportedFiles, bool checkProjectFiles = false);
    void Sync();
    bool HasSolutionBeenGenerated();
    string SolutionFile();
    IAssemblyNameProvider AssemblyNameProvider { get; }
  }
=======
using System.Collections.Generic;

namespace Packages.Rider.Editor.ProjectGeneration
{
  internal interface IGenerator
  {
    bool SyncIfNeeded(IEnumerable<string> affectedFiles, IEnumerable<string> reimportedFiles, bool checkProjectFiles = false);
    void Sync();
    bool HasSolutionBeenGenerated();
    string SolutionFile();
    IAssemblyNameProvider AssemblyNameProvider { get; }
  }
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
}