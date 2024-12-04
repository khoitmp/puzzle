public class Pattern
{
    private static Pattern _instance;

    public static Pattern Instance
    {
        get
        {
            return _instance ??= new Pattern();
        }
    }

    private Pattern()
    {
    }
}