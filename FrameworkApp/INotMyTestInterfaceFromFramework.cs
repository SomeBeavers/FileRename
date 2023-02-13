namespace FrameworkApp
{
    // I am ITestInterfaceFromFramework interface.
    public interface IMyTestInterfaceFromFramework
    {
        void Test();
    }

    /// <summary>
    /// TestInterfaceFromFramework2 derives from ITestInterfaceFromFramework
    /// </summary>
    class TestInterfaceFromFramework2 : IMyTestInterfaceFromFramework
    {
        public void Test()
        {
            throw new System.NotImplementedException();
        }
    }
}