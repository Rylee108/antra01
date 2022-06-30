using System;
class ReverseString
{
    static String wordReverse(String str)
    {
        int i = str.Length - 1;
        int start, end = i + 1;
        String result = "";

        while (i >= 0)
        {
            if (str[i] == ' ')
            {
                start = i + 1;
                while (start != end)
                    result += str[start++];

                result += ' ';

                end = i;
            }
            i--;
        }

        start = 0;
        while (start != end)
            result += str[start++];

        return result;
    }

    // Driver code
    public static void Main()
    {
        String str = "ANTRA IS GOOD";

        Console.Write(wordReverse(str));
    }
}