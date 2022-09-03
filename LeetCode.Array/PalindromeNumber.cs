using System.Text;

namespace LeetCode.Array;

public static class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        if (x == 0) return true;
        
        var firstNumberToString = new StringBuilder(x);
        var secondNumberToString = new StringBuilder(string.Empty);
        while (x >= 1)
        {
            var currentNumberToLetter = new StringBuilder(x % 10);
            secondNumberToString.Append(currentNumberToLetter);
            x /= 10;
        }

        return firstNumberToString.Equals(secondNumberToString);
    }
}