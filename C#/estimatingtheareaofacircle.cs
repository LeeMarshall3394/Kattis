using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Class1
{
    public static void Main(string[] args)
    {
        List<string> results = new List<string>();
        List<string> inputs = new List<string>();
        bool end = false;
        
        do
        {
            inputs.Add(Console.ReadLine());

            if (inputs[inputs.Count - 1] != "0 0 0")
            {
                string[] input = inputs[inputs.Count - 1].Split(' ');
                double[] values = new double[input.Length];
                for (int i = 0; i < 3; i++)
                {
                    values[i] = double.Parse(input[i]);
                }

                double peri = values[0] * 2;
                double sArea = peri * peri;
                double tArea = Math.PI * (values[0] * values[0]);
                double eArea = values[2] / values[1] * sArea;

                results.Add(tArea + " " + eArea);
            }
            else
                end = true;
        } while (end == false);

        foreach (string x in results)
        {
            Console.WriteLine(x);
        }

        Console.ReadKey();
    }
}
