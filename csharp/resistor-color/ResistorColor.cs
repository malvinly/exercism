using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    private static readonly Dictionary<string, int> ColorCodes =
        new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "Black", 0 },
            { "Brown", 1 },
            { "Red", 2 },
            { "Orange", 3 },
            { "Yellow", 4 },
            { "Green", 5 },
            { "Blue", 6 },
            { "Violet", 7 },
            { "Grey", 8 },
            { "White", 9 }
        };    

    public static int ColorCode(string color) 
        => ColorCodes[color];

    public static string[] Colors() 
        => ColorCodes.Keys.Select(x => x.ToLower()).ToArray();
}