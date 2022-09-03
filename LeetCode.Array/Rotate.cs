namespace LeetCode.Array;

public class Rotate
{
    public int[] Swap(int[] initArr, int swapCount)
    {
        if (swapCount > initArr.Length) return null!;
        var count = 0;
        for (var i = 0; i < initArr.Length - 1; i++)
        {
            if (count > swapCount) break;
            for (var j = count; j < initArr.Length - 1; j++)
            {
            }

            initArr[count + 1] = initArr[count];

            initArr[count] = initArr[swapCount];
            count++;
        }

        return initArr;
    }
}