using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word) =>
        word
            .ToLower()
            .Where(char.IsLetter)
            .GroupBy(x => x)
            .All(x => x.Count() == 1);
}
