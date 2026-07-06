# Swap Numbers (With Temp)

This console application demonstrates swapping two integer variables using a temporary variable. It is a basic example used to illustrate variable assignment and console I/O in C#.

## Program source (Program.cs)
```csharp
Console.WriteLine("Please Enter Two Numbers a and b");
Console.Write("Please Enter a : ");
int a=int.Parse(Console.ReadLine());
Console.Write("Please Enter b : ");
int b=int.Parse(Console.ReadLine());

Console.WriteLine($"Number before swap a={a} and b={b}");

try
{
    int temp = b;
    b = a;
    a = temp;

    Console.WriteLine($"Number after swap a={a} and b={b}");
}
catch
{
    Console.WriteLine("Enter Numbers Only......");
}
```

## Code explanation
- Prompts the user to enter two integers and reads them via Console.ReadLine followed by int.Parse.
- The values before swapping are printed for clarity.
- A temporary variable `temp` stores one value while the other assignment happens, enabling a safe swap: temp = b; b = a; a = temp.
- The try/catch around the swap is currently guarding the parsing and assignment from invalid input; prefer int.TryParse for robust parsing.

## Sample runs
- Example 1
  Input: a=3, b=5
  Output:
  Number before swap a=3 and b=5
  Number after swap a=5 and b=3

- Example 2 (invalid input)
  Input: a=one
  Output: Enter Numbers Only......

## Complexity
- Time complexity: O(1) — constant time operations.
- Space complexity: O(1) — only a few integer variables are used.

## Edge cases & suggestions
- Use int.TryParse to avoid exceptions when parsing user input and to give clearer error messages.
- Validate ranges to avoid overflow in other swap approaches (arithmetic swap can overflow for large integers).
- The current try/catch wraps the swap; better to wrap parsing separately and only proceed if both inputs are valid.

## Variations (common interview follow-ups)
- Swap without a temporary variable using arithmetic: a = a + b; b = a - b; a = a - b; (beware overflow)
- Swap using bitwise XOR: a ^= b; b ^= a; a ^= b; (works for integral types and avoids overflow but can be confusing)

## Typical interview questions
- Q: Why use a temporary variable instead of arithmetic or XOR? A: Temporary variable approach is simple, clear, and avoids overflow/edge-case pitfalls.
- Q: When might XOR swap fail? A: If a and b refer to the same memory location (not typical for value types), or if using types where bitwise XOR is not defined.
- Q: What is the performance difference? A: Differences are negligible; choose clarity unless in a micro-optimized context.

## How to run
- .NET CLI: open this project folder and run `dotnet run`.
- Visual Studio: set the project as Startup Project and press F5.

