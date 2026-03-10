using System;
using System.Collections.Generic;

// 1.
{
    Action[] actions = new Action[3];

    for (int i = 0; i < 3; i++)
    {
        actions[i] = () => Console.Write(i); 
    }

    foreach (Action action in actions)
    {
        action();
    }
}
Console.WriteLine();
Console.WriteLine();

// 2.
{
    Action[] actions = new Action[3];

    for (int i = 0; i < 3; i++)
    {
        int loopVar = i;
        actions[i] = () => Console.Write(loopVar);
    }

    foreach (Action action in actions)
    {
        action();
    }
}
Console.WriteLine();
Console.WriteLine();

// 3.
{
    string[] names = { "김철수", "이영희", "박민수", "최지연" };

    Array.Sort(names, (a, b) => a.Length.CompareTo(b.Length));

    Console.WriteLine("이름 길이순 정렬:");
    foreach (string name in names) Console.WriteLine(name);

    Array.Sort(names, (a, b) => b.CompareTo(a));
    Console.WriteLine("\n역순 정렬:");
    foreach (string name in names) Console.WriteLine(name);
}
Console.WriteLine();

// 4.
{
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int answer1 = numbers.Find(n => n % 2 == 0);
    List<int> answer2 = numbers.FindAll(n => n % 2 == 0);
    bool answer3 = numbers.Exists(n => n > 8);
    bool answer4 = numbers.TrueForAll(n => n > 0);
    int answer5 = numbers.RemoveAll(n => n % 2 == 0);

    Console.WriteLine($"첫 번째 짝수: {answer1}");

    Console.Write($"모든 짝수: ");
    foreach (int n in answer2) Console.Write($"{n} ");

    Console.WriteLine($"\n8보다 큰 수 존재: {answer3}");

    Console.WriteLine($"모두 양수: {answer4}");

    Console.WriteLine($"제거된 짝수 개수: {answer5}");

    Console.Write("남은 숫자: ");
    foreach (int n in numbers) Console.Write($"{n} ");
}