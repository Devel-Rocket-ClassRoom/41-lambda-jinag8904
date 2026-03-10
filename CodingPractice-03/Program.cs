using System;
using System.Collections.Generic;

// 1.
{
    Console.WriteLine("3의 배수:");
    var baesuOf3 = FindNumbers(n => n % 3 == 0);
    foreach (var n in baesuOf3)
    {
        Console.Write($"{n} ");
    }

    Console.WriteLine("\n제곱수:");
    var jegop = FindNumbers(n =>
    {
        int sqrt = (int)Math.Sqrt(n);
        return sqrt * sqrt == n;
    });
    foreach (var n in jegop)
    {
        Console.Write($"{n} ");
    }

    static List<int> FindNumbers(Predicate<int> predicate)
    {
        List<int> ints = new List<int>();

        for (int i = 1; i <= 100; i++)
        {
            if (predicate(i))
            {
                ints.Add(i);
            }
        }

        return ints;
    }
}
Console.WriteLine();
Console.WriteLine();

// 2.
{
    Predicate<int> isEven = i => i % 2 == 0;
    Func<int, bool> isOdd = i => i % 2 != 0;

    Console.WriteLine(isEven(4));
    Console.WriteLine(isOdd(4));
}
Console.WriteLine();

// 3.
{
    int factor = 2;

    Func<int, int> multiplier = n => n * factor;
    Console.WriteLine(multiplier(3));

    factor = 10;
    Console.WriteLine(multiplier(3));
}
Console.WriteLine();

// 4.
{
    int count = 0;

    Action increment = () => count++;
    increment();
    increment();
    increment();

    Console.WriteLine(count);
}
Console.WriteLine();

// 5.
{
    var counter = CreateCounter();

    Console.WriteLine(counter());
    Console.WriteLine(counter());
    Console.WriteLine(counter());

    static Func<int> CreateCounter()
    {
        int count = 0;
        return () =>
        {
            return count++;
        };
    }
}