using System;
using System.Linq;

public class Class1
{

    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        double bottles = double.Parse(input[0]) + double.Parse(input[1]);
        double cost = double.Parse(input[2]);
        double total = 0;

        while (bottles >= cost)
        {
            double spare = bottles % cost;
            double bought = (bottles - spare) / cost;
            bottles = bottles - bought*cost + bought;
            total += bought;
        }

        Console.WriteLine(total);
        Console.ReadKey();
    }
}
