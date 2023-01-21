namespace Multi;

public class Preprocessor1
{
#if NET6_0
    public Preprocessor1()
    {
    }
    #else
    public string Name { get; set; }
        public Preprocessor1(string name)
    {
        Name = name;    
    }
#endif

}