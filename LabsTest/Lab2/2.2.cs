using System;

class Programs
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int R = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0 && x * x + y * y < R * R)
        {
            Console.WriteLine("Yes, in zone");
        }
        else if (x < 0 && y < 0 && x * x + y * y < R * R)
        {
            Console.WriteLine("Yes, in zone");
        }
        else if (-R < x && x < 0 && y == 0)
        {
            Console.WriteLine("Yes, in zone");
        }
        else if (x < 0 && y > 0 && x * x + y * y < R * R)
        {
            Console.WriteLine("Yes, in zone");
        }
        else if (x == 0 && 0 < y && y < R)
        {
            Console.WriteLine("Yes, in zone");
        }
        else if (x > 0 && y < 0 && x * x + y * y < R * R)
        {
            Console.WriteLine("Not in zone");
        }
        else if (x < 0 && y > 0 && x * x + y * y < R * R)
        {
            Console.WriteLine("Not in zone");
        }
        else if (-R <= y && y <= 0 && x == 0)
        {
            Console.WriteLine("On the line");
        }
        else if (y - x == R)
        {
            Console.WriteLine("On the line");
        }
        else if (x > 0 && y > 0 && x * x + y * y == R * R)
        {
            Console.WriteLine("On the line");
        }
        else if (x < 0 && y < 0 && x * x + y * y == R * R)
        {
            Console.WriteLine("On the line");
        }
        else
        {
            Console.WriteLine("Not in zone");
        }
    }
}