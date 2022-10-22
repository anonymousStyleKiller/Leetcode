using System.Collections.Generic;

namespace LeetCode.Array;


public static class Roman
{
    public static int RomainToInt(string s)
    {
        var result = 0;

        Dictionary<string, int> dictionary = new()
        {
            { "I", 1 },
            { "IV", 4 },
            { "V", 5 },
            { "IX", 9 },
            { "X", 10 },
            { "XL", 40 },
            { "L", 50 },
            { "XC", 90 },
            { "C", 100 },
            { "CD", 400 },
            { "D", 500 },
            { "CM", 900 },
            { "M", 1000 },
        };

        for (int i = 0; i < s.Length; i++)
        {
            var x = s.Substring(i, 1);
            if ((x.Equals("I") || x.Equals("X") || x.Equals("C")) && i < s.Length - 1)
            {
                x = s.Substring(i, 2);
                if (dictionary.ContainsKey(x))
                {
                    result += Compare(dictionary, x);
                    i++;
                    continue;
                }
            }

            x = s.Substring(i, 1);
            result += Compare(dictionary, x);
        }


        return result;
    }

    private static int Compare(Dictionary<string, int> dictionary, string x)
    {
        return dictionary[x];
    }
}