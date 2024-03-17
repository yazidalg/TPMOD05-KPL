public class HeloGeneric
{
    public static void Main(String[] args)
    {
        SapaUser<String>("Al");
    }
    public static void SapaUser<T>(T sapa)
    {
        Console.WriteLine("hello user " + sapa);
    }
}