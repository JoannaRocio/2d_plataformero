<<<<<<< HEAD
namespace Packages.Rider.Editor.ProjectGeneration {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string name)
    {
      return SolutionGuidGenerator.GuidForProject(name);
    }
  }
}
=======
namespace Packages.Rider.Editor.ProjectGeneration {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string name)
    {
      return SolutionGuidGenerator.GuidForProject(name);
    }
  }
}
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
