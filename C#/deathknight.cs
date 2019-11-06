using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Class1
{
    public static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        bool lose = false;
        int wins = 0;
        string[] inputs = new string[count];
        for (int i = 0; i < count; i++)
        {
            inputs[i] = Console.ReadLine();
        }

        foreach (string x in inputs)
        {
            char[] skills = x.ToCharArray();
            for (int i = 0; i < skills.Length - 1; i++)
            {
                if (skills[i] == 67 && skills[i + 1] == 68)
                {
                    lose = true;
                }
            }
            if (!lose)
            {
                wins += 1;
            }
            lose = false;
        }

        Console.WriteLine(wins);
        Console.ReadKey();
    }
}
