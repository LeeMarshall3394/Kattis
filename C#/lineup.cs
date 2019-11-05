using System;
using System.Linq;
using System.Collections;

public class Class1
{
    //public static bool (char[] x, int y)
    //    {

    //    }

    public static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        string[] names = new string[count];
        bool asc = false, desc = false;
        string order = "Neither";
        for (int i=0;i<count; i++)
        {
            names[i] = Console.ReadLine();
        }

        for (int i = 0; i < count-1; i++)
        {
            int comp = string.Compare(names[i], names[i+1]);

            if (comp < 0)
            {
                asc = true;
            }
            else if (comp > 0)
            {
                desc = true;
            }
        }

        if (asc && desc)
            order = "Neither";
        else if (asc)
            order = "Increasing";
        else if (desc)
            order = "Decreasing";

        Console.WriteLine(order);
        Console.ReadKey();
    }
}
