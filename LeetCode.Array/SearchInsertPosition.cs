namespace LeetCode.Array;

public static class SearchInsertPosition
{
    public static int SearchInsert(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;

        while (low <= high)
        {
            var mid = (low + high) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }
}