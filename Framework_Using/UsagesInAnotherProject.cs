#region header region

// FileRename
// UsagesInAnotherProject.cs

#endregion


using Framework_Used;

namespace Framework_Using;

/// <summary>
///     <see cref="UsagesInSameFile" /> = UsagesInSameFile.cs.
/// </summary>
public class UsagesInSameFile_UsagesInAnotherProject : UsagesInSameFile
{
    public UsagesInSameFile GetUsagesInSameFile(UsagesInSameFile usagesInSameFile)
    {
        return new UsagesInSameFile();
    }
}