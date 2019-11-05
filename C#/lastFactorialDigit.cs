using System;

public class Class1
{    
    public static int Fact(int x)
    {
        if (x > 1)
        { 
            return x * Fact(x-1);
        } else {
            return 1;
        }
    }

    public static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[] values = new int[count];

        int i = 0;
        foreach (int x in values)
        {
            values[i] = int.Parse(Console.ReadLine());
            i++;
        }
        i = 0;
        while (count-- > 0)
        {
            Console.WriteLine(Fact(values[i]) % 10);
            i++;
        }
        Console.ReadKey();
    }
}
