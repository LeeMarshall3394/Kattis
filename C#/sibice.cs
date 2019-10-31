using System;

public class Class1
{
    public static void Main(string[] args)
    {
        string[] values = Console.ReadLine().Split(' ');
        int matches = Convert.ToInt32(values[0]);
        double max = Math.Sqrt(Math.Pow(int.Parse(values[1]),2) + Math.Pow(int.Parse(values[2]), 2));
        int[] lengths = new int[matches];
        int i = 0;
        foreach (int x in lengths)
        {
            lengths[i] = int.Parse(Console.ReadLine());
            i++;
        }
        i = 0;
        while (matches-- > 0)
        {
            Console.WriteLine(lengths[i] <= max ? "DA" : "NE");
            i++;
        }
    }
}
