using System;

Func<string, string> toUpper = s => s.ToUpper();
Func<string, string> mask = s => s.Substring(0, 2) + "***";
Func<string, string> greet = s => $"안녕하세요, {s}님!";

Console.Write($"[대문자 변환] hello world -> ");
ApplyAndPrint("hello world", toUpper);

Console.Write($"[마스킹 처리] SecretCode -> ");
ApplyAndPrint("SecretCode", mask);

Console.Write($"[인사말 생성] 민수 -> ");
ApplyAndPrint("민수", greet);

static void ApplyAndPrint(string input, Func<string, string> formatter)
{
    Console.WriteLine(formatter(input));
}