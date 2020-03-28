using System;
using System.Linq;

public static class Pangram
{
    static char[] alphabet = new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 
    'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

    public static bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;

        var loweredInput = input.ToLowerInvariant();
        return alphabet.All(c => loweredInput.Contains(c));
    }
}
