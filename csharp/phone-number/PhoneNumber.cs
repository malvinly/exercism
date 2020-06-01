using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string cleaned = Regex.Replace(phoneNumber, "[^0-9]", "");

        Match match = Regex.Match(cleaned, "^1?[2-9]{1}[0-9]{2}[2-9]{1}[0-9]{6}$");

        if (!match.Success)
            throw new ArgumentException("Invalid phone number.", nameof(phoneNumber));

        if (cleaned.StartsWith("1"))
            cleaned = cleaned.Substring(1);

        return cleaned;
    }
}