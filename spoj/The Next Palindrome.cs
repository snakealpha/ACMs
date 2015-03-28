using System;
using System.Text;

class Test
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        while (num > 0)
        {
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
                return;
            else
                Console.WriteLine(Algo(s));

            num--;
        }
    }

    static string Algo(string arg)
    {
        StringBuilder collection = new StringBuilder(arg);
        bool setted = false;
        int middleIndex = collection.Length / 2 + ((collection.Length % 2 == 0) ? 0 : 1);
        int length = collection.Length;
        int i = 0;
        for (; i < middleIndex; i++)
        {
            char l = collection[i];
            char r = collection[length - 1 - i];
            if (l > r)
                setted = true;
            else if (l < r)
                setted = false;
            collection[length - 1 - i] = collection[i];
        }

        if (!setted)
        {
            int addition = (int)collection[middleIndex - 1] + 1;

            i = middleIndex - 1;
            int ei = 0;
            for (; i >= 0; i--)
            {
                ei = collection[i] - '0' + 1;
                collection[i] = collection[length - i - 1] = (char)('0' + ei % 10);
                if (ei < 10)
                    break;
            }
            if (ei >= 10)
                return Algo("1" + collection.ToString());
        }

        return collection.ToString();
    }
}
