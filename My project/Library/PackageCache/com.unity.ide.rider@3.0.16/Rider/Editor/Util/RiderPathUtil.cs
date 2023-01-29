<<<<<<< HEAD
﻿using System.IO;

namespace Rider.Editor.Util
{
  internal static class RiderPathUtil
  {
    public static bool IsRiderDevEditor(string editorPath)
    {
      if (editorPath == null)
        return false;
      return "rider-dev".Equals(Path.GetFileNameWithoutExtension(editorPath));
    }
  }
=======
﻿using System.IO;

namespace Rider.Editor.Util
{
  internal static class RiderPathUtil
  {
    public static bool IsRiderDevEditor(string editorPath)
    {
      if (editorPath == null)
        return false;
      return "rider-dev".Equals(Path.GetFileNameWithoutExtension(editorPath));
    }
  }
>>>>>>> e0f40ebfefea26c49915947c54ba07b371b257ac
}