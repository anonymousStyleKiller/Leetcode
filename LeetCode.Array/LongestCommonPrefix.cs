namespace LeetCode.Array;

public static class LongestCommonPrefix
{
    public static string Find(string[] strs)
    {
        var result = CommonPrefixFinder(strs, 0, strs.Length - 1);
        return result;
    }

    private static string CommonPrefixFinder(string[] strs, decimal left, decimal right)
    {
        if (left == right)
        {
            return strs[(int)left];
        }

        var middlePoint = Math.Truncate((left + right) / 2);
        var leftPart = CommonPrefixFinder(strs, left, middlePoint);
        var rightPart = CommonPrefixFinder(strs, middlePoint + 1, right);
        return CommonPrefixCalc(leftPart, rightPart);
    }

    private static string CommonPrefixCalc(string leftPart, string rightPart)
    {
        var min = Math.Min(leftPart.Length, rightPart.Length);

        for (int i = 0; i < min; i++)
        {
            if (leftPart[i] != rightPart[i]) 
                return leftPart.Substring(0, i);
        }

        return leftPart.Substring(0, min);
    }
}