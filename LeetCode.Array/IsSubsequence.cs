namespace LeetCode.Array;

public static class IsSubsequence
{
    public static bool Compare(string s, string t)
    {
        if(s.Equals("")) return true;
        var index = 0;
        foreach (var t1 in t)
        {
            if(t1==s[index]){
                index++;
            }
            if(index >= s.Length){
                return true;
            }
        }
        return false;
    }
}