
Sample3();
void Sample1()
{
    for (int i = 1; i <= 6; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

void Sample2()
{
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            if (i != 0 && i != 5 && j != 0 && j != 5)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("*");
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void Sample3()
{
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

