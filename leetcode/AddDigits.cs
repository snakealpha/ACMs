using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        Console.WriteLine(AddDigits(139));
    }

    public static int AddDigits(int num)
    {
        return num == 0 ? 0 : num - 9 * (int)Math.Floor(((double)num - 1) / 9);
    }
}
