#region header region

// FileRename
// FileWithAbstractClass.cs

#endregion

namespace ManyClassesGenerated;

public abstract class FileWithAbstractClass
{
    public abstract void Test();
}

public class UseFileWithInterface
{
    public void Test(FileWithAbstractClass fileWithAbstractClass)
    {
        var t = 0;
    }
}