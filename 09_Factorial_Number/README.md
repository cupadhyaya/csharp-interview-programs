# Factorial Number

A console program that computes the factorial of a non-negative integer using an iterative approach. Factorial of n (n!) is the product of all positive integers up to n.

## Program source (Program.cs)
```csharp
Console.WriteLine("Welcome to Factorial Number Program");
Console.Write("Please Enter the number to get the factorial : ");
int number = int.Parse(Console.ReadLine());
int factorial = 1;

for(int i = 1;i<= number; i++)
{
    factorial = factorial * i;
}

Console.WriteLine($"Factorial of given number {number} is : {factorial}");
```

## How it works
- Reads an integer `number` from input.
- Iteratively multiplies numbers from 1 to `number` to compute factorial.

## Sample runs
- Input: `5`
  Output: Factorial of given number 5 is : 120

- Input: `0`
  Output: Factorial of given number 0 is : 1

## Complexity
- Time: O(n) where n is the input number.
- Space: O(1).

## Edge cases & suggestions
- Negative inputs: factorial is not defined for negative integers. Validate input and handle appropriately.
- Large inputs: factorial grows very quickly and will overflow int. Use long or BigInteger for larger ranges and validate or limit input.
- Input parsing: prefer int.TryParse for safer parsing and user-friendly errors.
- Recursive implementation: factorial can also be implemented recursively, but recursion may lead to stack overflow for large n.

## Interview follow-ups
- Q: Can you compute factorial using recursion? A: Yes; show recursive function with base case 0! = 1.
- Q: How to handle very large factorials? A: Use BigInteger to store arbitrarily large values and consider iterative approach for performance.

## How to run
- .NET CLI: run `dotnet run` in this project folder.
- Visual Studio: set project as Startup Project and press F5.
