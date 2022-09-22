namespace LeetCode.Array;

public static class ReverseWordInString
{
    public static string ReverseWords(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return s;
        var str = s.Trim().Split(' ').Where(i=>!string.IsNullOrWhiteSpace(i)).ToArray();

        var mid = str.Length / 2;
        for (int i = 0; i < mid; i++)
        {
            if(i==mid)continue;
            (str[i], str[str.Length - 1 - i]) = ( str[str.Length - 1 - i],str[i]);
        }

        var res = string.Empty;
        foreach (var item in str)
        {
            res += item + " ";
        }

        return res.Trim();
    }
}