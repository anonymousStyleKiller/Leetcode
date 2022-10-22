using System.Text.RegularExpressions;

namespace LeetCode.Array;

public static class PalindromeStr
{
    public static bool IsPalindrome(string s)
    {
        // 1 
        if(string.IsNullOrWhiteSpace(s))return true;
        var str = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");
        var reverseStr = string.Empty;
        for(var i = str.Length-1; 0<=i;i--){
            reverseStr += str[i];
        }
        return str.Equals(reverseStr);
    }
}