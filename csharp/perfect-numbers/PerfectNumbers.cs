using System;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be greater than 0.");

        int aliquotSum = Enumerable
            .Range(1, number / 2)
            .Where(x => number % x == 0)
            .Sum();

        return aliquotSum switch
        {
            int sum when sum == number => Classification.Perfect,
            int sum when sum > number => Classification.Abundant,
            _ => Classification.Deficient
        };
    }
}
