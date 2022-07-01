using Assign0307;
using System;


class Program
{
    static void Main(string[] args)
    {
        Color color1 = new Color(20, 152, 88);
        Ball ball1 = new Ball(6, color1);

        ball1.Throw();
        ball1.Throw();
        ball1.Throw();
        Console.WriteLine("Throw count of Ball 1 before popping: " + ball1.getNumThrows());

        ball1.Pop();
        ball1.Throw();
        ball1.Throw();

        Console.WriteLine("Throw count of Ball 1 after popping: " + ball1.getNumThrows());


        Console.WriteLine();

        Color color2 = new Color(12, 29, 102, 156);
        Ball ball2 = new Ball(2, color2);

        ball2.Pop();

        for (int i = 0; i < 5; i++) ball2.Throw();

        Console.WriteLine("Ball 2 throw count: " + ball2.getNumThrows());
    }
}
