// See https://aka.ms/new-console-template for more information
PatternOne();
PatternTwo();
PatternThree();
PatternFour();

void PatternOne()
{
    Console.Write("Pattern One\n");
    int x, y;

    for (x = 1; x <= 4; x++)
    {
        for (y = 4; y >= 2; y--)
        {
            if (y == x)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        for (y = 1; y <= x; y++)
        {
            if (y == x)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }

    //half//
    for (x = 2; x <= 4; x++)
    {
        for (y = 1; y <= 4; y++)
        {
            if (y == x)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        for (y = 3; y >= 2; y--)
        {
            if (y == x)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }

    for (x = 2; x <= 4; x++)
    {
        for (y = 4; y >= 2; y--)
        {
            if (y == x)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        for (y = 1; y <= x; y++)
        {
            if (y == x)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    for (x = 2; x <= 4; x++)
    {
        for (y = 1; y <= 4; y++)
        {
            if (y == x)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        for (y = 3; y >= 2; y--)
        {
            if (y == x)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

void PatternTwo()
{
    Console.Write("Pattern Two\n");
    int x, y;

    for (x = 1; x <= 6; x++)
    {
        for (y = 1; y <= 6; y++)
        {
            if (y == x)
            {
                if (y % 2 == 0)
                { Console.Write(7 - y); }
                else
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.Write(" ");
            }
        }
        for (y = 5; y >= 1; y--)
        {
            if (y == x)
            {
                if (y % 2 == 0)
                { Console.Write(7 - y); }
                else
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    for (x = 2; x <= 6; x++)
    {
        for (y = 6; y >= 2; y--)
        {
            if (y == x)
            {
                if (y % 2 == 1)
                { Console.Write(y); }
                else
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.Write(" ");
            }
        }
        for (y = 1; y <= x; y++)
        {
            if (y == x)
            {
                if (y % 2 == 1)
                { Console.Write(y); }
                else
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

void PatternThree()
{
    Console.Write("Pattern Three\n");
    int x, y;
    for (x = 1; x <= 5; x++)
    {
        for (y = 1; y <= x; y++)
        {
            Console.Write(x*y);
        }
        Console.WriteLine();
    }
        for (x = 1; x <= 4; x++)
    {
        for (y = 1; y <= 5-x; y++)
        {
            Console.Write((5-x)*y);
        }
        Console.WriteLine();
    }
}

void PatternFour()
{
    Console.Write("Pattern Four\n");
    int x, y;
    for (x = 1; x <= 6; x++)
    {
        for (y = 1; y <= 5; y++)
        {   
            if (y == x) {
                Console.Write(y);
            }
            else {
                Console.Write(x * (Math.Pow(x + 1, y - 1)));
            }

        }
        Console.WriteLine();
    }
}
