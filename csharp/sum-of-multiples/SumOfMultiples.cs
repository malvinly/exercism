using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var multiplesWithoutZero = multiples.Where(x => x > 0);

        return Enumerable
            .Range(1, max - 1)
            .Where(x => multiplesWithoutZero.Any(m => x % m == 0))
            .Sum();
    }
}