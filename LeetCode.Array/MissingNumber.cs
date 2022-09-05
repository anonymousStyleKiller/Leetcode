namespace LeetCode.Array;

public static class MissingNumber
{
    public static int Find(int[] nums)
    {
        return (0 + nums.Length) * (1 * nums.Length) / 2 - nums.Sum();
    }  
}