using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Class1
{
    public static void Main(string[] args)
    {
        char[] cipher = Console.ReadLine().ToUpper().ToCharArray();
        char[] key = Console.ReadLine().ToUpper().ToCharArray();
        char[] keyLong = new char[cipher.Length];
        for (int i = 0; i < key.Length; i++)
        {
            keyLong[i] = key[i];
        }
        char[] output = new char[cipher.Length];
        int posCount = 0;
        char next = ' ';

        for (int i = 0; i < cipher.Length; i++)
        {
            next = Convert.ToChar(cipher[i] - (keyLong[i] - 65));

            while (next < 'A')
            {
                next = Convert.ToChar(cipher[i] + 26 - (keyLong[i] - 65));
            }
            
            if (next < 'A')
            {
                output[posCount] = next;
                if (!((posCount + key.Length) >= keyLong.Length))
                {
                    keyLong[posCount + key.Length] = next;
                }
            }
            else
            {
                output[posCount] = next;
                if (!((posCount + key.Length) >= keyLong.Length))
                {
                    keyLong[posCount + key.Length] = next;
                }
            }

            if (posCount < cipher.Length)
            {
                posCount += 1;
            }
        }

        string outString = new string(output);
        Console.WriteLine(outString);
        Console.ReadKey();
    }
}
