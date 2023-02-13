namespace FrameworkApp
{
    // I am ITestInterfaceFromFramework interface.
    public interface ITestInterfaceFromFramework
    {
        void Test();
    }

    /// <summary>
    /// TestInterfaceFromFramework102 derives from ITestInterfaceFromFramework
    /// </summary>
    class TestInterfaceFromFramework102 : ITestInterfaceFromFramework
    {
        public void Test()
        {
            throw new System.NotImplementedException();
        }
    }
}