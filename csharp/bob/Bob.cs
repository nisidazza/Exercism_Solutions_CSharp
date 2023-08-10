using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        bool isAQuestion = statement.TrimEnd().EndsWith("?");

        if (IsCapital(statement) && isAQuestion) return "Calm down, I know what I'm doing!";
        if (IsCapital(statement)) return "Whoa, chill out!";
        if (isAQuestion) return "Sure.";
        if (string.IsNullOrWhiteSpace(statement)) return "Fine. Be that way!";
        else return "Whatever.";
    }

    public static bool IsCapital(string statement)
    {
        return statement.Any(char.IsLetter) && statement == statement.ToUpper();
    }

}