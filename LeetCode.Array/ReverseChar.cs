namespace LeetCode.Array;

public static class ReverseChar
{
    public static void ReverseString(char[] s) {
        if(s.Length ==0) return;
        var mid = s.Length / 2;
        for (int i = 0; i < mid; i++)
        {
            if(i+1==s.Length) continue;
            (s[i], s[s.Length - 1 - i])=( s[s.Length - 1 - i], s[i]);
        }
    }
}