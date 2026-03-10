using System;

int[] numbers = { 10, 25, 7, 42, 18, 33 };

Console.Write("배열: ");

foreach (int number in numbers)
{
    Console.Write($"{number} ");
}

Func<int[], int> factory = numbers =>
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum;
};

Console.WriteLine($"\n합계: {ProcessArray(numbers, factory)}");

factory = numbers =>
{
    int max = int.MinValue;
    foreach (int number in numbers)
    {
        max = (number > max) ? number : max;
    }

    return max;
};

Console.WriteLine($"최댓값: {ProcessArray(numbers, factory)}");

factory = numbers =>
{
    int min = int.MaxValue;
    foreach (int number in numbers)
    {
        min = (number < min) ? number : min;
    }

    return min;
};

Console.WriteLine($"최솟값: {ProcessArray(numbers, factory)}");

factory = numbers =>
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0) count++;
    }

    return count;
};

Console.WriteLine($"짝수 개수: {ProcessArray(numbers, factory)}");

static int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}