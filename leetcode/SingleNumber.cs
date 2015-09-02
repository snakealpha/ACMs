using System;

class Test
{
    static void Main()
    {
        Console.WriteLine(SingleNumber(new []{1, 2, 3, 5, 9, 5, 1, 3, 2}));
    }
    public static int SingleNumber(int[] nums)
    {
        for (int i = nums.Length - 1; i > 0; i--)
            nums[i - 1] ^= nums[i];

        return nums[0];
    }
}
