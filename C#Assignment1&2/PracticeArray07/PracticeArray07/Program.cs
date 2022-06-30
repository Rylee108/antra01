using System;

class MostFreq
{

    static int mostFrequent(int[] arr, int n)
    {

        // Sort the array
        Array.Sort(arr);

        // find the max frequency using
        // linear traversal
        int max_count = 1, res = arr[0];
        int curr_count = 1;

        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
                curr_count++;
            else
                curr_count = 1;

            // If last element is most frequent
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = arr[i - 1];
            }
        }

        return res;
    }

    // Driver code
    public static void Main()
    {

        int[] arr = { 40, 50, 30, 40, 50, 30, 30 };
        int n = arr.Length;

        Console.WriteLine(mostFrequent(arr, n));
    }
}