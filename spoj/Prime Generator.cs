using System;
using System.Text;

class Test
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        while(num > 0)
        {
            string[] nums = Console.ReadLine().Split(' ');
            int min = Math.Min(int.Parse(nums[0]), int.Parse(nums[1]));
            int max = Math.Max(int.Parse(nums[0]), int.Parse(nums[1]));

            OutputPrimes(min, max);

            num--;
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 3)
        {
            return num > 1;
        }
        else if (num % 2 == 0 || num % 3 == 0)
        {
            return false;
        }
        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
            {
                return false;
            }
        }
        return true;

    }

    static void OutputPrimes(int min, int max)
    {
        for(int i = min; i <= max; i ++)
        {
            if (IsPrime(i))
                Console.WriteLine(i);
        }

        Console.WriteLine();
    }
}
