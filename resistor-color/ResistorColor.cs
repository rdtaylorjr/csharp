using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        for (int i = 0; i < Colors().Length - 1; ++i)
        {
            if (color == Colors()[i])
            {
                return i;
            }
        }
        return 0;
    }

    public static string[] Colors() => new[]
        { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
}