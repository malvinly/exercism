using System;
using System.Linq;
using System.Numerics;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0)
            throw new ArgumentOutOfRangeException(nameof(n), "Number cannot be negative.");

        if (n > 64)
            throw new ArgumentOutOfRangeException(nameof(n), "Number cannot be greater than 64.");

        // There's no meaningful performance difference between using Math.Pow
        // and bit shifting after benchmarking it.

        // return 1UL << (n - 1);

        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        // There is a significant performance difference between adding up all the
        // squares and using the geometric summation formula. Adding the squares
        // took approximately ~19,000 ticks while using the formula took ~3000 ticks.

        // return Enumerable.Range(1, 64)
        //    .Select(Square)
        //    .Aggregate((cur, x) => cur + x);

        // Sum of geometric series
        // https://en.wikipedia.org/wiki/Geometric_series#Sum
        // Sum = a * ((1 - r^n) / (1 - r))

        ulong a = 1;
        ulong r = 2;
        BigInteger rn = BigInteger.Pow(r, 64);

        return (ulong)(a * ((1 - rn) / (1 - 2)));
    }
}