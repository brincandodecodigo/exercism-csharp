using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var chars = phrase
            .Replace("-", " ")
            .Replace("_", " ")
            .Trim()
            .ToCharArray();

        var acronym = new StringBuilder(chars[0].ToString().ToUpper());
        for (int i = 0; i < chars.Count(); i++)
        {
            if (char.IsWhiteSpace(chars[i]))
            {
                var abbreviateChar = chars[i + 1];
                if (char.IsLetter(abbreviateChar))
                {
                    acronym.Append(abbreviateChar.ToString().ToUpper());
                }
            }
        }

        return acronym.ToString();
    }
}