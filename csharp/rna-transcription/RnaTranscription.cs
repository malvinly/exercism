using System;
using System.Linq;

public static class RnaTranscription
{
    private static readonly char[] DNA = {'A', 'C', 'G', 'T'};
    private static readonly char[] RNA = {'A', 'C', 'G', 'U'};

    public static string ToRna(string nucleotide)
    {
        if (!nucleotide.All(x => DNA.Contains(x)))
            throw new ArgumentException("Invalid DNA", nameof(nucleotide));

        char[] complement = RNA.Reverse().ToArray();

        var sequence = nucleotide
            .Select(x => complement[Array.IndexOf(DNA, x)])
            .ToArray();

        return new string(sequence);
    }
}