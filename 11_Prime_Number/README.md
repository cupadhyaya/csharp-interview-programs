# Prime Number

A console program that determines whether a given integer is a prime number. A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.

## Program source (Program.cs)
```csharp
Console.WriteLine("Hello, Welcome to Prime Number Program!");
Console.WriteLine("Please Enter Number to Check Prime Or Not");

int number = int.Parse(Console.ReadLine());
bool isPrime = true;

for (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        isPrime = false;
        break;
    }
}
if (isPrime == false)
{
    Console.WriteLine($"The given number {number} is Not Prime");
}
else
{
    Console.WriteLine($"The given number {number} is Prime");
}
```

## How it works
- Reads an integer `number` from input.
- Assumes `isPrime` true and checks divisibility by all integers from 2 up to (number-1). If any divisor divides evenly, the number is not prime.

## Sample runs
- Input: `7`
  Output: The given number 7 is Prime

- Input: `8`
  Output: The given number 8 is Not Prime

## Complexity
- Time: O(n) with the current algorithm — checks divisibility up to number-1.
- Space: O(1).

## Improvements & suggestions
- Handle numbers <= 1 explicitly: 0 and 1 are not prime.
- Optimize: Only check divisors up to sqrt(number) and skip even numbers after checking 2, reducing complexity to O(sqrt(n)).
- Use deterministic Miller-Rabin or other probabilistic tests for very large numbers.
- Input parsing: use int.TryParse for robust handling.

## Interview follow-ups
- Q: How to improve performance? A: Check up to sqrt(n) and skip even divisors; use better primality tests for very large numbers.
- Q: What about negative numbers? A: Primality is usually defined for positive integers > 1; treat negatives as non-prime or use absolute value depending on context.

## How to run
- .NET CLI: run `dotnet run` in this project folder.
- Visual Studio: set project as Startup Project and press F5.
