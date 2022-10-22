using System.Collections;

namespace LeetCode.Array;

public static class GroupAnagrams
{
    public static IList<IList<string>> GroupAnagrams1(string[] strs)
    {
        IList<IList<string>> anagrams = new List<IList<string>>();
        var anagramsTable = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var sortedStr = string.Concat(str.OrderBy(c => c));
            if (anagramsTable.ContainsKey(sortedStr))
            {
                anagramsTable[sortedStr].Add(str);
            }
            else
            {
                var values = new List<string>();
                values.Add(str);
                anagramsTable.Add(sortedStr, values);
            }
        }

        foreach (var pair in anagramsTable)
        {    
            anagrams.Add(pair.Value);
        }
        return anagrams;

    }
    
}