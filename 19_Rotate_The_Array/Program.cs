static void RotateArray(int[] nums)
{
    int last = nums[nums.Length - 1];

    for(int i = nums.Length-1; i >0; i--)
    {
        nums[i] = nums[i - 1];
    }

    nums[0] = last;
}

int k = 2;

int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

for(int i = 0; i < k; i++)
{
    RotateArray(nums);
}

foreach(var item in nums)
{
    Console.WriteLine(item);
}

