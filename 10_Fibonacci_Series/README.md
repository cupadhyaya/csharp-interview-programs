# Fibonacci Series

A console program that prints the Fibonacci series up to a specified count. The Fibonacci sequence starts with 0 and 1, and each subsequent number is the sum of the previous two.

## Program source (Program.cs)
```csharp
Console.WriteLine("Hello, Welcome to Fibonacci Series Program!");
Console.Write("Please enter number to get Series : ");
int number = int.Parse(Console.ReadLine());
int firstNumber = 0, secondNumber = 1, nextNumber;
Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);

for (int i=1;i<number; i++)
{
    nextNumber = firstNumber + secondNumber;
    Console.WriteLine(nextNumber);
    firstNumber = secondNumber;
    secondNumber = nextNumber;
}
```

## How it works
- Reads `number` as the count of terms to print.
- Prints the first two Fibonacci numbers (0 and 1), then iteratively computes and prints subsequent terms using the sum of the previous two values.

## Sample runs
- Input: `5`
  Output:
  0
  1
  1
  2
  3

- Input: `1`
  Output:
  0

## Complexity
- Time: O(n) where n is the number of terms requested.
- Space: O(1).

## Edge cases & suggestions
- If `number` is 0 or negative, the behavior should be defined (e.g., print nothing or print a message).
- The current implementation always prints the first two numbers; adjust logic to handle `number` smaller than 2.
- For large indices, values will overflow int; use long or BigInteger if necessary.
- Consider using previous two values only (current approach) to maintain O(1) space.

## Variations & interview follow-ups
- Compute nth Fibonacci number using fast doubling or matrix exponentiation in O(log n).
- Use memoization or dynamic programming to compute Fibonacci values when needed multiple times.
- Generate Fibonacci with yield return (IEnumerable) for streaming results.

## How to run
- .NET CLI: run `dotnet run` in this project folder.
- Visual Studio: set project as Startup Project and press F5.
