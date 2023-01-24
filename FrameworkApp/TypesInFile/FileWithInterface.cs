#region header region

// FileRename
// FileWithInterface.cs

#endregion

namespace ManyClassesGenerated;

public abstract class FileWithInterface
{
    public abstract void Test();
}

public class UseFileWithInterface
{
    public void Test(FileWithInterface fileWithInterface)
    {
        var t = 0;
    }
}