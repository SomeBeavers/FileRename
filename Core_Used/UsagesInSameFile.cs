namespace Core_Used;

/// <summary>
///     <see cref="UsagesInSameFile" /> is UsagesInSameFile file.
/// </summary>
public class UsagesInSameFile
{
    // this is the c-or for UsagesInSameFile
}

internal class UsagesInSameFileImpl : UsagesInSameFile
{
    /// <summary>
    ///     This is a child of <see cref="UsagesInSameFile" /> named UsagesInSameFileImpl in
    ///     UsagesInSameFile.cs -_-
    /// </summary>
    public UsagesInSameFileImpl()
    {
    }

    public UsagesInSameFile UsagesInSameFile { get; set; }

    private static void TestUsagesInSameFile(UsagesInSameFile usagesInSameFile)
    {
        if (usagesInSameFile == null)
        {
            var s =
                $"""
                {usagesInSameFile}
                """;
        }
    }
}

internal class UsagesInSameFileImplImpl : UsagesInSameFileImpl
{
}