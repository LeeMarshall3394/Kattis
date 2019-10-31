using System;

public class Class1
{
    public static void Main(string[] args)
    {
        string line = Console.ReadLine();
        string[] values = line.Split(' ');
        Console.WriteLine(values[1]);
    }
}
