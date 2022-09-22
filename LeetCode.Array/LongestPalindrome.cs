namespace LeetCode.Array;

public  class LongestPalindrome
{
    private  int lenght = 0;
    private  int start = 0;
    public  string Find(string s)
    {
        if (s.Length is 0 or 1) return s;

        for (int i = 0; i < s.Length; i++)
        {
            ExpandFromMiddle(s, i, i);
        }

        return s.Substring(start, lenght);
    }

    private  void ExpandFromMiddle(string s, int i, int i1)
    {
        while (i >= 0 && i1<s.Length&& s[i] == s[i1])
        {
            i--;
            i1++;
        }

        if (i1 - i - 1 > lenght)
        {
            lenght = i1 - i - 1;
            start = i + 1;
        }
    }
    
}