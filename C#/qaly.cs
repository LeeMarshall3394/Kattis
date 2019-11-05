using System;
using System.Linq;

public class Class1
{

    public static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        double[,] qaly = new double[input, 2];
        int i = 0;
        int j = 0;
        double total = 0;
        while (i < input)
        {
            string[] values = (Console.ReadLine().Split(' '));
            while (j < 2)
            {
                qaly[i, j] = double.Parse(values[j]);
                j++;
            }
            total += qaly[i, 0] * qaly[i, 1];
            i++;
            j = 0;
        }

        Console.WriteLine(total);
        Console.ReadKey();
    }
}
