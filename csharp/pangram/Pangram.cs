public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char[] alphabetArray;
        alphabetArray = alphabet.ToCharArray(0, 26);

        foreach (char letter in alphabetArray)
        {
            if (!input.ToLower().Contains(letter))
            {
                return false;
            }
        }
        return true;
        
    }
}
