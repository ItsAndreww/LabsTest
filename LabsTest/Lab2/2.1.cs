using System;

int R, x, y = 0;
Console.Write("Enter R: ");
if (!int.TryParse(Console.ReadLine(), out R))
        {
            Console.WriteLine("Invalid input for R.");
            return;
        }
        Console.Write("Enter x: ");
if (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Invalid input for x.");
            return;
        }
if (-4 <= x && x <= -2)
        {
            y = x + 3;
            Console.WriteLine("y = {0}", y);
        }
else if (-2 <= x && x <= 4)
        {
            y = -(x / 2);
            Console.WriteLine("y = {0}", y);
        }
else if (4 <= x && x <= 6)
        {
            y = -2;
            Console.WriteLine("y = {0}", y);
        }
else if (6 <= x && x <= 10)
        {
            y = (int)(Math.Sqrt(R * R - (x - 8) * (x - 8)) - 2);
            Console.WriteLine("y = {0}", y);
        }
else
        {
            Console.WriteLine("Not found");
        }