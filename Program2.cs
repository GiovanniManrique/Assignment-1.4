using System;

struct Point
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        Point P1;
        Point P2;

        P1.X = 5;
        P1.Y = 3;

        P2.X = 8;
        P2.Y = 4;

        if (P2.X > P1.X)
        {
            Console.WriteLine("P2 is to the right of P1.");
        }
        else if (P2.X < P1.X)
        {
            Console.WriteLine("P2 is to the left of P1.");
        }
        else
        {
            Console.WriteLine("P2 is on the same axis as P1.");
        }
    }
}
