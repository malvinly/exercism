using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string lowerCase = input.ToLower();

        for (int letter = 'a'; letter <= 'z'; letter++)
        {
            if (!lowerCase.Contains((char)letter))
                return false;
        }

        return true;
    }
}
