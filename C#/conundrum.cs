using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Class1
{
    public static void Main(string[] args)
    {
        char[] cipher = Console.ReadLine().ToUpper().ToCharArray();
        char[] test = new char[3];
        int output = 0;
        int count = 0;
        int pos = 1;

        foreach (char x in cipher)
        {
            if (pos == 1 && x != 80)
            {
                output += 1;
            }
            else if (pos == 2 && x != 69)
            {
                output += 1;
            }
            else if (pos == 3 && x != 82)
            {
                output += 1;
            }

            if (pos == 3)
            {
                pos = 1;
            }
            else { pos += 1; }
        }

        Console.WriteLine(output);
        Console.ReadKey();
    }
}