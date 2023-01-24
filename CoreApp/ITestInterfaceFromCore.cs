namespace CoreApp
{
    // I am ITestInterfaceFromCore interface.
    public interface ITestInterfaceFromCore
    {
        void Test();
    }

    /// <summary>
    /// TestInterfaceFromCore3 derives from ITestInterfaceFromCore
    /// </summary>
    class TestInterfaceFromCore3 : ITestInterfaceFromCore
    {
        public void Test()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// TestInterfaceFromCore2 derives from ITestInterfaceFromCore
    /// </summary>
    class TestInterfaceFromCore2 : ITestInterfaceFromCore
    {
        public void Test()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// TestInterfaceFromCore derives from ITestInterfaceFromCore
    /// </summary>
    class TestInterfaceFromCore : ITestInterfaceFromCore
    {
        public void Test()
        {
            throw new System.NotImplementedException();
        }
    }
}