namespace LeetCode.Array;

public static class BinarySearch
{
    public static int Search(int[]arr, int target)
    {
        var first = 0;
        var last = arr.Length - 1;
        while (first <=last)
        {
            var mid = (first + last) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target)
            {
                first = mid + 1;
            }
            else
            {
                last = mid - 1;
            }
        }

        return 0;
    }
}