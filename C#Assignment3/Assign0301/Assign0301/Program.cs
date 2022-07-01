// See https://aka.ms/new-console-template for more information
using System;

class ReverseNumber
{
    public static int[] GenerateNumbers()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        return arr;
    }

    public static void Reverse(int[] arr)
    {
        int i = arr[0];
        int j = arr.Length - 1;
        int temp;
        while (i < j)
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i++;
            j--;
        }
    }

    public static void PrintNumbers(int[] arr0)
    {
        for(int i = 0; i < arr0.Length; i++)
        {
            Console.Write(arr0[i] + " ");
        }
        
    }


    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);
    }

}
