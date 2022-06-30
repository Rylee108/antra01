// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Step 1: instantiate the source array.
        int[] source = new int[5];
        source[0] = 1;
        source[1] = 2;
        source[2] = 3;
        source[3] = 4;
        source[4] = 5;

        // Step 2: instantiate and allocate the target array.
        int[] target = new int[5];

        // Step 3: copy the source to the target.
        Array.Copy(source, target, 5);

        // Step 4: display the target array.
        foreach (int value in target)
        {
            Console.WriteLine(value);
        }

        foreach (int value in source)
        {
            Console.WriteLine(value);
        }
    }
}
