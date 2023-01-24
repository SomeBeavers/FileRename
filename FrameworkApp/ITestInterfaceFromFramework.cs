namespace FrameworkApp
{
    // I am ITestInterfaceFromFramework interface.
    public interface ITestInterfaceFromFramework
    {
        void Test();
    }

    /// <summary>
    /// TestInterfaceFromFramework3 derives from ITestInterfaceFromFramework
    /// </summary>
    class TestInterfaceFromFramework3 : ITestInterfaceFromFramework
    {
        public void Test()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// TestInterfaceFromFramework2 derives from ITestInterfaceFromFramework
    /// </summary>
    class TestInterfaceFromFramework2 : ITestInterfaceFromFramework
    {
        public void Test()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// TestInterfaceFromFramework derives from ITestInterfaceFromFramework
    /// </summary>
    class TestInterfaceFromFramework : ITestInterfaceFromFramework
    {
        public void Test()
        {
            throw new System.NotImplementedException();
        }
    }
}