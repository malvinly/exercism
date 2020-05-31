using System;
using System.Collections.Generic;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] chars = phrase
            .ToUpper()
            .Split(new [] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.First(char.IsLetter))
            .ToArray();

        return new string(chars);
    }
}