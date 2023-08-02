using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    static Dictionary<string, int> colorCodeDictionary = new Dictionary<string, int>() {
            { "Black", 0 }, { "Brown", 1 }, { "Red", 2 }, { "Orange", 3 }, { "Yellow", 4 }, { "Green", 5 }, { "Blue", 6 }, { "Violet", 7 }, { "Grey", 8 }, { "White", 9 } };

    public static int ColorCode(string color)
    {
        var colorCode = -1;

        foreach (var item in colorCodeDictionary.Where(e => e.Key.ToLower().Equals(color)))
        {
            colorCode = item.Value;
        }
        return colorCode;
    }

    public static string[] Colors()
    {
        List<string> colors = new List<string>();

        foreach (var item in colorCodeDictionary)
        {
            colors.Add(item.Key.ToLower());
        }

        return colors.ToArray();
    }

}

