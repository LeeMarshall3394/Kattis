using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Class1
{
    public static int sumUp(char[] a)
    {
        int b = 0;
        foreach (char x in a)
        {
            b += Convert.ToUInt16(x - 48);
        }
        return b;
    }

    public static void Main(string[] args)
    {
        bool end = false;
        List<int> output = new List<int>();
        while (!(end))
        {
            int input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                end = true;
                break;
            }
            char[] digit = Convert.ToString(input).ToCharArray();
            int total = 0;
            int total2 = 0;
            int p = 10;

            if (digit[0] != '0')
            {
                total = sumUp(digit);

                while (total != total2)
                {
                    p++;
                    digit = Convert.ToString(input * p).ToCharArray();
                    total2 = sumUp(digit);
                }
                output.Add(p);
            }
        }
        foreach (int x in output)
        {
            Console.WriteLine(x);
        }
        Console.ReadKey();
    }
}