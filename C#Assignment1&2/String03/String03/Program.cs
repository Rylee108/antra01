using System;

class Palondromes
{

    public static bool checkPalin(string word)
    {
        int n = word.Length;
        word = word.ToLower();
        for (int i = 0; i < n; i++, n--)
        {
            if (word[i] != word[n - 1])
            {
                return false;
            }
        }
        return true;
    }

    // Function to count palindrome words
    public static int countPalin(string str)
    {
        // to check last word for palindrome
        str = str + " ";

        // to store each word
        string word = "";
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            // extracting each word
            if (ch != ' ')
            {
                word = word + ch;
            }
            else
            {
                if (checkPalin(word))
                {
                    count++;
                }
                word = "";
            }
        }

        return count;
    }

    // Driver code
    public static void Main(string[] args)
    {
        Console.WriteLine(countPalin("Madam " +
                   "Arora teaches malayalam"));

        Console.WriteLine(countPalin("Nitin " +
                          "speaks malayalam"));
    }
}
