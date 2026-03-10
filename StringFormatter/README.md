# 문자열 포맷터

## 문제

`Func<string, string>` 타입의 람다식을 활용하여 다양한 문자열 포맷터를 작성하세요.

1. `Func<string, string>` 타입의 변수 `toUpper`를 선언하고, 
입력 문자열을 대문자로 변환하는 람다식을 할당하세요.

2. `Func<string, string>` 타입의 변수 `mask`를 선언하고, 
입력 문자열의 앞 2글자만 남기고 나머지를 `"***"`으로 대체하는
람다식을 할당하세요. (예: `"Hello"` → `"He***"`)

3. `Func<string, string>` 타입의 변수 `greet`를 선언하고, 
입력 문자열 앞에 `"안녕하세요, "`, 뒤에 `"님!"`을 붙여 인사말을 생성하는
람다식을 할당하세요. (예: `"철수"` → `"안녕하세요, 철수님!"`)

4. `ApplyAndPrint(string input, Func<string, string> formatter)` 메서드를 
작성하세요. 이 메서드는 `formatter`를 `input`에 적용한 결과를 콘솔에 출력합니다.

5. 아래 예상 실행 결과와 동일하게 출력되도록 각 포맷터를 `ApplyAndPrint`에 전달하여
호출하세요.

## 예상 실행 결과

```
[대문자 변환] hello world → HELLO WORLD
[마스킹 처리] SecretCode → Se***
[인사말 생성] 민수 → 안녕하세요, 민수님!
```
