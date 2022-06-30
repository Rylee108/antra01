// See https://aka.ms/new-console-template for more information
using System;

//if executes the code, the result will print five hundreds times of the number from 0 to 499
public class FizzBuzz
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 15 == 0)
                Console.Write("FizzBuzz");
            else if (i % 3 == 0)
                Console.Write("Fizz");
            else if (i % 5 == 0)
                Console.Write("Buzz");
            else
                Console.Write(i);

            if (i < 100)
                Console.Write(",");
            if (i % 15 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();
    }
}