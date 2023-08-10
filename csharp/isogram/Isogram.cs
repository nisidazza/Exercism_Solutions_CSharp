using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string lowerCaseWord = word.ToLower();
        for (int i = 0; i < lowerCaseWord.Length; i++)
        {
            char wordOneLetter = lowerCaseWord[i];
            for (int j = 0; j < lowerCaseWord.Length; j++)
            {
                char wordTwoLetter = lowerCaseWord[j];
                if (wordOneLetter == wordTwoLetter && i != j && OneAndTwoAreALetters(wordOneLetter, wordTwoLetter))
                {
                    return false;
                }
            }
        }
        return true;
    }

    private static bool OneAndTwoAreALetters(char letterOne, char letterTwo)
    {
        return char.IsLetter(letterOne) && char.IsLetter(letterTwo);
    }
}
