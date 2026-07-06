# Odd or Even Number

This is a small console application that reads a single integer from standard input and reports whether the number is odd or even. The program includes basic input validation and demonstrates simple arithmetic and conditional logic in C#.

## What this program demonstrates
- Reading user input from the console
- Parsing strings to integers safely (with try/catch in the current code)
- Using the modulus operator (%) to determine odd/even
- Basic validation for positive integers (current behavior)

## Program source (Program.cs)
```csharp
try
{
    Console.WriteLine("Please Enter Number to Find Wether Odd or Even...");
    int number = int.Parse(Console.ReadLine());
    if (number > 0)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("The Given Number is Even");
        }
        else
        {
            Console.WriteLine("The Given Number is Odd");
        }
    }
    else
    {
        Console.WriteLine("Please Enter a Valid Number");
    }
}
catch
{
    Console.WriteLine("Enter only numbers...");
}
```

## Code explanation (step by step)
- Prompt: The program prints a message asking the user to enter a number.
- Read & parse: Console.ReadLine() reads a line; int.Parse converts it to an integer. The code wraps parsing in a try/catch to handle non-numeric input.
- Validation: The program requires the number to be greater than zero and prints a validation message for non-positive values.
- Odd/even check: number % 2 == 0 tests whether the remainder is zero. If so, the number is even; otherwise it is odd.
- Error handling: If parsing fails (for example user types "abc"), the catch block prints an instruction to enter numbers only.

## Sample runs
- Valid even input
  Input:  42
  Output: The Given Number is Even

- Valid odd input
  Input:  7
  Output: The Given Number is Odd

- Non-numeric input
  Input:  abc
  Output: Enter only numbers...

- Non-positive input
  Input:  0
  Output: Please Enter a Valid Number

## Complexity
- Time complexity: O(1) — a constant amount of work.
- Space complexity: O(1) — only a few scalar variables are used.

## Edge cases & suggestions for improvement
- Negative numbers: current program treats non-positive numbers (<= 0) as invalid. If you want to support negative integers, remove or change the validation.
- Robust parsing: prefer int.TryParse to avoid exceptions when parsing invalid input and to provide clearer control flow.
- Repeated prompting: improve UX by looping until valid input is provided instead of exiting on invalid input.
- Large numbers: int.Parse will throw for values outside the 32-bit signed range. Use long.TryParse if larger integers are expected.

Improved parsing example (recommended):
```csharp
Console.WriteLine("Enter an integer:");
string? s = Console.ReadLine();
if (int.TryParse(s, out int n))
{
    Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
}
else
{
    Console.WriteLine("Invalid input. Enter a valid integer.");
}
```

## Variations (common interview follow-ups)
- Determine odd/even without using modulus (e.g., using bitwise operator: (n & 1) == 0 for even).
- Process a list of numbers and count how many are odd/even.
- Find the first odd/even number in a stream efficiently.

## Typical interview questions about this problem
- Q: How does the modulus operator work for negative numbers? A: In C#, the sign of the remainder follows the dividend; however, when checking odd/even, using n % 2 works consistently for positive and negative integers (e.g., -3 % 2 == -1, but checking (n & 1) == 1 or (n % 2 != 0) is preferred when supporting negatives).
- Q: How would you handle very large integers? A: Use types that support larger ranges (long, BigInteger) and parse accordingly (TryParse variants).
- Q: Can you determine odd/even using bit operations? A: Yes, (n & 1) == 0 indicates even, (n & 1) == 1 indicates odd for non-negative numbers; for signed negatives, the low bit still indicates parity.
- Q: What is the time and space complexity? A: O(1) time and O(1) space.

## How to run
- .NET CLI: open a terminal in this project folder and run `dotnet run`.
- Visual Studio: set the project as Startup Project and press F5.

---
If you want, I can update Program.cs to use int.TryParse with a loop, add unit tests, or implement the swap-without-temp program in the other project. 

