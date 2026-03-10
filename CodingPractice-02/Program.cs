using System;

// 1.
{
    Func<int> func = () => 1234;
    Func<int, int> sqaure = i => i * i;
    Func<int, int, int> add = (a, b) => a + b;

    Console.WriteLine(func());
    Console.WriteLine(sqaure(3));
    Console.WriteLine(add(3, 5));
}
Console.WriteLine();

// 2.
{
    Action action = () => Console.WriteLine("안녕하세요!");
    Action<string> action2 = s => Console.WriteLine(s);
    Action<string, int> action3 = (s, c) =>
    {
        for (int i = 0; i < c; i++)
        {
            Console.WriteLine(s);
        }
    };

    action();
    action2("Hello, Lambda!");
    action3("반복!", 3);
}
Console.WriteLine();

// 3.
{
    Func<int, int> anonymous = delegate (int x) { return x * x; };
    Console.WriteLine(anonymous(2));

    Func<int, int> lambda = x => x * x;
    Console.WriteLine(lambda(2));
}
Console.WriteLine();