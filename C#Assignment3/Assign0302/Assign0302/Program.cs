// See https://aka.ms/new-console-template for more information
using System;

class FibonacciMethod
{
    public static int Fibonacci(int num1)
    {
        int number = num1 - 1;
        int[] Fib = new int[number + 1];
        Fib[0] = 1;
        Fib[1] = 1;
        for(int i = 2; i <= number; i++)
        {
            Fib[i] = Fib[i - 2] + Fib[i - 1];
        }
        return Fib[number];
    }

    static void Main(String[] args)
    {
        int len = 10;
        int a = 1, b = 1, c = 0;
        Console.Write("{1} {1}", a, b);
        for(int i = 2; i < len; i++)
        {
            c = a + b;
            Console.Write(" {0}", c);
            a = b;
            b = c;
        }
    }
}
