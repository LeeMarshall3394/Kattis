using System;
using System.Linq;

public class Class1
{
    public static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[] cityCount = new int[count];
        int z = 0;

        for (int i = 0; i < count; i++)
        {
            int entries = int.Parse(Console.ReadLine());
            string[] cities = new string[entries];

            for (int j = 0; j<entries;j++)
                cities[j] = Console.ReadLine();

            cityCount[i] = cities.Distinct().Count();
        }

        while (count-- > 0)
        {
            Console.WriteLine(cityCount[z]);
            z++;
        }
        Console.ReadKey();
    }
}
