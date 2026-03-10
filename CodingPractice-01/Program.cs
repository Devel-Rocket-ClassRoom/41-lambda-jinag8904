using System;

// 1.
{
    PrintMessage print = () => Console.WriteLine("안녕하세요.");
    print();
}
Console.WriteLine();

// 2.
{
    Transformer square = x => x * x;
    Console.WriteLine(square(3));
    Console.WriteLine(square(4));
}
Console.WriteLine();

// 3.
{
    IsLonger isLong = (string msg, int len) => msg.Length > len;
    Console.WriteLine(isLong("안녕하세요.", 5));
    Console.WriteLine(isLong("반갑습니다.", 10));
}
Console.WriteLine();

// 4.
{
    Greeting greeting = () =>
    {
        Console.WriteLine("안녕하세요.");
        Console.WriteLine("반갑습니다.");
    };

    greeting();
}
Console.WriteLine();

// 5.
{
    Calculator add = (a, b) =>
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
        return a + b;
    };

    int sum = add(3, 5);
    Console.WriteLine($"합계: {sum}");
}
Console.WriteLine();

// 5.
delegate int Calculator(int a, int b);

// 4.
delegate void Greeting();

// 3.
delegate bool IsLonger(string s, int i);

// 2.
delegate int Transformer(int i);

// 1.
delegate void PrintMessage();