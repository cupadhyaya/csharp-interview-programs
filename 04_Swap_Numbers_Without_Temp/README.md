# Swap Numbers (Without Temp)

This project is intended to demonstrate how to swap two integer values without using an explicit temporary variable. The repository's current Program.cs contains only a placeholder greeting; below are recommended implementations, explanations, and common interview considerations.

## Current file (note)
The existing Program.cs currently prints a greeting message ("Hello, World!"). To demonstrate swapping without a temp, replace the Program.cs body with one of the examples below.

## Example: Arithmetic swap (possible overflow)
```csharp
Console.Write("Enter a: ");
if (!int.TryParse(Console.ReadLine(), out int a)) { Console.WriteLine("Invalid input"); return; }
Console.Write("Enter b: ");
if (!int.TryParse(Console.ReadLine(), out int b)) { Console.WriteLine("Invalid input"); return; }

Console.WriteLine($"Before swap: a={a}, b={b}");
// arithmetic swap
a = a + b;
b = a - b; // now b holds original a
a = a - b; // now a holds original b

Console.WriteLine($"After swap: a={a}, b={b}");
```

## Example: XOR swap (no overflow for integers, but bitwise semantics)
```csharp
Console.Write("Enter a: ");
if (!int.TryParse(Console.ReadLine(), out int a)) { Console.WriteLine("Invalid input"); return; }
Console.Write("Enter b: ");
if (!int.TryParse(Console.ReadLine(), out int b)) { Console.WriteLine("Invalid input"); return; }

Console.WriteLine($"Before swap: a={a}, b={b}");
// XOR swap
a ^= b;
b ^= a;
a ^= b;

Console.WriteLine($"After swap: a={a}, b={b}");
```

## Explanation
- Arithmetic swap: uses addition/subtraction to move values without a temporary variable. It can overflow when values are large (sum exceeds int.MaxValue).
- XOR swap: uses bitwise XOR, avoids arithmetic overflow, and works for integer types. It can be less readable and must not be used when a and b refer to the same storage location.
- Recommended approach in production: use a temporary variable for clarity and safety. The no-temp tricks are useful mostly for interview discussion or low-level contexts.

## Sample run (arithmetic example)
Input: a=10, b=20
Output:
Before swap: a=10, b=20
After swap: a=20, b=10

## Complexity
- Time: O(1)
- Space: O(1)

## Edge cases & suggestions
- Use int.TryParse for robust input handling and to avoid exceptions.
- Avoid arithmetic swap when there's a possibility of overflow; prefer checked arithmetic or temporary variable.
- Prefer explicit, readable code in production; only use these tricks when explicitly required.

## Interview questions and talking points
- Q: Show how to swap two numbers without a temporary variable. Explain trade-offs. A: Provide arithmetic and XOR solutions; mention overflow and readability trade-offs.
- Q: Which approach is safest? A: Temporary variable — clear and without overflow issues.
- Q: Can XOR swap be used for floating-point numbers? A: No — XOR is a bitwise operation defined for integer types. For other types you need different techniques.

## How to run
- To run the examples: replace Program.cs with one of the snippets above, then run `dotnet run` in this project folder or run from Visual Studio.

