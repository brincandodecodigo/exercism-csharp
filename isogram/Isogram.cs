using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (string.IsNullOrEmpty(word)) return true;

        var chars = word.Replace(" ", "")
            .Replace("-", "")
            .ToLower()
            .ToCharArray();

        foreach (var c in chars)
        {
            if (chars.Count(x => x == c) > 1)
            {
                return false;
            }
        }

        return true;
    }
}
