namespace LeetCode.Array;

public static class IsIsomorphic
{
    public static bool Check(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] m1 = new int[256];
        int[] m2 = new int[256];
        int n = s.Length;
        for (int i = 0; i < n; i++)
        {
            char c1 = s[i];
            char c2 = t[i];
            if (m1[c1] != m2[c2]) return false;
            m1[c1] = i + 1;
            m2[c2] = i + 1;
        }
        return true;
    }
}