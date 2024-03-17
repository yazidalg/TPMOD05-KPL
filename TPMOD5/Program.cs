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
        HeloGeneric helo = new HeloGeneric();
        DataGeneric<string> data = new DataGeneric<string>("130223047");
        helo.SapaUser<string>("Al");
        data.PrintData();
    }
}

﻿public class HeloGeneric
{
    public void SapaUser<T>(T sapa)
    {
        Console.WriteLine("hello user " + sapa);
    }
}