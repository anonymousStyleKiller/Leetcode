using System.Text.RegularExpressions;

namespace LeetCode.Array;

public class ValidPalindrome
{
    public bool IsPalindrome(string s) {
        if(string.IsNullOrWhiteSpace(s)) return true;
        var str = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");
        var revStr = string.Empty;
        for(var i=str.Length-1;i>=0;i--){
            revStr += str[i];
        }
        return str.Equals(revStr);
    } 
}