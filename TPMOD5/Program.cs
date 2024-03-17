public class DataGeneric<T> {
    private T Data;

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah " + Data);
    }
}

public class MainProgram
{
    public static void Main(String[] args)
    {
        DataGeneric<string> data = new DataGeneric<string>("130223047");
        data.PrintData();
    }
}