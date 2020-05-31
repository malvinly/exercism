using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) =>
        new string(phrase
            .ToUpper()
            .Split(new [] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.First(char.IsLetter))
            .ToArray());
}