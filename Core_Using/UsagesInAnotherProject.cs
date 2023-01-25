#region header region

// FileRename
// UsagesInAnotherProject.cs

#endregion

using Core_Used;

namespace Core_Using;

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