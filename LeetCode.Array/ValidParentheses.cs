namespace LeetCode.Array;

public static class ValidParentheses
{
    private static readonly Dictionary<char, char> _dictionary = new()
    {
        {'{', '}'},
        {'(', ')'},
        {'[', ']'},
    };

  

    public static bool IsValid(string s)
    {
         var opneningBrakets = new Stack<char>();
        if (string.IsNullOrWhiteSpace(s)) return false;
        foreach (var _char in s)
        {
            if (_dictionary.ContainsKey(_char))
            {
                opneningBrakets.Push(_char);
            }
            else
            {
                if (opneningBrakets.Count == 0 || _char != _dictionary[opneningBrakets.Peek()]) return false;
                opneningBrakets.Pop();
            }
        }

        return opneningBrakets.Count == 0;
    }
}