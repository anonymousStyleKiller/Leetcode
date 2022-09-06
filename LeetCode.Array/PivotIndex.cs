namespace LeetCode.Array;

public static class PivotIndex
{
    public static int Find(int[] nums)
    {
        var left = 0;
        var right = nums.Sum();
        for (int i = 0; i < nums.Length; i++)
        {
            right -= nums[i];
            if (left == right)
            {
                return i;
            }
            left += nums[i];
        }

        return -1;
    }
}